using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jose = new Zoo.Human();
            jose.BoyOrGirl = ("Boy");
            jose.HowTall = 6.4;
            jose.HasTeeth = true;
            jose.Color = ("Tan");
            jose.ImpossibeThumb = true;
            jose.Habitat = ("house");
            Console.WriteLine(string.Format("Jose has {0} legs", jose.HowManylegs));
            Console.WriteLine(string.Format("Jose's height is {0}", jose.HowTall));
            Console.WriteLine();
            Console.WriteLine();
            Cat1 lion = new Cat1();
            lion.Color = ("Golden Brow");
            lion.HowManylegs = 4;
            lion.HasTeeth = true;
            lion.FemaleMale = ("Male");
            lion.Wild = true;
            Console.WriteLine(string.Format("I have a {0} lion named Roger", lion.FemaleMale));
            Console.WriteLine(string.Format("It is {0} Roger is a wild lion King of the jungle", lion.Wild));
            Console.WriteLine();
            Console.WriteLine();
            Turtle tortoise = new Turtle();
            tortoise.Color = ("Grey");
            tortoise.HowManylegs = 4;
            tortoise.HasTeeth = false;
            tortoise.Snapping = false;
            tortoise.Speed = ("slow");
            Console.WriteLine(string.Format("I have a {0} tortoise named Pete", tortoise.Color));
            Console.WriteLine(string.Format("Pete is extremely {0}", tortoise.Speed));
            Console.WriteLine();
            Console.WriteLine();
            Snake rattle = new Snake();
            rattle.Color = ("purple");
            rattle.HowManylegs = 0;
            rattle.HasTeeth = false;
            rattle.Swim = false;
            rattle.Habitat = ("forest");
            Console.WriteLine(string.Format("Is it {0} the snakes rattler is loud", rattle.Rattler));
            Console.WriteLine(string.Format("It's a posioness snake? {0}", rattle.Poisiness));
            Console.WriteLine();
            Console.WriteLine();
            Flamingo american = new Flamingo();
            american.Color = ("Pink");
            american.HowManylegs = 2;
            american.HasTeeth = false;
            american.Fly = true;
            american.NestType = ("straw");
            american.ColoredBeak = ("black");
            american.ColoredLegs = ("black");
            Console.WriteLine(string.Format("I saw a pretty {0} flamingo", american.Color));
            Console.WriteLine("The flamingo has {0} legs", american.HowManylegs);
            Console.WriteLine();
            Console.WriteLine();
            Eagle bald = new Eagle();
            bald.Color = ("White");
            bald.HowManylegs = 2;
            bald.HasTeeth = false;
            bald.Fly = true;
            bald.NestType = ("branches");
            bald.HeadColor = ("black");
            bald.UsaOnly = true;
            Console.WriteLine(string.Format("The body of the eagle is {0} and the eagle's head is {1}", bald.Color, bald.HeadColor));
            Console.WriteLine(string.Format("It is {0} a bald eagle can only be found in the U.S.", bald.UsaOnly));








            Console.ReadLine();


           
        }
    }
}
