using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setup();
            add();

            disableRow(0);
            disableRow(1);
        }

        private void setup()
        {
            dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;


            dataGridView2.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView2.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

            dataGridView2.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView2.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            dataGridView2.Columns[0].Resizable = DataGridViewTriState.False;
        }

        private void add() {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add(false, "PC");
            dataGridView1.Rows.Add(false, "RAM");
            dataGridView1.Rows.Add(true, "CPU");

            for (int i = 0; i < 100; i++) {
                dataGridView2.Rows.Add(false, "Test");
            }
        }

        private void disableRow(int row) {
            Color color = ColorTranslator.FromHtml("#E0E0E0");

            DataGridViewCell cell = dataGridView1.Rows[row].Cells[0];
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.Value = false;
            chkCell.FlatStyle = FlatStyle.Flat;
            chkCell.Style.ForeColor = color;
            cell.ReadOnly = true;

            dataGridView1.Rows[row].Cells[1].Style.ForeColor = color;
        }

        private void enableRow(int row) {
            DataGridViewCell cell = dataGridView1.Rows[row].Cells[0];
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.FlatStyle = FlatStyle.Standard;
            chkCell.Style.ForeColor = Color.Black;
            cell.ReadOnly = false;

            dataGridView1.Rows[row].Cells[1].Style.ForeColor = Color.Black;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
