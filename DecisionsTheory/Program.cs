using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionsTheory
{
    static class Program
    {

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
    }
}
