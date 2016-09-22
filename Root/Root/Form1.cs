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
            //Größe des Fensters unveränderbar
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        //Führt die gespeicherte Prozedur aus und zeigt dessen Ausgabe in der ComboBox an
        public void fillToolStripButton_Click(object sender, EventArgs e)
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

        public void btnBeenden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vielen Dank und bis zum nächsten Mal!");
            Application.Exit();
        }
    }
}
