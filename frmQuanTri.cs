using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoaChat
{
    public partial class frmQuanTri : Form
    {

        public frmQuanTri()
        {
            InitializeComponent();
        }
        DBadapter modifi = new DBadapter();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modifi.Table("select * from tk");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

