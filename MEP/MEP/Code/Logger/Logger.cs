using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MEP.Code.Logger
{
    class Logger
    {
        public static void Loggeradd(string myString)
        {
            try
            {
                string Time= DateTime.Now.ToLongTimeString();
                StreamWriter t1 = new StreamWriter("./logs.txt", true);
                t1.WriteLine(Time + ": "+myString);
                t1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {


            }




        }
        public static void ModuleiniMaker(string myString)
        {
            try
            {

                StreamWriter t1 = new StreamWriter("./Backup/module.ini", true);
                t1.WriteLine(myString);
                t1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {


            }





        }
        public static void ModuleactionMaker(string myString)
        {
            try
            {

                StreamWriter t1 = new StreamWriter("./Backup/actions.txt", true);
                t1.WriteLine(myString);
                t1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {


            }
        }
        public static void ModuleparticleMaker(string myString)
        {
            try
            {

                StreamWriter t1 = new StreamWriter("./Backup/particle_systems.txt", true);
                t1.WriteLine(myString);
                t1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {


            }
        }
    }
}
