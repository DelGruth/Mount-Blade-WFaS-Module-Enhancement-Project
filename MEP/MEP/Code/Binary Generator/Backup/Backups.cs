using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEP.Code.Binary_Generator.Directory;
using MEP.Code.Logger ;



namespace MEP.Code.Binary_Generator.Backup
{
    class Backups
    {
      Directory.DetermineDirectory n =new Directory.DetermineDirectory();

        public string Directorypath;

        
      
     public void  Backup1()
        {
            Directorypath = n.DetermineDirectory1();
            Console.WriteLine(Directorypath);
            Console.ReadLine();
            
          
   if (!File.Exists(@"./Backup/module.ini"))
  {
  StreamReader ModuleReader =new StreamReader(Directorypath +@"\module.ini");
  string line;
  line = ModuleReader.ReadLine();
			
	while (line !=null)
			{
				//Console.WriteLine(line);

                Logger.Logger.ModuleiniMaker(line);
				line = ModuleReader.ReadLine();
        
			}
			ModuleReader.Close();
   }

   if (!File.Exists(@"./Backup/actions.txt"))
			{
				StreamReader ModuleActionReader =new StreamReader(Directorypath +@"\actions.txt");
			    string line;
				line = ModuleActionReader.ReadLine();
				
				while (line !=null)
				{
					//Console.WriteLine(line);
                    Logger.Logger.ModuleactionMaker(line);
					line = ModuleActionReader.ReadLine();
					//Console.WriteLine("Action text,while loop entered");
					
				}
				ModuleActionReader.Close();
   }

   if (!File.Exists(@"./Backup/particle_systems.txt"))
   {
       StreamReader ModuleActionReader = new StreamReader(Directorypath + @"\particle_systems.txt");
       string line;
       line = ModuleActionReader.ReadLine();

       while (line != null)
       {
           //Console.WriteLine(line);
           Logger.Logger.ModuleparticleMaker(line);
           line = ModuleActionReader.ReadLine();
           //Console.WriteLine("Action text,while loop entered");

       }
       ModuleActionReader.Close();
   }
        }
    

       
    }
}

