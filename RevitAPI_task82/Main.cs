using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPI_task82
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            var nwcOption = new NavisworksExportOptions();
            doc.Export(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "файл.nwc", nwcOption);

            return Result.Succeeded;
        }
    }
}
