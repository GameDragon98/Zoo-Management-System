using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Partial class for the form used to interact with parrots
    public partial class frmParrot : Form
    {
        private Parrot parrot; // Instance of the Parrot class

        // Constructor for the frmParrot form
        public frmParrot(Parrot parrot)
        {
            InitializeComponent();
            this.parrot = parrot; // Initialize the parrot instance
        }

        // Event handler for the form load event
        private void frmParrot_Load(object sender, EventArgs e)
        {
            lblDisplayParrotInfo.Text = Zoo.DisplayAnimalInfo(parrot); // Display parrot information
        }

        // Event handler for the "Submit" button click to feed the parrot
        private void parrotFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            if (parrotFoodTxtBox.Text == "")
            {
                // Show a warning message if the food field is empty
                MessageBox.Show("Please fill the required field.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string food = parrotFoodTxtBox.Text; // Get the food entered by the user
            parrotFoodLbl.Text = parrot.Feed(food); // Feed the parrot with the entered food
            parrotFoodLbl.Show(); // Show the label displaying the feeding message
        }

        // Event handler for the "Move" button click to make the parrot move
        private void parrotMoveBtn_Click(object sender, EventArgs e)
        {
            parrotMoveLbl.Text = parrot.Move(); // Get the parrot's movement message
            parrotMoveLbl.Show(); // Show the label displaying the movement message
        }

        // Event handler for the "Sound" button click to make the parrot speak
        private void parrotSoundBtn_Click(object sender, EventArgs e)
        {
            parrot.Speak(); // Make the parrot speak
        }

        // Event handler for the "Back" button click to go back to the previous form
        private void parrotBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmParrot form)
        }
    }
}
