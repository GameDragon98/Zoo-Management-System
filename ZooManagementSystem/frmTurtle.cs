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
    // Partial class for the form used to interact with turtles
    public partial class frmTurtle : Form
    {
        private Turtle turtle; // Instance of the Turtle class

        // Constructor for the frmTurtle form
        public frmTurtle(Turtle turtle)
        {
            InitializeComponent();
            this.turtle = turtle; // Initialize the turtle instance
        }

        // Event handler for the form load event
        private void frmTurtle_Load(object sender, EventArgs e)
        {
            lblDisplayTurtleInfo.Text = Zoo.DisplayAnimalInfo(turtle); // Display turtle information
        }

        // Event handler for the "Submit" button click to feed the turtle
        private void turtleFoodSubmitBtn_Click(object sender, EventArgs e)
        {
            if (turtleFoodTxtBox.Text == "")
            {
                // Show a warning message if the food field is empty
                MessageBox.Show("Please fill the required field.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string food = turtleFoodTxtBox.Text; // Get the food entered by the user
            turtleFoodLbl.Text = turtle.Feed(food); // Feed the turtle with the entered food
            turtleFoodLbl.Show(); // Show the label displaying the feeding message
        }

        // Event handler for the "Move" button click to make the turtle move
        private void turtleMoveBtn_Click(object sender, EventArgs e)
        {
            turtleMoveLbl.Text = turtle.Move(); // Get the turtle's movement message
            turtleMoveLbl.Show(); // Show the label displaying the movement message
        }

        // Event handler for the "Sound" button click to make the turtle make a sound
        private void turtleSoundBtn_Click(object sender, EventArgs e)
        {
            turtle.Speak(); // Make the turtle make a sound
        }

        // Event handler for the "Back" button click to go back to the previous form
        private void turtleBackBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmTurtle form)
        }
    }
}
