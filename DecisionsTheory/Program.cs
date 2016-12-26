using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DecisionsTheory
{
    static class Program
    {
        public const string TABLE_FORMAT = "{0:0.00000}";
        public static int columnCount = 0;
        public static int rowCount = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static double GetAverage(DataGridView table, int columnIndex)
        {
            double sum = 0.0f;
            for (int i = 0; i < table.RowCount; i++)
            {
                sum += Convert.ToDouble(table.Rows[i].Cells[columnIndex].Value);
            }
            double avg = sum / table.RowCount;
            return avg;
        }

        public static double GetDispRoot(DataGridView table, double columnAvg, int columnIndex)
        {
            double sum = 0.0f;
            for (int i = 0; i < table.RowCount; i++)
            {
                double assertion = Convert.ToDouble(table.Rows[i].Cells[columnIndex].Value) - columnAvg;
                sum += assertion * assertion;
            }
            double sigma = sum / table.RowCount;
            sigma = Math.Sqrt(sigma);
            return sigma;
        }

        public static void ExportDataToWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Thread.Sleep(10);

                Word.Document oDoc = new Word.Document();

                Thread.Sleep(2000);

                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                Thread.Sleep(10);

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }

                //table format
                oRange.Text = oTemp;
                Thread.Sleep(10);

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
                Thread.Sleep(10);

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                Thread.Sleep(10);

                oRange.Select();
                Thread.Sleep(2000);

                oDoc.Application.Selection.Tables[1].Select();
                Thread.Sleep(10);
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                Thread.Sleep(10);
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                Thread.Sleep(10);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                Thread.Sleep(10);
                oDoc.Application.Selection.InsertRowsAbove(1);
                Thread.Sleep(10);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                Thread.Sleep(10);

                //header row style
                //oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                //oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                //oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                Thread.Sleep(10);

                oDoc.Application.Selection.Tables[1].Columns[1].Select();
                oDoc.Application.Selection.InsertColumns();
                oDoc.Application.Selection.Tables[1].Columns[1].Select();
                Thread.Sleep(10);

                for (int c = 0; c <= RowCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(c + 2, 1).Range.Text = DGV.Rows[c].HeaderCell.Value.ToString();
                }
                Thread.Sleep(10);

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Plain Table 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                Thread.Sleep(10);
                
                oRange.Select();
                oDoc.Application.Selection.Rows[oDoc.Application.Selection.Rows.Count].Delete();
                oRange.Select();
                oDoc.Application.Selection.Rows[oDoc.Application.Selection.Rows.Count].Delete();

                oRange.Select();
                oDoc.Application.Selection.Tables[1].Columns[1].Width = 25.0f;
                for (int c = 2; c <= ColumnCount + 1 ; c++)
                {
                    oDoc.Application.Selection.Tables[1].Columns[c].Width = 65;
                }
                //header text
                //foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                //{
                //    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                //    headerRange.Text = "your header text";
                //    headerRange.Font.Size = 16;
                //    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //}

                //save the file
                oDoc.SaveAs2(filename);               
            }
        }
    }
}
