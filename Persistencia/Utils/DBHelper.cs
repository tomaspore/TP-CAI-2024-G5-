using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DBHelper
    {
        private string filePath;

        public DBHelper(String dataBaseName)
        {
            string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Path.Combine(solutionDirectory, dataBaseName + ".txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        public void Insertar(string key, string value)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{key}|{value}");
            }
        }

        public void Modificar(string key, string newValue)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            bool modified = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] keyValue = lines[i].Split('|');
                if (keyValue[0] == key)
                {
                    lines[i] = $"{key}|{newValue}";
                    modified = true;
                    break;
                }
            }

            if (modified)
            {
                File.WriteAllLines(filePath, lines);
            }
        }

        public string Buscar(string key)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] keyValue = line.Split('|');
                if (keyValue[0] == key)
                {
                    return keyValue[1];
                }
            }

            return null;
        }

        public List<string> Listar()
        {
            return File.ReadAllLines(filePath).ToList();
        }
    }
}


