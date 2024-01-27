using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextEditor
{
    internal class FileManager
    {
        public static string Read()
        {
            Console.WriteLine("Введите путь к файлу включая его название");
            string p = Console.ReadLine();
            string ext = Path.GetExtension(p);
            if (ext == ".txt")
            {
                string text = File.ReadAllText(p);
                Console.WriteLine(text);
            }
            if (ext == ".json")
            {
                string text = File.ReadAllText(p);
                Console.WriteLine(text);
            }
            if (ext == ".xml")
            {
                Animal Textik;
                XmlSerializer xml = new XmlSerializer(typeof(Animal));
                using (FileStream fs = new FileStream(p, FileMode.Open))
                {
                    Textik = (Animal)xml.Deserialize(fs);
                }
                Console.WriteLine(Textik);
            }
            return p;
        }

        public static void Save()
        {
            Animal Lagushka = new Animal()
            {
                Name = "Лягушка",
                Power = 1,
                Speed = 3
            };
            Animal Jaba = new Animal()
            {
                Name = "Жаба",
                Power = 3,
                Speed = 2
            };
            Animal Cat = new Animal()
            {
                Name = "Кот",
                Power = 4,
                Speed = 5
            };
            List<Animal> animals = new List<Animal>();
            animals.Add(Lagushka);
            animals.Add(Jaba);
            animals.Add(Cat);

            Console.WriteLine("Введите путь куда вы хотите сохранить включая название и расширение файла");
            string p = Console.ReadLine();
            string ext = Path.GetExtension(p);
            if (ext == ".txt")
            {
                string text = File.ReadAllText(p);
                File.WriteAllText(p, text);
            }
            if (ext == ".json")
            {
                string text = File.ReadAllText(p);
                File.WriteAllText(p, text);
            }
        }
    }
}
