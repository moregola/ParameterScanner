using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ParameterScanner.Service.Interface
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class RevitConnector : IRevitConnector
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            FilteredElementCollector collector = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .WhereElementIsViewIndependent();

            List<Element> matchingElements = collector.ToElements().ToList();

            uidoc.Selection.SetElementIds(matchingElements.ConvertAll(e => e.Id));

            return Result.Succeeded;
        }

        public List<Element> GetElementByNameFromCollectorList(string elementName, FilteredElementCollector collector)
        {
            List<Element> matchingElements = new List<Element>();

            var collectorFiltered = collector.OfClass(typeof(Floor));
            collectorFiltered.Concat(collector.OfClass(typeof(Ceiling)));
            collectorFiltered.Concat(collector.OfClass(typeof(View3D)));

            if(collectorFiltered != null && collectorFiltered.Count() > 0)
            {
                foreach (Element element in collectorFiltered)
                {
                    Parameter param = element.LookupParameter(elementName);
                    if (param != null)
                    {
                        matchingElements.Add(element);
                    }
                }
            }

            return matchingElements;
        }
    }
}