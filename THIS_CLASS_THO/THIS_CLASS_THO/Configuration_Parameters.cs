using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace THIS_CLASS_THO
{
    public class Configuration_Parameters
    {
        //by making the default constructor private it becomes impossible for a third party user to create an 
        //object of type configuration_parameters Without providing a file name. 
        private Configuration_Parameters()
        {

        }
        
        public Configuration_Parameters(String configFileName)
        {
            FileStream fs = File.Open(configFileName, FileMode.Open, FileAccess.Read, FileShare.None);
            if(fs== null)
            {
                Console.WriteLine("this shit dont work - abort mission");
            }
            else
            {
                Console.WriteLine("file is available for your veiwing pleasure");
            }

        }

        String user;
        String password;
        String host;
        String current_database;
    }
}
