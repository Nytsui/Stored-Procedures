using NUnit.Extensions.Forms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Test
{
    [TestFixture]
    public class RootTest : NUnitFormTest
    {

        [Test]
        //Kp was das ist, aber soll wohl da sein
        public override void Setup()
        {
            base.Setup();
        }

        public class mainForm
        {
            [Test]
            public void MainForm()
            {
                Root.Form1 form = new Root.Form1();
                form.ShowDialog();
            }
        }

        //Test für Buttons
        public class Beenden
        {
            [Test]
            public void btnBeenden()
            {
                ButtonTester btnBeenden = new ButtonTester("btnBeenden");
            }

            [Test]
            public void btnBeenden_Click()
            {
                MessageBoxTester btnBeenden_Click = new MessageBoxTester("btnBeenden_Click");
                
                
            }

        }

        //Test für DataGridView
        public class GridView
        {
            [Test]
            public void dataGridView1()
            {
                ControlTester dataGridView = new ControlTester("dataGridView1");
            }
        }


        //Test für TableAdapter
        public class tableAdapter
        {
            [Test]
            public void getIDbyIDTableAdapter()
            {
                
            }
        }

        public class ComboBox
        {
            [Test]
            public void childnameToolTextComboBox()
            {
                //ComboBoxTester ComboTester = new ComboBoxTester("childnameToolTextComboBox");
                ControlTester ComboBoxTest = new ControlTester("childnameToolTextComboBox");
            }
        }

        public class toolStrip
        {
            //"Datenbank" Label
            [Test]
            public void childnameToolStripLabel()
            {
                LabelTester toolStripLabel = new LabelTester("childnameToolStripLabel");
                Assert.AreEqual("Datenbank", toolStripLabel.Text, "Das Labl sollte Datenbank heißen'" + toolStripLabel.Text + "'");
            }

            //Start Button
            [Test]
            public void startToolStrip()
            {
                ButtonTester Start = new ButtonTester("fillToolStripButton");
                Assert.AreEqual("Start", Start.Text, "Der Button sollte Start heißen '" + Start.Text + "'");
            }
        }
    }

}


