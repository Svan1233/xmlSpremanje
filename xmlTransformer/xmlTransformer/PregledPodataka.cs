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
using System.Xml;

namespace xmlTransformer
{
    public partial class PregledPodataka : Form
    {
        public PregledPodataka()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1();
            this.Hide();
            DialogResult rez = frm.ShowDialog();
            this.Close();
        }

        private void btnUcitajDoc_Click(object sender, EventArgs e)
        {

            var stud = from c in XElement.Load("C:/Documents/xmlDokument/pretraga.xml").Elements("Student").Attributes()
                       select c;

            foreach (var item in stud)
            {
                rtbPregled.Text += item + "\n";
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filtriranje frm = new Filtriranje();
            frm.ShowDialog();
            this.Show();
            var listaUcenika = from c in XElement.Load("C:/Documents/xmlDokument/filtriranje.xml").Elements("Student").Attributes()
                               select c;
            rtbPregled.Clear();
            foreach (var item in listaUcenika)
            {
                rtbPregled.Text += item.ToString() + " \n";
            }                      
        }
        
    }
}
