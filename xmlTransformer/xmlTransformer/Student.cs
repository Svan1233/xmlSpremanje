using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlTransformer
{
    class Student
    {
        public string ime;
        public string prezime;
        public string email;
        public string razred;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Razred { get => razred; set => razred = value; }

        public Student ()
        { }
        public Student(string ime,string prezime,string email,string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.razred = razred;
        }
    }
}
