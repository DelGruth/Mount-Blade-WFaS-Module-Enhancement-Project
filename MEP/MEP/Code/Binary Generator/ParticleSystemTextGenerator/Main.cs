using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MEP.Code.Binary_Generator.ParticleSystemTextGenerator
{
    class Main
    {
        Directory.DetermineDirectory n1 = new Directory.DetermineDirectory();

     public void  Main1(string _Orignal,String _New)
        {
           // Directory.DetermineDirectory n1 = new Directory.DetermineDirectory();
           string dirPath =  n1.DetermineDirectory1();
            if(File.Exists(dirPath+@"/particle_systems.txt")&& !File.Exists(@"./Generated/particle_systems.txt"))
            {

                Console.WriteLine("Orignal exists and generated does not exist,writing");

                string text = File.ReadAllText(dirPath + @"/particle_systems.txt");
                text = text.Replace(_Orignal, _New);
                File.WriteAllText(@"./Generated/particle_systems.txt", text);
            }
            else if (File.Exists(@"./Generated/particle_systems.txt"))
            {
                // Console.WriteLine("")
                Console.WriteLine("The particle system file does exist in the generator folder");
                string text = File.ReadAllText(@"./Generated/particle_systems.txt");
                text = text.Replace(_Orignal, _New);
                File.WriteAllText(@"./Generated/particle_systems.txt", text);
               // Console.WriteLine("file already exists on generated,using generated file.");
            }
            //Generated
            else
            {
                Console.WriteLine("both if statements are not working" + dirPath);
            }

            }

    }
}
