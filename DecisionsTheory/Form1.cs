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
        }

        private void columnCountNud_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Enabled)
            {
                Program.columnCount = (int)((NumericUpDown)sender).Value;
                AddColumnsToTable(inputTableDgv);
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
            table.RowCount = Program.rowCount;
            for (int i = 0; i < table.RowCount; i++)
            {
                table.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            table.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void openXlsButton_Click_1(object sender, EventArgs e)
        {
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

                columnCountNud.Enabled = false;
                rowCountNud.Enabled = false;

                Program.columnCount = data.Columns.Count;
                Program.rowCount = data.Rows.Count;

                columnCountNud.Value = Program.columnCount;
                rowCountNud.Value = Program.rowCount;

                inputTableDgv.DataSource = data;
            }         
        }
    }
}
