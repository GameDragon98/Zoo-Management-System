using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooManagementSystem
{
    // Lion class inheriting from Animal and implementing IMovable and IFeedable interfaces
    public class Lion : Animal, IMovable, IFeedable
    {
        // Constructor to initialize Lion's name, age, and type
        public Lion(string name, int age) : base(name, age, "Lion") { }

        // Override methods for specific behaviors

        // Override Eat method to specify lion's eating behavior
        public override void Eat(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can consume up to 40kg of meat in a single meal, which is around a quarter of his body weight.");
        }

        // Override Sleep method to specify lion's sleeping behavior
        public override void Sleep(StringBuilder sb)
        {
            sb.AppendLine($"•{Name} can sleep for up to 20 hours a day.");
        }

        // Override Speak method to specify lion's roaring behavior
        public override void Speak(StringBuilder sb)
        {
            sb.AppendLine($"•{Name}'s roar can be heard from a distance of up to 8 kilometers (5 miles)!");
        }

        // Override Speak method to play a roaring sound
        public override void Speak()
        {
            // Play a roaring sound
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\lion_roars.wav");
            simpleSound.Play();
        }

        // Implement the Move method from IMovable interface to specify lion's movement
        public string Move()
        {
            return ($"{Name} is walking through the long grass.");
        }

        // Implement the Feed method from IFeedable interface to specify lion's feeding behavior
        public string Feed(string food)
        {
            return ($"{Name} is eating {food}.");
        }

        // Override method to display lion-specific information
        public override void DisplayInfo(StringBuilder sb)
        {
            base.DisplayInfo(sb); // Call base method to display basic information
        }
    }
}
