using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Blood enhancement tweak v0.5 by neil_v 
 * Link:http://forums.taleworlds.com/index.php/topic,143179.0.html
 * Use the particles_systems.txt to edit
 */
namespace MEP.Code.Binary_Generator.Mods
{
   public class Blood_Particles
    {
        StreamReader n1 = new StreamReader(@"./Install/uninstall.ini");
        ParticleSystemTextGenerator.Main n2 = new ParticleSystemTextGenerator.Main();
        string Orignal;
        string New;
        string set;
       public Blood_Particles()
        {


            n1.ReadLine();
            
            set = n1.ReadLine();
            n1.Close();
        }
       void Blood_Particles1(string _1st,string _2de)
        {

         
            if (set == "True")
            {

                Console.WriteLine("uninstalling");
                n2.Main1(_2de, _1st);
                //ATG.ActionTextGenerator1(_2de, _1st);
            }
            else if (set != "True")
            {

                n2.Main1(_1st, _2de);
            }
            
           
        }

       public void Editor()
       {
           try
           {
               Orignal = " psys_game_blood 12800 prt_mesh_blood_1  500 0.650000 3.000000 0.500000 0.000000 0.000000 ";
               New = "psys_game_blood 12800 prt_mesh_blood_1  5000 5.650000 3.000000 0.900000 10.000000 10.000000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.000000 0.700000   0.700000 0.700000";
               New = "0.000000 1.000000   1.000000 1.000000";
               Blood_Particles1(Orignal, New);

               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.900000   1.000000 0.900000";
               Blood_Particles1(Orignal, New);

               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.700000   1.000000 0.700000";
               Blood_Particles1(Orignal, New);

               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.700000   1.000000 0.700000";
               Blood_Particles1(Orignal, New);

               Orignal = "0.000000 0.015000   1.000000 0.018000";
               New = "0.100000 0.020000   1.000000 0.150000";
               Blood_Particles1(Orignal, New);

               Orignal = "0.000000 0.050000 0.000000   0.000000 1.000000 0.300000   0.900000 ";
               New = "0.000000 0.050000 0.000000   0.600000 1.100000 1.200000   0.000000 ";
               Blood_Particles1(Orignal, New);


               //  * 
               Orignal = "psys_game_blood_2 12800 prt_mesh_blood_3  2000 0.600000 3.000000 0.300000 0.000000 0.000000 ";
               New = "psys_game_blood_2 12800 prt_mesh_blood_3  5000 0.800000 3.000000 1.100000 10.000000 10.000000 ";
               Blood_Particles1(Orignal, New);
               Orignal = "0.000000 0.250000   0.700000 0.100000";
               New = "0.100000 0.600000   1.000000 0.010000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.500000   1.000000 0.700000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.500000   1.000000 0.700000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.100000 0.700000   1.000000 0.700000";
               New = "0.100000 0.500000   1.000000 0.700000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.000000 0.150000   1.000000 0.350000";
               New = "0.100000 0.100000   1.000000 0.750000";
               Blood_Particles1(Orignal, New);
               Orignal = "0.010000 0.200000 0.010000   0.200000 0.300000 0.000000   0.300000 ";
               New = "0.000000 0.050000 0.000000   0.900000 0.100000 0.200000   0.900000 ";
               Blood_Particles1(Orignal, New);
              /* Orignal = "";
               New = "";
               Blood_Particles1(Orignal, New);*/
           }
           catch (Exception f)
           {
               Console.WriteLine(f.ToString());
               Logger.Logger.Loggeradd(f.ToString());

           }
       }
        
    }
}
