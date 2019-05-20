using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            string lastName;
            string givenName;
            string petsName;

            lastName = LastnameInput.Text;
            givenName = GivenNameInput.Text;
            petsName = petsNameinput.Text;
            Output.Text = "Last Name:" + lastName +
            Environment.NewLine + "First Name: " + givenName +
            Environment.NewLine + "Pet's Name: " + petsName;

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            {
                LastnameInput.Clear();
                GivenNameInput.Clear();
                petsNameinput.Clear();
                comboBoxHour.SelectedIndex = -1;
                comboBoxMins.SelectedIndex = -1;
                AnimalTypeCBO.SelectedIndex = -1;
                comboBoxHour.Text = "Hour";
                comboBoxMins.Text = "Mins";
                AnimalTypeCBO.Text = "Animal Type";
                rCheckup.Checked = false;
                RDental.Checked = false;
                RHospital.Checked = false;
                RXray.Checked = false;
                RSpay.Checked = false;
                RInnoculations.Checked = false;
                RDrB.Checked = false;
                RDrC.Checked = false;
                RDrT.Checked = false;
                AMR.Checked = false;
                PMR.Checked = false;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GivenNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RDrB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Joan;
        }

        private void RDrC_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Bell;

        }

        private void RDrT_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Corb;

        }
    }
}
