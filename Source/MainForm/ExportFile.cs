using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace MainForm
{
    class ExportFile
    {
        public void ExportExcel(DataGridView _gridview)
        {
            SaveFileDialog _savedia = new SaveFileDialog();
            _savedia.Title = "Lưu file";
            _savedia.FileName = "";
            _savedia.Filter = "Excel file (2007) |*.xlsx";
            if (_savedia.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 20;
                for (int i = 1; i < _gridview.ColumnCount + 1; i++)
                {
                    ExcelApp.Cells[1, i] = _gridview.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < _gridview.Rows.Count; i++)
                {
                    if (!_gridview.Rows[i].IsNewRow)
                        for (int j = 0; j < _gridview.Columns.Count; j++)
                        {
                            if (_gridview.Rows[i].Cells[j].Value != null)
                                ExcelApp.Cells[i + 2, j + 1] = _gridview.Rows[i].Cells[j].Value.ToString();
                            else
                                ExcelApp.Cells[i + 2, j + 1] = "";
                        }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(_savedia.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                MessageBox.Show("Lưu thành công", "Message!");
                ExcelApp.Quit();
            }
        }
    }
}
