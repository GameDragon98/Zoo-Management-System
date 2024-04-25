using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    // Base class (parent) for all animals
    public class Animal
    {
        public string Name { get; set; }        // Property to store the name of the animal
        public int Age { get; set; }            // Property to store the age of the animal
        public string Type { get; protected set; } // Property to store the type of the animal

        // Default constructor to initialize default values for properties
        public Animal()
        {
            Name = "";
            Age = 0;
            Type = "";
        }

        // Constructor to initialize name, age, and type
        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        // Virtual method to simulate eating behavior
        public virtual void Eat(StringBuilder sb)
        {
            sb.AppendLine($"{Name} is eating.");
        }

        // Virtual method to simulate sleeping behavior
        public virtual void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"{Name} is sleeping.");
        }

        // Virtual method to simulate making a sound
        public virtual void Speak(StringBuilder sb)
        {
            sb.AppendLine($"{Name} makes a sound.");
        }

        // Empty method for Speak, can be overridden by derived classes
        public virtual void Speak()
        {
            // This method intentionally left empty for overriding in derived classes
        }

        // Method to display information about the animal
        public virtual void DisplayInfo(StringBuilder sb)
        {
            sb.AppendLine($"Name: {Name}\nAge: {Age}");
            Eat(sb);
            Speak(sb);
            Sleep(sb);
        }
    }
}
