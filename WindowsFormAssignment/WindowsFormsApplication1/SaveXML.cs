using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    //Serialization enables access to saving information to a XML file.
    public class SaveXML
    {
        public static void SaveData(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename); //Allows to save data under a file name created
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}
