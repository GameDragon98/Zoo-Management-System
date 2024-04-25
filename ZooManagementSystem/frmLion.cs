using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Partial class for the form used to interact with lions
    public partial class frmLion : Form
    {
        private Lion lion; // Instance of the Lion class

        // Constructor for the frmLion form
        public frmLion(Lion lion)
        {
            InitializeComponent();
            this.lion = lion; // Initialize the lion instance
        }

        // Event handler for the form load event
        private void frmLion_Load(object sender, EventArgs e)
        {
            lblDisplayLionInfo.Text = Zoo.DisplayAnimalInfo(lion); // Display lion information
        }

        // Event handler for the "Submit" button click to feed the lion
        private void lionFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            if (lionFoodTxtBox.Text == "")
            {
                // Show a warning message if the food field is empty
                MessageBox.Show("Please fill the required field.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string food = lionFoodTxtBox.Text; // Get the food entered by the user
            lionFoodLbl.Text = lion.Feed(food); // Feed the lion with the entered food
            lionFoodLbl.Show(); // Show the label displaying the feeding message
        }

        // Event handler for the "Move" button click to make the lion move
        private void lionMoveBtn_Click(object sender, EventArgs e)
        {
            lionMoveLbl.Text = lion.Move(); // Get the lion's movement message
            lionMoveLbl.Show(); // Show the label displaying the movement message
        }

        // Event handler for the "Sound" button click to make the lion roar
        private void lionSoundBtn_Click(object sender, EventArgs e)
        {
            lion.Speak(); // Make the lion roar
        }

        // Event handler for the "Back" button click to go back to the previous form
        private void lionBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmLion form)
        }
    }
}
