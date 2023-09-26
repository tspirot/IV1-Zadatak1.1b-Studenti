using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1._1b
{
    public partial class Form1 : Form
    {
        List<string> predmeti = new List<string>()
        {
            "Programiranje", "Baze", "Mreze", "Web programiranje"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var predmet in predmeti)
            {
                comboBoxPredmeti.Items.Add(predmet);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            int brInd;
            if(!int.TryParse(textBoxBrIndeksa.Text, out brInd))
            {
                MessageBox.Show("Neispravan broj indeksa!");
                return;
            }
            Student novi = new Student();
            novi.BrIndeksa = brInd;
            novi.Ime = textBoxIme.Text;
            novi.Prezime = textBoxPrezime.Text;
            listBoxStudenti.Items.Add(novi);
        }

        private void listBoxStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudenti.SelectedIndex == -1)
            {
                textBoxBrIndeksa.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
            }
            else
            {
                Student odabrani = (Student)listBoxStudenti.SelectedItem;
                textBoxBrIndeksa.Text = odabrani.BrIndeksa.ToString();
                textBoxIme.Text = odabrani.Ime;
                textBoxPrezime.Text = odabrani.Prezime;
            }
            OsveziOcene();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if(listBoxStudenti.SelectedIndex==-1)
            {
                MessageBox.Show("Niste odabrali studenta!");
                return;
            }
            listBoxStudenti.Items.Remove(listBoxStudenti.SelectedItem);
        }

        private void buttonDodajOcenu_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.SelectedIndex == -1)
            {
                MessageBox.Show("Niste odabrali studenta!");
                return;
            }
            int ocena;
            if (!int.TryParse(textBoxOcena.Text, out ocena))
            {
                MessageBox.Show("Neispravna ocena!");
                return;
            }
            Student odabrani= (Student)listBoxStudenti.SelectedItem;
            if(odabrani.ocene.ContainsKey(comboBoxPredmeti.Text))
            {
                MessageBox.Show("Student vec ima ocenu iz tog predmeta!");
                return;
            }
            odabrani.ocene.Add(comboBoxPredmeti.Text, ocena);
            OsveziOcene();
        }
        // Osvezi listu ocena
        private void OsveziOcene()
        {
            listBoxOcene.Items.Clear();
            if(listBoxStudenti.SelectedIndex==-1)
                return;
            Student odabrani = (Student)listBoxStudenti.SelectedItem;
            foreach(var ocena in odabrani.ocene)
            {
                listBoxOcene.Items.Add(ocena);
            }
        }

        private void buttonObrisiOcenu_Click(object sender, EventArgs e)
        {
            if(listBoxOcene.SelectedIndex==-1)
            {
                MessageBox.Show("Niste odabrali ocenu!");
                return;
            }
            Student odabrani = (Student)listBoxStudenti.SelectedItem;
            var ocena = (KeyValuePair<string,int>)listBoxOcene.SelectedItem;
            odabrani.ocene.Remove(ocena.Key);
            OsveziOcene();
        }

        private void listBoxOcene_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxOcene.SelectedIndex==-1)
            {
                textBoxOcena.Text = "";
                comboBoxPredmeti.SelectedIndex = -1;
                return;
            }
            var ocena = (KeyValuePair<string, int>)listBoxOcene.SelectedItem;
            comboBoxPredmeti.Text = ocena.Key;
            textBoxOcena.Text = ocena.Value.ToString();
        }
    }
}
