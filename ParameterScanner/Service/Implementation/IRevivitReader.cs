using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterScanner.Service.Implementation
{
    public interface IRevivitReader
    {
        string GetParameterValue(string parameterName);
        string GetParameterValue(string parameterName, string revitFilePath);
    }
}
