using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Xml.Serialization;

/*
 * Name: Rami Aljanaby
 * Date: 11/29/23
 * Program Description: This program suggest a count of land cards for a 100-card MTG Deck based on the color theme of the intended deck. 
 *                      It takes into account the main color for the deck and displays the appropriate land card count based on the main color theme of the deck.
 */

namespace WindowsFormsApp1
{
    public partial class manaBaseGeneratorEDH : Form
    {
        public manaBaseGeneratorEDH()
        {
            InitializeComponent();

            // this loop identifies which radio buttons are checked and assigns a Tag to each one to be used for identification later
            foreach (RadioButton radioButton in Controls.OfType<RadioButton>())
            {
                redRadioBtn1.Tag = 1;
                blackRadioBtn2.Tag = 2;
                blueRadioBtn3.Tag = 3;
                whiteRadioBtn4.Tag = 4;
                greenRadioBtn5.Tag =5;

                radioButton.CheckedChanged += redRadioBtn_CheckedChanged;
                radioButton.CheckedChanged += blackRadioBtn_CheckedChanged;
                radioButton.CheckedChanged += blueRadioBtn_CheckedChanged;
                radioButton.CheckedChanged += whiteRadioBtn_CheckedChanged;
                radioButton.CheckedChanged += greenRadioBtn_CheckedChanged;
            }


        }

        //Create arrays for the checkbox states and the radio button states
        const int SIZE = 5;
        bool[] checkboxStates = new bool[SIZE];
        private string [] colorArray = {"Red", "Black", "Blue", "White", "Green" };
        private string selectedString;


        private void UpdateCheckboxStates()
        {
            // Method to update the checkbox array with the current state of checkboxes
            checkboxStates[0] = redCheckBox.Checked;
            checkboxStates[1] = blackCheckBox.Checked;
            checkboxStates[2] = blueCheckBox.Checked;
            checkboxStates[3] = whiteCheckBox.Checked;
            checkboxStates[4] = greenCheckBox.Checked;
        }

        //Below are 5 event handlers for each radio button
        private void redRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Checks which radio buttons are selected and indexes them based on the button Tag
            RadioButton selectedRadioButton = sender as RadioButton;
            if (redRadioBtn1 != null && redRadioBtn1.Checked)
            {
                int selectedIndex = Convert.ToInt32(redRadioBtn1.Tag);
                selectedString = colorArray[selectedIndex-1];
                //The checkboxes are linked to the radio button selection - selecting a radio button will check and disable the corresponding checkbox
                redCheckBox.Checked = true;
                redCheckBox.Enabled = false;

            }
            else
            {
                redCheckBox.Checked = false;
                redCheckBox.Enabled = true;
            }

        }
        
        private void blackRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (blackRadioBtn2 != null && blackRadioBtn2.Checked)
            {
                int selectedIndex = Convert.ToInt32(blackRadioBtn2.Tag);
                selectedString = colorArray[selectedIndex -1];
                blackCheckBox.Checked = true;
                blackCheckBox.Enabled = false;

            }
            else
            {
                blackCheckBox.Checked = false;
                blackCheckBox.Enabled = true;
            }
        
        }
       
        private void blueRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (blueRadioBtn3 != null && blueRadioBtn3.Checked)
            {
                int selectedIndex = Convert.ToInt32(blueRadioBtn3.Tag);
                selectedString = colorArray[selectedIndex - 1];
                blueCheckBox.Checked = true;
                blueCheckBox.Enabled = false;

            }
            else
            {
                blueCheckBox.Checked = false;
                blueCheckBox.Enabled = true;
            }
        }
        private void whiteRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (whiteRadioBtn4 != null && whiteRadioBtn4.Checked)
            {
                int selectedIndex = Convert.ToInt32(whiteRadioBtn4.Tag);
                selectedString = colorArray[selectedIndex - 1];

                whiteCheckBox.Checked = true;
                whiteCheckBox.Enabled = false;

            }
            else
            {
                whiteCheckBox.Checked = false;
                whiteCheckBox.Enabled = true;
            }
        }
        private void greenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (greenRadioBtn5 != null && greenRadioBtn5.Checked)
            {
                int selectedIndex = Convert.ToInt32(greenRadioBtn5.Tag);
                selectedString = colorArray[selectedIndex - 1];
                greenCheckBox.Checked = true;
                greenCheckBox.Enabled = false;

            }
            else
            {
                greenCheckBox.Checked = false;
                greenCheckBox.Enabled = true;
            }
        }
        
        //Method to be executed when called by the calculate button event
        public void GenerateManaBase()
        {
            // Check and display the current state of checkboxes
            UpdateCheckboxStates();

            int oneCheckBox = 1;
            int twoCheckboxes = 2;
            int threeCheckboxes = 3;
            int fourCheckboxes = 4;
            int fiveCheckboxes = 5;

            int checkedCount = checkboxStates.Count(checkbox => checkbox);

            // Verifies if the specified number of checkboxes are checked then displays the results based on input
            if (checkedCount == oneCheckBox )
            {
                label1.Text = "Proposed breakdown: \n" + "12 " + selectedString +"\n"+ "23 Utility  ";

            }

            else if (checkedCount == twoCheckboxes)
            {
                
                label1.Text = "Proposed breakdown: \n" + "12 " + selectedString + "\n" + "8 Fixing Lands\n" + "13 Utility Lands";
            }

            else if (checkedCount == threeCheckboxes)
            {
                label1.Text = "Proposed breakdown: \n" + "12 Basic Lands(4 " + selectedString + ",4,4)\n" + "8 Fetch Lands\n" + "8 Fixing Lands\n" + "7 Utility Lands";
            }

            else if (checkedCount == fourCheckboxes)
            {
                label1.Text = "Proposed breakdown: \n" + "12 Basic Lands(6 " + selectedString + ",2,2,2)\n" + "8 Fetch Lands\n" + "8 Fixing Lands\n" + "7 Utility Lands\n";
            }

            else if (checkedCount == fiveCheckboxes)
            {
                label1.Text = "Proposed breakdown: \n" + "15 Basics(7 " + selectedString + ",2,2,2,2)\n" + "8 Fetch Lands\n" + "8 Fixing Lands\n" + "4 Utility Lands\n";
            }
            else
            {
                MessageBox.Show("Please select at least one option");
            }
        }

        private bool IsAnyRBSelected()
        {
            // Check if any of the radio buttons are selected
            return redRadioBtn1.Checked || blackRadioBtn2.Checked || blueRadioBtn3.Checked || whiteRadioBtn4.Checked || greenRadioBtn5.Checked;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            
            if (!IsAnyRBSelected())
            {
                // Show an error window if no radio buttons are selected
                MessageBox.Show("Please elect your main color!");
                return;
            }
            //Call the calculation method
            GenerateManaBase();
          
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void saveToFileBtn_Click(object sender, EventArgs e)
        {
            string resultFile = label1.Text;
            StreamWriter outputFile;
            outputFile = File.CreateText("ManaBase.txt");
            outputFile.Write(resultFile);
            outputFile.WriteLine();
            outputFile.Close();
            MessageBox.Show("The file was saved succesfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent;
            StreamReader inputfile;

            inputfile = File.OpenText("ManaBase.txt");
            fileContent = inputfile.ReadToEnd();
            label1.Text = fileContent;
            inputfile.Close();
        }

        
    }
}
