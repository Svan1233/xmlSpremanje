using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace xmlTransformer
{
    public class Tester
    {/*
        public static XDocument CreateStudentListXml()
        {
            List<Student> studenti = CreateStudentList();
            
            var dokumentXmlStudenti = new XDocument(new XElement("lista_studenata",
                from Student in studenti
                select new XElement("Student",
                    new XAttribute("Ime", Student.Ime),
                    new XAttribute("Prezime", Student.Prezime),
                    new XElement("Email", Student.Email),
                    new XElement("Razred", Student.Razred)
                    )));
            return dokumentXmlStudenti;
            
        }
        public static List<Student> CreateStudentList()
        {
            List<Student> studenti = new List<Student>();

            foreach (Student a in studenti)
            {
                studenti.Add(a);
            }
            return studenti;
        }*/
    }    
}
