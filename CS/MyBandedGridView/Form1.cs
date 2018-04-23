using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyXtraGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Column1", typeof(String));
            for (int i = 0; i < 10; i++)
                dataTable1.Rows.Add("Item " + i);
            myGridControl1.DataSource = dataTable1;
        }
    }
}
