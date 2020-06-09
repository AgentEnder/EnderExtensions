using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace EnderExtensionsVSTO
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void copyAsSql_Click(object sender, RibbonControlEventArgs e)
        {
            var toCopy = "(";
            dynamic selection = Globals.ThisAddIn.Application.Selection;
            if (selection is Excel.Range)
            {
                var cells = selection as Excel.Range;
                for (int cellIdx = 1; cellIdx <= cells.Count; cellIdx++)
                {
                    var cell = cells[cellIdx] as Excel.Range;
                    toCopy += $"'{cell.Text}',";
                }
                toCopy = toCopy.TrimEnd(',');
            }
            toCopy += ")";
            Clipboard.SetText(toCopy);
        }

        private void copyAsNumericSql_Click(object sender, RibbonControlEventArgs e)
        {
            var toCopy = "(";
            dynamic selection = Globals.ThisAddIn.Application.Selection;
            if (selection is Excel.Range)
            {
                var cells = selection as Excel.Range;
                for (int cellIdx = 1; cellIdx <= cells.Count; cellIdx++)
                {
                    var cell = cells[cellIdx] as Excel.Range;
                    toCopy += $"{cell.Text},";
                }
                toCopy = toCopy.TrimEnd(',');
            }
            toCopy += ")";
            Clipboard.SetText(toCopy);
        }

        private void copyAsCSharp_Click(object sender, RibbonControlEventArgs e)
        {
            var toCopy = "new [] {";
            dynamic selection = Globals.ThisAddIn.Application.Selection;
            if (selection is Excel.Range)
            {
                var cells = selection as Excel.Range;
                for (int cellIdx = 1; cellIdx <= cells.Count; cellIdx++)
                {
                    var cell = cells[cellIdx] as Excel.Range;
                    toCopy += $"\"{cell.Text}\",";
                }
                toCopy = toCopy.TrimEnd(',');
            }
            toCopy += "};";
            Clipboard.SetText(toCopy);
        }

        private void copyAsCSharpNumeric_Click(object sender, RibbonControlEventArgs e)
        {
            var toCopy = "new [] {";
            dynamic selection = Globals.ThisAddIn.Application.Selection;
            if (selection is Excel.Range)
            {
                var cells = selection as Excel.Range;
                for (int cellIdx = 1; cellIdx <= cells.Count; cellIdx++)
                {
                    var cell = cells[cellIdx] as Excel.Range;
                    toCopy += $"{cell.Text},";
                }
                toCopy = toCopy.TrimEnd(',');
            }
            toCopy += "};";
            Clipboard.SetText(toCopy);
        }
    }
}
