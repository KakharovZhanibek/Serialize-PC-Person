using InviteUser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLib.Model
{
    public class ServicePerson
    {
        string[] mass = new string[] { "Прошел на красный", "Нанес тяжелые телесные повреждения", "Ношение холодного оружия", "Просто правонарушение" };

        public static void GenerateW()
        {
            ServiceUser n = new ServiceUser();
            List<results> m = n.InvokeUser();

            Person p = new Person();
            p.Name = m[0].name.first;
            p.age = Int32.Parse(m[0].dob.age);

            XmlSerializer x = new XmlSerializer(p.GetType());

            using (FileStream f = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\doc.xml", FileMode.OpenOrCreate))
            {
                x.Serialize(f, p);
                Console.WriteLine("Объект успешно сериализировался");
            }
        }
        public static void Deserialize()
        {
            Person p = new Person();

            XmlSerializer x = new XmlSerializer(p.GetType());
            using (FileStream f = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\doc.xml", FileMode.OpenOrCreate))
            {
                p = (Person)x.Deserialize(f);
                p.Name = p.Name + "new Name";
                Console.WriteLine("Объект успешно десериализировался");
            }

            using (FileStream f = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\doc.xml", FileMode.OpenOrCreate))
            {
                x.Serialize(f, p);
                Console.WriteLine("Объект успешно сериализировался");
            }
        }
    }
}
