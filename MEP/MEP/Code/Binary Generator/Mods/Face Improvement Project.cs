using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Face Improvement Project by Iboltax
 * Link:http://forums.taleworlds.com/index.php/topic,163242.0.html
 * Use Skin.txt
 */

namespace MEP.Code.Binary_Generator.Mods
{
    class Face_Improvement_Project
    {
        StreamReader n1 = new StreamReader(@"./Install/uninstall.ini");
        Directory.DetermineDirectory n2 = new Directory.DetermineDirectory();


        public void Editor()
        {
            try
            {
                //create a string which holds info on wether the app is installing
                //or uninstalling
                n1.ReadLine();
                n1.ReadLine();
                string set = n1.ReadLine();
                n1.Close();
                string dirPath = n2.DetermineDirectory1();
                if (set != "True")
                {
                    DirectoryCopy(@".\Assets\Resource\Face Improvement Project by Iboltax\Resource", dirPath + "/Resource", false);
                    DirectoryCopy(@".\Assets\Resource\Face Improvement Project by Iboltax\Textures", dirPath + "/Textures", false);
                    File.Copy(@".\Assets\Resource\Face Improvement Project by Iboltax\Binary\skins.txt", dirPath + "/skins.txt", true);
                }
                else if (set == "True")
                {
                    File.Copy(@".\Assets\Resource\Face Improvement Project by Iboltax\default\skins.txt", dirPath + "/skins.txt", true);
                    int i = 0;
                    DeleteFile("beards.brf", i);
                    DeleteFile("hair.brf", i);
                    DeleteFile("materials_face_gen.brf", i);
                    DeleteFile("meshes_face_gen.brf", i);
                    DeleteFile("textures_face_gen.brf", i);
                    i = 1;
                    DeleteFile("man_normalmap.dds", i);
                    DeleteFile("manface_asian1", i);
                    DeleteFile("manface_asian1OLD.dds", i);
                    DeleteFile("manface_asian2.dds", i);
                    DeleteFile("manface_asian2OLD.dds", i);
                    DeleteFile("manface_asian3.dds", i);
                    DeleteFile("manface_asian3OLD.dds", i);
                    DeleteFile("manface_black1.dds", i);
                    DeleteFile("manface_black1OLD.dds", i);
                    DeleteFile("manface_black2.dds", i);
                    DeleteFile("manface_black2OLD.dds", i);
                    DeleteFile("manface_black3.dds", i);
                    DeleteFile("manface_black3OLD.dds", i);
                    DeleteFile("manface_mideast1.dds", i);
                    DeleteFile("manface_mideast1OLD.dds", i);
                    DeleteFile("manface_mideast2.dds", i);
                    DeleteFile("manface_mideast2OLD.dds", i);
                    DeleteFile("manface_mideast3.dds", i);
                    DeleteFile("manface_mideast3OLD.dds", i);
                    DeleteFile("manface_white1.dds", i);
                    DeleteFile("manface_white1OLD.dds", i);
                    DeleteFile("manface_white2.dds", i);
                    DeleteFile("manface_white2OLD.dds", i);
                    DeleteFile("manface_white3.dds", i);
                    DeleteFile("manface_white3OLD.dds", i);
                    DeleteFile("manasian_normalmap.dds", i);
                    DeleteFile("manblack_normalmap.dds", i);
                    DeleteFile("manface_asian1.dds", i);



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        void DeleteFile(string FileName,int i)
        {
            string dirPath = n2.DetermineDirectory1();
            if(i == 0) // 0 for resource folder
            File.Delete(dirPath + @"/Resource/"+FileName);
            else if (i==1) //1 for texture folder
            File.Delete(dirPath + @"/Textures/" + FileName);

        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            try
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                DirectoryInfo[] dirs = dir.GetDirectories();

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }

                /* // If the destination directory doesn't exist, create it. 
                 if (!System.IO.Directory.Exists(destDirName))
                 {
                     System.IO.Directory.CreateDirectory(destDirName);

                 }*/

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath,true);
                }

                // If copying subdirectories, copy them and their contents to new location. 
                if (copySubDirs)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Logger.Logger.Loggeradd(e.ToString());

            }
        }
        
    }
}
