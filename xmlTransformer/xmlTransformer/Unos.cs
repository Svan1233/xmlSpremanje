using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;


namespace xmlTransformer
{
    public partial class Unos : Form
    {
        List<Student> studenti = new List<Student>();
        public Unos()
        {
            InitializeComponent();
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Documents\xmlDokument"))
            {
                Directory.CreateDirectory(@"C:\Documents\xmlDokument");
            }
            
            var dokumentXmlStudenti = new XDocument(new XElement("lista_studenata",
                from Student in studenti
                select new XElement("Student",
                    new XAttribute("Ime", Student.Ime),
                    new XAttribute("Prezime", Student.Prezime),
                    new XAttribute("Email", Student.Email),
                    new XAttribute("Razred", Student.Razred)
                    )));

            dokumentXmlStudenti.Save("C:/Documents/xmlDokument/pretraga.xml");

            Form1 frm = new Form1();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIme.Text) || string.IsNullOrEmpty(txtBoxPrezime.Text) || string.IsNullOrEmpty(txtBoxEmail.Text) || string.IsNullOrEmpty(txtBoxRazred.Text))
            {
                MessageBox.Show("Nijedno polje ne smije ostati prazno.");
                return;
            }
            Student a = new Student();

            a.ime = txtBoxIme.Text;
            a.prezime = txtBoxPrezime.Text;
            a.email = txtBoxEmail.Text;
            a.razred = txtBoxRazred.Text;
            studenti.Add(a);
            txtBoxIme.Clear();
            txtBoxPrezime.Clear();
            txtBoxEmail.Clear();
            txtBoxRazred.Clear();
        }
    }
}
