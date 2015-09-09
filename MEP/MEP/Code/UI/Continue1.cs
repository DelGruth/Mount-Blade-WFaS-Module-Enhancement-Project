using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the class which is called after the continue button is clicked,
/// presuming that the user has the most up to date version of software
/// Forms.modpage1.xaml is loaded here
/// </summary>
namespace MEP.Code.UI
{
     class Continue1
    {
        public void Continue()
        {

            MEP.Forms.modpage1 mp1 = new MEP.Forms.modpage1();
            //mp1.Show();
            mp1.ShowDialog();
            
            

        }
    }
}
