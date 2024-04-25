using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    // Partial class for the form used to add animals to the zoo
    public partial class frmAdd : Form
    {
        private Zoo zoo; // Instance of the Zoo class to manage animals

        // Constructor for the frmAdd form
        public frmAdd(Zoo zoo)
        {
            InitializeComponent();
            this.zoo = zoo; // Initialize the zoo instance
        }

        // Event handler for the "Submit" button click
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text) || string.IsNullOrWhiteSpace(ageTxtBox.Text) || string.IsNullOrWhiteSpace(typeCmbBox.Text))
            {
                // Show a warning message if any of the fields are empty
                MessageBox.Show("Please fill all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the age provided is a valid integer
            if (!int.TryParse(ageTxtBox.Text, out int age))
            {
                // Show a warning message if age is not a valid integer
                MessageBox.Show("Please enter a valid integer for age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract name and type of the animal
            string name = nameTxtBox.Text;
            string type = typeCmbBox.Text;

            // Add the animal based on its type
            switch (type)
            {
                case "Lion":
                    zoo.AddAnimal(new Lion(name, age));
                    break;
                case "Parrot":
                    zoo.AddAnimal(new Parrot(name, age));
                    break;
                case "Turtle":
                    zoo.AddAnimal(new Turtle(name, age));
                    break;
                default:
                    // Show a warning message for invalid animal type
                    MessageBox.Show("Invalid animal type.", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Close the current form (frmAdd form)
            this.Close();
        }

        // Event handler for the "Back" button click
        private void backBtn1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmAdd form)
        }
    }
}
