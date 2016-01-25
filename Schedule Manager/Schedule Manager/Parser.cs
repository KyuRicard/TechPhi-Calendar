using System.Collections.Generic;
using System.IO;
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
            List<Clase> llista = (List<Clase>)reader.Deserialize(file);
            classes = llista;
            file.Close();
        }

        public static List<Clase> GetClases()
        {
            return classes;
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

        public static void RemoveClase(Clase c)
        {
            classes.Remove(c);
        }

        public static void RemoveClase(int index)
        {
            if (index >= 0 && index < classes.Count)
                RemoveClase(classes[index]);
        }
    }
}
