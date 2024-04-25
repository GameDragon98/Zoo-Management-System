namespace ZooManagementSystem
{
    // Partial class for the main form of the application
    public partial class frmMain : Form
    {
        private Zoo zoo; // Instance of the Zoo class to manage animals
        private Animal selectedAnimal; // Selected animal to interact with

        // Constructor for the main form
        public frmMain()
        {
            InitializeComponent();
            zoo = new Zoo(); // Create an instance of the Zoo class
            selectedAnimal = new Animal(); // Initialize the selected animal
        }

        // Event handler for the "Add" button click
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Hide the Menu form
            this.Visible = false;

            // Show the frmAdd form for adding new animals
            frmAdd form = new frmAdd(zoo);
            form.ShowDialog(); // Use ShowDialog to ensure the Menu form waits until frmAdd form is closed

            // Show the Menu form again after frmAdd form is closed
            this.Visible = true;
        }

        // Event handler for the "Interact" button click
        private void interactBtn_Click(object sender, EventArgs e)
        {
            // Hide the Menu form
            this.Visible = false;

            // Show the frmInteract form for interacting with animals
            frmInteract form = new frmInteract(zoo, selectedAnimal);
            form.ShowDialog(); // Use ShowDialog to ensure the Menu form waits until frmInteract form is closed

            // Show the Menu form again after frmInteract form is closed
            this.Visible = true;
        }

        // Event handler for the "Exit" button click
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
