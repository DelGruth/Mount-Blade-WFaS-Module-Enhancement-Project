using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MEP.Code.VersionControl
{
  public  class versionchecker
    {
        CurrentSoftwareVersion csv = new CurrentSoftwareVersion();
        WebClient wc = new WebClient();
      public  bool UptodateorNot()
        {
            string mostrecentversion = "v0110a";//wc.DownloadString("https://bbuseruploads.s3.amazonaws.com/WFaSmep/m.e.p./downloads/version.txt?Signature=9PyB5%2BvudgOXWuK7AonGXO0Gx28%3D&Expires=1408064200&AWSAccessKeyId=0EMWEFSGA12Z1HF1TZ82");
            if(csv.Version !=mostrecentversion){
                return false;


            }
            else if(csv.Version ==mostrecentversion) {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
