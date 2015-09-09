using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace MEP.Code.Binary_Generator
{
  public  class MainLoop
    {
       public MainLoop()   {
           try
           {
               //creates backups for the needed files (have to add particle systems)
               Backup.Backups n = new Backup.Backups();
               n.Backup1();
             
               //Created the first page of mods which the user can select
               Forms.modpage1 n2 = new Forms.modpage1();
               StreamReader nj = new StreamReader(@"./Install/install.ini");
              
               //These variables read the install settings,
               //to have a mod installed remember to read the correct line
               string gencat = nj.ReadLine();
               string genblood = nj.ReadLine();
               string faceimprovment = nj.ReadLine();
               string expandedhorizon = nj.ReadLine();
               string genRealisticcolors = nj.ReadLine();
               nj.Close();
              
               //This window is created after the mods have been selected
               Forms.AfterModsSelection.ModsConfirmation n3 = new Forms.AfterModsSelection.ModsConfirmation();
             
               //Determines if the user selected to install the combat animation enhancment 
               if (gencat == "True")
               {
                  
                  
                   //calls the files which generate the new binaries 
                   Mods.Combat_Animation_Enhancement n1 = new Mods.Combat_Animation_Enhancement();
                   n1.Editor();

                   Console.WriteLine("The enhancment will be done,var is: " + gencat);
               
               }
               else
               {

                   Console.WriteLine("Do not generate Combat animation text,var is: " + gencat);
                  
               }
            
               if (genblood == "True")
               {
                   Console.WriteLine("The new Blood Texture will be implmented" + genblood);
                  //used to generate the new binaries
                   Mods.Blood_Particles n5 = new Mods.Blood_Particles();
                   n5.Editor();

                   
               }
               else
               {
                   Console.WriteLine("'Blood texture enhancment won't be done");
               }

               if (faceimprovment == "True")
               {
                   Mods.Face_Improvement_Project n5 = new Mods.Face_Improvement_Project();
                   n5.Editor();
               }
               else
               {
                   Console.WriteLine("Face Improvment mod won't be done var is : " + faceimprovment);
               }
               if(expandedhorizon =="True")
               {
                   Mods.Expaned_Horizons n5 = new Mods.Expaned_Horizons();
                   n5.editor();
               }
               else 
                   Console.WriteLine("Expanded horizon won't be done,var is : "+expandedhorizon);
               if (genRealisticcolors == "True")
               {
                   Mods.Realistic_Colors n6 = new Mods.Realistic_Colors();
                   n6.editor();
               }
               else
                   Console.WriteLine("Realistic colors won't be done,car is: " + genRealisticcolors);
           }
           catch (Exception f)
           {
               Console.WriteLine(f.ToString());
               MessageBox.Show(f.ToString());
               Logger.Logger.Loggeradd(f.ToString());
           }
    }
    }
}
