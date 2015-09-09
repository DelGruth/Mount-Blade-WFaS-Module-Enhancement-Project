using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Expanded Horizons by Openshaw
 * Link:http://forums.taleworlds.com/index.php/topic,145948.0.html
 * Uses no binaries too edit,only copy and paste and module.ini edit
 */

namespace MEP.Code.Binary_Generator.Mods
{
    class Expaned_Horizons
    {
        StreamReader n1 = new StreamReader(@"./Install/uninstall.ini");
        Directory.DetermineDirectory n2 = new Directory.DetermineDirectory();
        public void editor()
        {

            try { 
            n1.ReadLine();
            n1.ReadLine();
            n1.ReadLine();
            string set = n1.ReadLine();
            n1.Close();
            string dirPath = n2.DetermineDirectory1();
            if (set != "True")
            {
                if (!File.Exists(dirPath + @"/Resource/op_terrain_borders.brf"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\CommonRes\op_terrain_borders.brf", dirPath + @"/Resource/op_terrain_borders.brf");
                if (!File.Exists(dirPath + @"/Resource/op_terrain_borders_b.brf"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\CommonRes\op_terrain_borders_b.brf", dirPath + @"/Resource/op_terrain_borders_b.brf");
                if (!File.Exists(dirPath + @"/Resource/op_terrain_borders_materials.brf"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\CommonRes\op_terrain_borders_materials.brf", dirPath + @"/Resource/op_terrain_borders_materials.brf");
                if (!File.Exists(dirPath + @"/Resource/op_terrain_borders_textures.brf"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\CommonRes\op_terrain_borders_textures.brf", dirPath + @"/Resource/op_terrain_borders_textures.brf");

                if (!File.Exists(dirPath + @"/Textures/op_desert_far.dds"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\Textures\op_desert_far.dds", dirPath + @"/Textures/op_desert_far.dds");
                if (!File.Exists(dirPath + @"/Textures/op_plains_far.dds"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\Textures\op_plains_far.dds", dirPath + @"/Textures/op_plains_far.dds");
                if (!File.Exists(dirPath + @"/Textures/op_snow_far.dds"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\Textures\op_snow_far.dds", dirPath + @"/Textures/op_snow_far.dds");
                if (!File.Exists(dirPath + @"/Textures/op_steppe_far.dds"))
                File.Copy(@".\Assets\Resource\Expanded Horizons by Openshaw\Textures\op_steppe_far.dds", dirPath + @"/Textures/op_steppe_far.dds");
            }
            else if (set == "True")
            {
                File.Delete(dirPath + @"/Resource/op_terrain_borders.brf");
                File.Delete(dirPath + @"/Resource/op_terrain_borders_b.brf");
                File.Delete(dirPath + @"/Resource/op_terrain_borders_materials.brf");
                File.Delete(dirPath + @"/Resource/op_terrain_borders_textures.brf");

                File.Delete(dirPath + @"/Textures/op_desert_far.dds");
                File.Delete(dirPath + @"/Textures/op_plains_far.dds");
                File.Delete(dirPath + @"/Textures/op_snow_far.dds");
                File.Delete(dirPath + @"/Textures/op_steppe_far.dds");
            }
                

                }
            catch (Exception f)
            {
                Logger.Logger.Loggeradd(f.ToString());
                
            }
        }
    }
}
