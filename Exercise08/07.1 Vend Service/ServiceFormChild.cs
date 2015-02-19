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
    public partial class ServiceFormChild : Form
    {
        public ServiceFormChild()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBoxNote.Text);
                }
            }
        }

        public string TextBoxNote
        {
            get 
            { 
                return textBoxNote.Text; 
            }
            set
            {
                textBoxNote.Text = value;
            }
        }
            
    }
}
