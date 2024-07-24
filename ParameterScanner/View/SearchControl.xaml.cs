using Autodesk.Revit.DB;
using ParameterScanner.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;
using System.Windows.Controls;


namespace ParameterScanner.View
{
    /// <summary>
    /// Interação lógica para SearchControl.xam
    /// </summary>
    public partial class SearchControl : UserControl
    {
        private Document _document;
        public bool ShowResult { get; set; } = false;
        private readonly RevitConnector _revitConnector;
        public SearchControl()
        {
            InitializeComponent();
            _revitConnector = new RevitConnector();
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            ShowResult = !ShowResult;
            TextBoxResult.Visibility = ShowResult ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
            TextBoxResult.Text += $"\n{Parameter_Name.Text}: {Parameter_Value.Text}\n";
            ViewButton.Name = "Hide";
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            FilteredElementCollector collector = new FilteredElementCollector(_document)
                 .WhereElementIsNotElementType();

            var elementsFound = _revitConnector.GetElementByNameFromCollectorList(Parameter_Name.Text, collector);
            
            string parameterName = Parameter_Name.Text;

            foreach (Element element in elementsFound)
            {
                // Lookup the parameter by name in each element
                Parameter param = element.LookupParameter(parameterName);
                if (param != null)
                {
                    // Return the parameter value as a string
                    Parameter_Value.Text = param.AsString();
                }
            }
        }

        private void ParameterNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ParameterValueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
