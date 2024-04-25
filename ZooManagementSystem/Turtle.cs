using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    // Derived class (child) for Turtle
    public class Turtle : Animal, IMovable, IFeedable
    {
        // Constructor to initialize Turtle's name, age, and type
        public Turtle(string name, int age) : base(name, age, "Turtle") { }

        // Override methods for specific behaviors

        // Override Eat method to specify turtle's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} enjoys a diverse diet, munching on plants, fruits, insects, and even small fish.");
        }

        // Override Sleep method to specify turtle's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep underwater for approximately 4 to 7 hours at a time.");
        }

        // Override Speak method to specify turtle's communication behavior
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} communicates mainly through body language.");
        }

        // Override Speak method to play a breathing sound
        public override void Speak()
        {
            // Play a breathing sound
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\turtle_breathing.wav");
            simpleSound.Play();
        }

        // Implement the Move method from IMovable interface to specify turtle's movement
        public string Move()
        {
            return ($"{Name} is swimming gracefully.");
        }

        // Implement the Feed method from IFeedable interface to specify turtle's feeding behavior
        public string Feed(string food)
        {
            return ($"{Name} is eating {food}.");
        }

        // Override method to display turtle-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb); // Call base method to display basic information
        }
    }
}
