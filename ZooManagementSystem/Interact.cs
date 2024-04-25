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
    // Partial class for the form used to interact with animals
    public partial class frmInteract : Form
    {
        private Zoo zoo; // Instance of the Zoo class to manage animals
        private Animal selectedAnimal; // Selected animal to interact with

        // Constructor for the frmInteract form
        public frmInteract(Zoo zoo, Animal selectedAnimal)
        {
            InitializeComponent();
            this.zoo = zoo; // Initialize the zoo instance
            this.selectedAnimal = selectedAnimal; // Initialize the selected animal
            PopulateComboBoxes(); // Populate ComboBoxes with animal names
        }

        // Method to populate ComboBoxes with animal names
        private void PopulateComboBoxes()
        {
            foreach (var lion in zoo.GetLions())
            {
                lionCmbBox.Items.Add(lion.Name);
            }

            foreach (var parrot in zoo.GetParrots())
            {
                parrotCmbBox.Items.Add(parrot.Name);
            }

            foreach (var turtle in zoo.GetTurtles())
            {
                turtleCmbBox.Items.Add(turtle.Name);
            }
        }

        // Event handler for Lion ComboBox selection change
        private void lionCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lionCmbBox.SelectedItem != null)
            {
                // Update selected animal and enable submit button
                selectedAnimal = zoo.GetLions().FirstOrDefault(l => l.Name == lionCmbBox.SelectedItem.ToString());
                EnableSubmitButton();

                // Disable other ComboBoxes
                parrotCmbBox.Enabled = false;
                turtleCmbBox.Enabled = false;
            }
        }

        // Event handler for Parrot ComboBox selection change
        private void parrotCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (parrotCmbBox.SelectedItem != null)
            {
                // Update selected animal and enable submit button
                selectedAnimal = zoo.GetParrots().FirstOrDefault(p => p.Name == parrotCmbBox.SelectedItem.ToString());
                EnableSubmitButton();

                // Disable other ComboBoxes
                lionCmbBox.Enabled = false;
                turtleCmbBox.Enabled = false;
            }
        }

        // Event handler for Turtle ComboBox selection change
        private void turtleCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (turtleCmbBox.SelectedItem != null)
            {
                // Update selected animal and enable submit button
                selectedAnimal = zoo.GetTurtles().FirstOrDefault(t => t.Name == turtleCmbBox.SelectedItem.ToString());
                EnableSubmitButton();

                // Disable other ComboBoxes
                lionCmbBox.Enabled = false;
                parrotCmbBox.Enabled = false;
            }
        }

        // Method to enable or disable the submit button based on the selected animal
        private void EnableSubmitButton()
        {
            interactSubmitBtn.Enabled = selectedAnimal != null;
        }

        // Event handler for the "Reset" button click
        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Enable all ComboBoxes
            lionCmbBox.Enabled = true;
            parrotCmbBox.Enabled = true;
            turtleCmbBox.Enabled = true;

            // Clear selection by setting SelectedIndex to -1
            lionCmbBox.SelectedIndex = -1;
            parrotCmbBox.SelectedIndex = -1;
            turtleCmbBox.SelectedIndex = -1;

            // Clear selectedAnimal
            selectedAnimal = null;

            // Disable submit button if no item is selected
            EnableSubmitButton();
        }

        // Event handler for the "Submit" button click
        private void submitBtn2_Click(object sender, EventArgs e)
        {
            // Hide the frmInteract form
            this.Hide();

            // If no animal is selected, show a message and return
            if (selectedAnimal == null)
            {
                MessageBox.Show("Please select an animal.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check the selected animal type and open the corresponding form
            if (zoo.GetLions().Any(l => l.Name == selectedAnimal.Name))
            {
                frmLion lionForm = new frmLion((Lion)selectedAnimal);
                lionForm.ShowDialog();
            }
            else if (zoo.GetParrots().Any(p => p.Name == selectedAnimal.Name))
            {
                frmParrot parrotForm = new frmParrot((Parrot)selectedAnimal);
                parrotForm.ShowDialog();
            }
            else if (zoo.GetTurtles().Any(t => t.Name == selectedAnimal.Name))
            {
                frmTurtle turtleForm = new frmTurtle((Turtle)selectedAnimal);
                turtleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selected animal is not recognized.", "Invalid Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Show the frmInteract form again after the other form is closed
            this.Show();
        }

        // Event handler for the "Back" button click
        private void backBtn3_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form (frmInteract form)
        }
    }
}
