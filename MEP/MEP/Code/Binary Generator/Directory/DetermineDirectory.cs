using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows;


namespace MEP.Code.Binary_Generator.Directory
{
    public class DetermineDirectory
    {
        //string filepath;
        public string DetermineDirectory1()
        {
            


            string filepath = @"C:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

            if (!File.Exists((@"./Install/Directory.ini")))
            {
                if (System.IO.Directory.Exists(filepath))
                {
                    return filepath;
                    //  return @"C:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                    // FilePath = @"C:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                }
                else if (System.IO.Directory.Exists(@"C:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                {
                    return @"C:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                }
                else if (System.IO.Directory.Exists(@"C:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"C:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"C:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"C:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                else if (System.IO.Directory.Exists(@"E:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"E:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"E:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"E:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"E:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"E:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"E:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"E:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                else if (System.IO.Directory.Exists(@"F:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"F:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"F:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"F:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"F:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"F:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"F:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"F:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                else if (System.IO.Directory.Exists(@"Z:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"Z:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"Z:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"Z:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"Z:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"Z:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"Z:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"Z:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                else if (System.IO.Directory.Exists(@"D:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"D:\Program Files (x86)\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"D:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"D:\Program Files (x86)\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"D:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"D:\Program Files\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"D:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"D:\Program Files\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";

                else if (System.IO.Directory.Exists(@"C:\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"C:\Mount&Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else if (System.IO.Directory.Exists(@"C:\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem"))
                    return @"C:\Steam\SteamApps\common\Mount & Blade With Fire and Sword\Modules\Ogniem i Mieczem";
                else
                {
                    try
                    {

                        if (!File.Exists(@"./Install/Directory.ini"))
                        {
                            Forms.Directory.selectdirectory n1 = new Forms.Directory.selectdirectory();
                            Console.WriteLine("Window showing");
                            n1.ShowDialog();


                            //while ( == true)
                            string dirpath = n1.t1();
                            Console.WriteLine("This is the result at dd : " + dirpath);
                            n1.Close();
                            Console.WriteLine("commanded to close window");
                            if (System.IO.Directory.Exists(dirpath))
                            {
                                StreamWriter n5 = new StreamWriter(@"./Install/Directory.ini");
                                n5.WriteLine(dirpath);
                                n5.Close();
                                Console.WriteLine("returned this value of dd final cleared it exists" + dirpath);
                                return dirpath;
                            }


                        }

                        else if (File.Exists(@"./Install/Directory.ini"))
                        {

                            StreamReader n5 = new StreamReader(@"./Install/Directory.ini");
                            string var = n5.ReadLine();
                            n5.Close();
                            return var;
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString());
                        Logger.Logger.Loggeradd(f.ToString());
                        return "";
                    }




                    return "";

                }
            }
            else
            {
                StreamReader n1 = new StreamReader((@"./Install/Directory.ini"));
                string dirpath = n1.ReadLine();
                n1.Close();
                if (System.IO.Directory.Exists(dirpath))
                {


                    return dirpath;
                }
                return null;
            }
        }
    }
}

