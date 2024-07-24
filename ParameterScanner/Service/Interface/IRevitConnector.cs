using System;
using System.Collections.Generic;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ParameterScanner.Service.Interface
{
    public interface IRevitConnector : IExternalCommand,IDisposable
    {
        List<Element> GetElementByNameFromCollectorList(string elementName, FilteredElementCollector collector);
    }
}
