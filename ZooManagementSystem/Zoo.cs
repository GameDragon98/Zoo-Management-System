using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    public class Zoo
    {
        private List<Animal> animals;  // List to store all animals in the zoo
        private List<Lion> lions;      // List to store lions in the zoo
        private List<Parrot> parrots;  // List to store parrots in the zoo
        private List<Turtle> turtles;  // List to store turtles in the zoo

        // Constructor to initialize the lists of animals
        public Zoo()
        {
            animals = new List<Animal>();
            lions = new List<Lion>();
            parrots = new List<Parrot>();
            turtles = new List<Turtle>();
        }

        // Method to add an animal to the zoo
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);

            // Check the type of the animal and add it to the respective list
            if (animal is Lion lion)
            {
                lions.Add(lion);
            }
            else if (animal is Parrot parrot)
            {
                parrots.Add(parrot);
            }
            else if (animal is Turtle turtle)
            {
                turtles.Add(turtle);
            }

            // Display a message indicating the addition of the animal
            MessageBox.Show($"Added {animal.Name} to the zoo.", "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to get the list of lions in the zoo
        public List<Lion> GetLions()
        {
            return lions;
        }

        // Method to get the list of parrots in the zoo
        public List<Parrot> GetParrots()
        {
            return parrots;
        }

        // Method to get the list of turtles in the zoo
        public List<Turtle> GetTurtles()
        {
            return turtles;
        }

        // Method to display information about a selected animal
        public static string DisplayAnimalInfo(Animal SelectedAnimal)
        {
            StringBuilder sb = new StringBuilder();

            // If the selected animal is found, display its information
            if (SelectedAnimal != null)
            {
                SelectedAnimal.DisplayInfo(sb);
            }
            else
            {
                sb.AppendLine($"Animal with name '{SelectedAnimal}' not found.");
            }

            return sb.ToString();
        }

    }
}
