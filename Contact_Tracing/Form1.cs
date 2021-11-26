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
        string Q1;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Sample\\" + txtbxFirstName.Text + " " + txtbxLastName.Text + ".txt");
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
    }
}