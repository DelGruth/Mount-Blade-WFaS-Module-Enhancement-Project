using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MEP.Code.Binary_Generator.ActionModuleTextGenerator
{
    class Main
    {
        Backup.Backups n1 = new Backup.Backups();
        string dirPath ;
        Directory.DetermineDirectory n2 = new Directory.DetermineDirectory();
        
      public Main(){
           dirPath = n2.DetermineDirectory1();
    }
     
        public void ActionTextGenerator1(string _Orignal, string _New)
        {

            Console.WriteLine("Action TextReader generator 1 entered");
           // string dirPath = n1.Directorypath;
          //  while (dirPath != null)
            //{
               // dirPath = n2.DetermineDirectory1();
                Console.WriteLine("this is the path at action text generator: "+dirPath);
                //was generated
                if (File.Exists(dirPath + @"/actions.txt") && !File.Exists(@"./Generated/actions.txt"))
                {
                   

                    Console.WriteLine("Orignal exists and generated does not exist,writing");

                    string text = File.ReadAllText(dirPath + @"/actions.txt");
                    //	text = text.Replace("0.750000 defend_forward_onehanded 20 41 4 0 0.0 0.0 0.0 0.0" 
                    //                   ,"0.750000 1h_lowblock_11.9.10 20 41 4 0 0.0 0.0 0.0 0.0 "
                    //                    );
                    text = text.Replace(_Orignal, _New);
                    File.WriteAllText(@"./Generated/actions.txt", text);
                }
                else if (File.Exists(@"./Generated/actions.txt"))
                {
                   // Console.WriteLine("")
                    Console.WriteLine("The action file does exist in the generator folder");
                    string text = File.ReadAllText(@"./Generated/actions.txt");
                    text = text.Replace(_Orignal, _New);
                    File.WriteAllText(@"./Generated/actions.txt", text);
                    Console.WriteLine("file already exists on generated,using generated file.");
                }  
            //Generated
                else
                {
                    Console.WriteLine("both if statements are not working" + dirPath);
                }

                Console.WriteLine("Exiting Action generator");
            }
        //}
    }
}
