using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsTheory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void columnCountNud_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Enabled)
            {
                Program.columnCount = (int)((NumericUpDown)sender).Value;
                AddColumnsToTable(inputTableDgv);
            }
            AddRowsToTable(averagesTable1, Program.columnCount);
            AddRowsToTable(averagesTable2, Program.columnCount);
            for (int i = 0; i < averagesTable1.Rows.Count; i++)
            {
                averagesTable1.Rows[i].HeaderCell.Value = inputTableDgv.Columns[i].HeaderText;
                averagesTable2.Rows[i].HeaderCell.Value = inputTableDgv.Columns[i].HeaderText;
            }
        }

        private void rowCountNud_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Enabled)
            {
                Program.rowCount = (int)((NumericUpDown)sender).Value;
                AddRowsToTable(inputTableDgv);
            }
        }

        private void openXlsButton_Click_1(object sender, EventArgs e)
        {
            Reset();
            string path = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                string name = "Sheet1";
                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                path +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                DataTable data = new DataTable();
                sda.Fill(data);

                inputTableDgv.ColumnCount = 0;
                inputTableDgv.RowCount = 0;

                inputTableDgv.DataSource = data;

                for (int i = 0; i < inputTableDgv.RowCount; i++)
                {
                    inputTableDgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }

                columnCountNud.Enabled = false;
                rowCountNud.Enabled = false;

                Program.columnCount = data.Columns.Count;
                Program.rowCount = data.Rows.Count;

                columnCountNud.Value = Program.columnCount;
                rowCountNud.Value = Program.rowCount;

                PopulateAveragesTable(averagesTable1, inputTableDgv);
                EnableTab(tabControl.TabPages[1], true);
                con.Close();
            }
        }

        private void calcAvgsButton_Click(object sender, EventArgs e)
        {
            PopulateAveragesTable(averagesTable1, inputTableDgv);
            EnableTab(tabControl.TabPages[1], true);
        }

        private void calcAvgsButton2_Click(object sender, EventArgs e)
        {
            PopulateAveragesTable(averagesTable2, secondTable);
            EnableTab(tabControl.TabPages[2], true);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void calculateSecondTableButton_Click(object sender, EventArgs e)
        {
            secondTable.ColumnCount = inputTableDgv.ColumnCount;
            secondTable.RowCount = inputTableDgv.RowCount;
            CalculateSecondTable();
            PopulateAveragesTable(averagesTable2, secondTable);
            EnableTab(tabControl.TabPages[2], true);
        }

        private void AddColumnsToTable(DataGridView table)
        {
            table.ColumnCount = Program.columnCount;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.Columns[i].Name = "x" + (i + 1);
            }
            table.AutoResizeColumns();
        }

        private void AddRowsToTable(DataGridView table)
        {
            AddRowsToTable(table, Program.rowCount);
        }

        private void AddRowsToTable(DataGridView table, int count)
        {
            table.RowCount = count;
            for (int i = 0; i < table.RowCount; i++)
            {
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }            
        }

        private void Reset()
        {
            inputTableDgv.DataSource = null;

            columnCountNud.Enabled = true;
            rowCountNud.Enabled = true;

            columnCountNud.Value = 0;
            rowCountNud.Value = 0;

            secondTable.ColumnCount = 0;
            secondTable.RowCount = 0;

            corTable.ColumnCount = 0;
            corTable.RowCount = 0;

            signifCoefTable.ColumnCount = 0;
            signifCoefTable.RowCount = 0;

            EnableTab(tabControl.TabPages[1], false);
            EnableTab(tabControl.TabPages[2], false);
        }

        private void PopulateAveragesTable(DataGridView avgTable, DataGridView inputTable)
        {
            for (int i = 0; i < avgTable.Rows.Count; i++)
            {
                double avg = Program.GetAverage(inputTable, i);
                avgTable.Rows[i].Cells[0].Value = String.Format(Program.TABLE_FORMAT, avg);
                avgTable.Rows[i].Cells[1].Value = String.Format(Program.TABLE_FORMAT, Program.GetDispRoot(inputTable, avg, i));
            }
        }

        private void CalculateSecondTable()
        {
            for (int i = 0; i < secondTable.ColumnCount; i++)
            {
                secondTable.Columns[i].HeaderText = inputTableDgv.Columns[i].HeaderText;
            }
            for (int i = 0; i < secondTable.RowCount; i++)
            {
                secondTable.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < secondTable.ColumnCount; j++)
                {
                    double x = Convert.ToDouble(inputTableDgv.Rows[i].Cells[j].Value);
                    double avg = Convert.ToDouble(averagesTable1.Rows[j].Cells[0].Value);
                    double sigma = Convert.ToDouble(averagesTable1.Rows[j].Cells[1].Value);
                    secondTable.Rows[i].Cells[j].Value = String.Format(Program.TABLE_FORMAT, (x - avg) / sigma);
                }
            }
        }

        private void CalculateCorTable()
        {
            corTable.ColumnCount = inputTableDgv.ColumnCount;
            corTable.RowCount = inputTableDgv.ColumnCount;
            for (int i = 0; i < corTable.ColumnCount; i++)
            {
                corTable.Columns[i].HeaderText = inputTableDgv.Columns[i].HeaderText;
                corTable.Rows[i].HeaderCell.Value = inputTableDgv.Columns[i].HeaderText;
            }
            for (int i = 0; i < corTable.RowCount; i++)
            {
                for (int j = 0; j < corTable.ColumnCount; j++)
                {
                    double sum = 0;
                    double xA = Convert.ToDouble(averagesTable2.Rows[i].Cells[0].Value);
                    double yA = Convert.ToDouble(averagesTable2.Rows[j].Cells[0].Value);
                    double xSigma = Convert.ToDouble(averagesTable2.Rows[i].Cells[1].Value);
                    double ySigma = Convert.ToDouble(averagesTable2.Rows[j].Cells[1].Value);
                    for (int k = 0; k < Program.rowCount; k++)
                    {
                        double x = Convert.ToDouble(secondTable.Rows[k].Cells[i].Value);
                        double y = Convert.ToDouble(secondTable.Rows[k].Cells[j].Value);

                        sum += (x - xA) * (y - yA);
                    }
                    double result = (sum / Program.rowCount) / (xSigma * ySigma);
                    result = result > 1.0f ? 1.0f : result;
                    result = result < -1.0f ? -1.0f : result;
                    corTable.Rows[i].Cells[j].Value = String.Format(Program.TABLE_FORMAT, result);
                    if (Convert.ToDouble(corTable.Rows[i].Cells[j].Value) >= 0.75f)
                    {
                        corTable.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(193, 235, 255);
                    }
                }
            }
        }

        private void CalculateSignifCoefTable()
        {
            signifCoefTable.ColumnCount = inputTableDgv.ColumnCount;
            signifCoefTable.RowCount = inputTableDgv.ColumnCount;
            for (int i = 0; i < corTable.ColumnCount; i++)
            {
                signifCoefTable.Columns[i].HeaderText = inputTableDgv.Columns[i].HeaderText;
                signifCoefTable.Rows[i].HeaderCell.Value = inputTableDgv.Columns[i].HeaderText;
            }
            for (int i = 0; i < signifCoefTable.RowCount; i++)
            {
                for (int j = 0; j < signifCoefTable.ColumnCount; j++)
                {
                    double r = Convert.ToDouble(corTable.Rows[i].Cells[j].Value);
                    double result = r * (Math.Sqrt(Program.rowCount - 2) / Math.Sqrt(1 - (r * r)));
                    if (r < 1 && r > -1)
                    {
                        signifCoefTable.Rows[i].Cells[j].Value = String.Format(Program.TABLE_FORMAT, result);
                    }
                    else
                    {
                        string s = "";
                        if (r <= -1)
                            s = "-";
                        s += "∞";
                        signifCoefTable.Rows[i].Cells[j].Value = s;
                    }
                }
            }
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            foreach (Control ctl in page.Controls) ctl.Enabled = enable;
        }

        private void calculateCorTableButton_Click(object sender, EventArgs e)
        {
            CalculateCorTable();
            CalculateSignifCoefTable();
        }

        private void calcSignifCoefButton_Click(object sender, EventArgs e)
        {
            CalculateSignifCoefTable();
        }

        private void saveInDocButton_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Program.ExportDataToWord(corTable, saveFileDialog1.FileName);
            }
        }
    }
}
