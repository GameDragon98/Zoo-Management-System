using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagementSystem
{
    // Derived class (child) for Parrot
    public class Parrot : Animal, IMovable, IFeedable
    {
        // Constructor to initialize Parrot's name, age, and type
        public Parrot(string name, int age) : base(name, age, "Parrot") { }

        // Override methods for specific behaviors

        // Override Eat method to specify parrot's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} enjoys a colorful diet, munching on fruits, nuts, seeds, and veggies.");
        }

        // Override Sleep method to specify parrot's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep with one eye open to stay alert.");
        }

        // Override Speak method to specify parrot's speaking behavior
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can learn hundreds of words and phrases to communicate.");
        }

        // Override Speak method to play a squawking sound
        public override void Speak()
        {
            // Play a squawking sound
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\parrot_squawks.wav");
            simpleSound.Play();
        }

        // Implement the Move method from IMovable interface to specify parrot's movement
        public string Move()
        {
            return ($"{Name} is flying over the trees.");
        }

        // Implement the Feed method from IFeedable interface to specify parrot's feeding behavior
        public string Feed(string food)
        {
            return ($"{Name} is eating {food}.");
        }

        // Override method to display parrot-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb); // Call base method to display basic information
        }
    }
}
