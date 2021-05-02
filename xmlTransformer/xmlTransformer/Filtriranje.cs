using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace xmlTransformer
{
    public partial class Filtriranje : Form
    {
        public Filtriranje()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var stud = new XDocument();
            
            if (string.IsNullOrEmpty(txtBoxIme.Text))
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                                                               select c));
            }
            else
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                           where c.Attribute("Ime").Value == txtBoxIme.Text
                           select c));
            }
            if (string.IsNullOrEmpty(txtboxPrezime.Text))
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                                                              select c));
            }
            else
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                           where c.Attribute("Prezime").Value == txtboxPrezime.Text
                           select c));
            }
            if (string.IsNullOrEmpty(txtBoxEmail.Text))
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                                                              select c));
            }           
            else
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                           where c.Attribute("Email").Value == txtBoxEmail.Text
                           select c));
            }
            if (string.IsNullOrEmpty(txtBoxRazred.Text))
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                                                              select c));
            }
            else
            {
                stud = new XDocument(new XElement("Student", from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student")
                           where c.Attribute("Razred").Value == txtBoxRazred.Text
                           select c));
            }

            stud.Save("C:/Documents/xmlDokument/filtriranje.xml");

            this.Close();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
