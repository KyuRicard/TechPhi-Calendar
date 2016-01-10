using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Calendari
{
    class Parser
    {
        private static List<Clase> classes = new List<Clase>();
        private static int[] Score = new int[10];

        public static void ReadXML(string route)
        {
            var reader = new XmlSerializer(typeof(List<Clase>));
            var file = new StreamReader(route);
            classes = (List<Clase>)reader.Deserialize(file);
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
        
        public static void ReadScore()
        {
            var reader = new XmlSerializer(typeof(int[]));
            var file = new StreamReader("scores.xml");
            Score = (int[])reader.Deserialize(file);
        }

        public static void WriteScore(string route)
        {
            if (!File.Exists(route))
            {
                File.Create(route).Close();
            }            
            var writer = new XmlSerializer(typeof(int[]));
            var file = new StreamWriter(route);
            writer.Serialize(file, Score);
            file.Close();
        }

        public static int[] GetScores()
        {
            return Order();
        }

        private static int[] Order()
        {
            int[] score = Score;
            for (int i = 0; i < score.Length; i++)
            {
                for (int j = i; j < score.Length; j++)
                {
                    if (score[i] < score[j])
                    {
                        int tmp = score[i];
                        score[i] = score[j];
                        score[j] = tmp;
                        i--;
                        break;
                    }
                }
            }
            return score;
        }

        public static void SetScores(int[] score)
        {
            Score = score;
            WriteScore("scores.xml");
        }
    }

   
}
