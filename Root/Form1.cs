using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getIDbyIDTableAdapter.Fill(this.database1DataSet.GetIDbyID, childnameToolTextComboBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vielen Dank und bis zum nächsten Mal!");
            Application.Exit();
        }
    }
}
