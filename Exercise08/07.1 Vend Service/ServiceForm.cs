using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07._1_Vend_Service
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceFormChild myServiceNote = new ServiceFormChild();
            myServiceNote.MdiParent = this;
            myServiceNote.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceFormChild myServiceNote = new ServiceFormChild();
            myServiceNote.MdiParent = this;

            OpenFileDialog OpenFD = new OpenFileDialog();
            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(OpenFD.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                using (sr)
                {
                    string buffer = sr.ReadToEnd();
                    myServiceNote.TextBoxNote = buffer;
                }
            }

            myServiceNote.Show();


            /*
            Stream myStream = null;
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.InitialDirectory = "c:\\";
            openFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFD.FilterIndex = 2;
            openFD.RestoreDirectory = true;
            if(openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFD.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // insert code to read the stream here.
                            ServiceFormChild myServiceNote = new ServiceFormChild();
                            myServiceNote.MdiParent = this;
                            myServiceNote
                            myServiceNote.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Couldn't read the file from disk ({0})", ex.Message);
                }
            }
             * */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
