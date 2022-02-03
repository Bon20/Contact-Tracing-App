using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Sample\\" + txtbxFirstName.Text + " " + txtbxLastName.Text + ".txt");
            MessageBox.Show("Submitted!");
            var datenow = DateTime.Now;

            sw.WriteLine(datenow.ToLongDateString());
            sw.WriteLine(datenow.ToShortTimeString());


            sw.WriteLine(lblFirstName.Text + " " + txtbxFirstName.Text);
            sw.WriteLine(lblLastName.Text + " " + txtbxLastName.Text);
            sw.WriteLine(lblContactNum.Text + " " + txtbxContactNum.Text);
            sw.WriteLine(lblAge.Text + " " + txtbxAge.Text);
            sw.WriteLine(lblGender.Text + " " + cbGender.Text);
            sw.WriteLine(lblAddress.Text + " " + txtbxAddress.Text);
            sw.WriteLine(lblFever.Text + " " + cbFever.Text);
            sw.WriteLine(lblCough.Text + " " + cbCough.Text);
            sw.WriteLine(lblColds.Text + " " + cbColds.Text);
            sw.WriteLine(lblSoreThroat.Text + " " + cbSoreThroat.Text);
            sw.WriteLine(lblDiffInBreathing.Text + " " + cbDiffInBreathing.Text);
            sw.WriteLine(lblDiarrhea.Text + " " + cbDiarrhea.Text);
            
            if (radbutYes.Checked == true)
            {
                sw.WriteLine(gbxQuestion1.Text + radbutYes.Text);
            }
            else 
            {
                sw.WriteLine(gbxQuestion1.Text +" " + radbutNo.Text);
            }
            sw.Close();
        }

        private void btnVIewLIst_Click_1(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    RBbox1.Text = filetext;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RBbox1.Clear();
        }
    }
}