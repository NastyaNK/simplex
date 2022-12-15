using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexMethod
{
    public partial class Form1 : Form
    {
        double[,] table;
        double[] result;

        public Form1()
        {
            InitializeComponent();
            ChangeSize();
            dataZ.Rows.Clear();
            dataZ.Rows.Add();
            comboBox1.SelectedIndex = 0;
        }

        private void ChangeSize()
        {
            int n = (int)cols.Value;
            int m = (int)rows.Value;
            while (dataA.Columns.Count != n)
            {
                if (n > dataA.Columns.Count)
                {
                    dataA.Columns.Add("x" + (dataA.Columns.Count + 1), "x" + (dataA.Columns.Count + 1));
                    dataZ.Columns.Add("x" + (dataZ.Columns.Count + 1), "");
                }
                else
                {
                    dataA.Columns.Remove("x" + dataA.Columns.Count);
                    dataZ.Columns.Remove("x" + dataZ.Columns.Count);
                }
            }
            while (dataB.Rows.Count != m)
            {
                if (m > dataB.Rows.Count)
                {
                    dataA.Rows.Add();
                    dataB.Rows.Add();
                }
                else
                {
                    dataA.Rows.Remove(dataA.Rows[dataA.Rows.Count - 1]);
                    dataB.Rows.Remove(dataB.Rows[dataB.Rows.Count - 1]);
                }
            }
            for (int i = 0; i < dataA.Rows.Count; i++)
            {
                for (int j = 0; j < dataA.Columns.Count; j++)
                    if (dataA.Rows[i].Cells[j].Value == null)
                        dataA.Rows[i].Cells[j].Value = 0;
                if (dataB.Rows[i].Cells[0].Value == null)
                    dataB.Rows[i].Cells[0].Value = 0;
            }
        }

        private void solve_Click(object sender, EventArgs e)
        {
            table = new double[dataA.Rows.Count + 1, dataA.Columns.Count + 1];
            result = new double[dataA.Columns.Count];
            for (int i = 0; i < dataA.Rows.Count; i++)
            {
                for (int j = 0; j < dataA.Columns.Count; j++)
                {
                    if (dataA.Rows[i].Cells[j].Value == null)
                        dataA.Rows[i].Cells[j].Value = 0;
                    if (!double.TryParse(dataA.Rows[i].Cells[j].Value.ToString(), out table[i, j + 1]))
                    {
                        MessageBox.Show("Ячейка A[" + i + ":" + j + "] содержит ошибку");
                        return;
                    }
                    if (i == dataA.Rows.Count - 1)
                    {
                        if (dataZ.Rows[0].Cells[j].Value == null)
                            dataZ.Rows[0].Cells[j].Value = 0;
                        if (!double.TryParse(dataZ.Rows[0].Cells[j].Value.ToString(), out table[i+1, j + 1]))
                        {
                            MessageBox.Show("Ячейка A[" + i + ":" + j + "] содержит ошибку");
                            return;
                        }
                        if (comboBox1.SelectedIndex == 0) table[i + 1, j + 1] *= -1;
                    }
                }
                if (dataB.Rows[i].Cells[0].Value == null)
                    dataB.Rows[i].Cells[0].Value = 0;
                if (!double.TryParse(dataB.Rows[i].Cells[0].Value.ToString(), out table[i, 0]))
                {
                    MessageBox.Show("Ячейка B[" + i + "] содержит ошибку");
                    return;
                }
            }
            Simplex s = new Simplex(table);
            s.Calculate(result);
            dataR.Columns.Clear();
            double x = 0;
            for (int i = 0; i < result.Length; i++)
            {
                dataR.Columns.Add("z" + (i + 1), "");
                if (i == 0)
                {
                    dataR.Rows.Add();
                }
                dataR.Rows[0].Cells[i].Value = result[i];
                x += double.Parse(dataR.Rows[0].Cells[i].Value.ToString()) * double.Parse(dataZ.Rows[0].Cells[i].Value.ToString());
            }
            textBox1.Text = x + "";
        }

        private void rows_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void cols_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void dataA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string str = e.FormattedValue.ToString().Trim();
            if (str.Length != 0 && !double.TryParse(str, out _))
            {
                ((DataGridView)sender).CurrentCell.Value = null;
                e.Cancel = true;
            }
        }

        private void dataB_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataA_CellValidating(sender, e);
        }

        private void dataZ_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataA_CellValidating(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label7.Text = "Максимум:";
                    break;
                case 1:
                    label7.Text = "Минимум:";
                    break;
            }
        }
    }
}
