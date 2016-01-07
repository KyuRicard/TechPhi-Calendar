using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Calendari
{
    class Parser
    {
        private static List<Clase> classes = new List<Clase>();
        public static void ReadXML(string route)
        {
            var reader = new XmlSerializer(typeof(List<Clase>));
            var file = new StreamReader(route);

        }

        public static bool WriteXML(string route)
        {
            if (!File.Exists(route))
            {
                File.Create(route).Close();
            }
            if (classes.Count == 0)
            {
                return false;
            }
            var writer = new XmlSerializer(typeof (List<Clase>));
            var file = new StreamWriter(route);
            writer.Serialize(file, classes);
            file.Close();
            return true;
        }

        public static void AddClase(Clase c)
        {
            classes.Add(c);
        }
    }
}
