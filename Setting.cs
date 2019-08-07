using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class Settings
    {
        public bool RememberUser { get; set; }
        public String LastAccessToken { get; set;}

        public Settings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveLastUserToFile()
        {
            if (File.Exists(@"C:\Users\Public\AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Users\Public\AppSettings.xml", FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(@"C:\Users\Public\AppSettings.xml", FileMode.CreateNew))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    serializer.Serialize(stream, this);
                }
            }
        }
        
        public static Settings LoadLastUser()
        {
            Settings obj = new Settings();
            if (File.Exists(@"C:\Users\Public\AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Users\Public\AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    obj = serializer.Deserialize(stream) as Settings;
                }
            }
            return obj;
        }
    }
}
