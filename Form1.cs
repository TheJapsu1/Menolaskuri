using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Menolaskuri
{
    public partial class Form1 : Form
    {
        // Lista johon menot lisätään.
        // Käytetään tyyppiä BindingList, koska kyseinen tyyppi pystyy päivittämään sille annetun BindingSourcen (alempana) automaattisesti.
        private BindingList<Meno> menot;

        public Form1()
        {
            InitializeComponent();

            Aloitus();
        }

        private void Aloitus()
        {
            // Luodaan menot -bindinglista
            menot = new BindingList<Meno>();

            // Asetetaan UI:n listan dataSource, jolloin UI päivittyy automaattisesti listaa muutettaessa
            BindingSource source = new BindingSource(menot, null);
            dataGridView.DataSource = source;

            // Populoidaan kategoria -dropdown "Kategoria" -enumin arvoilla
            categorySelection.DataSource = Enum.GetValues(typeof(Kategoria));

            // Asetetaan dataGridView:n asetukset:
            // Automaattiset sarakkeet
            dataGridView.AutoGenerateColumns = true;
            // Piilotetaan rivin ensimmäinen osa (rivin valintakolmio)
            dataGridView.RowHeadersVisible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Haetaan UI:stä kategoria. Poistutaan funktiosta aikaisin, jos annettu arvo on virheellinen.
            if (!Enum.TryParse(categorySelection.SelectedValue.ToString(), out Kategoria kategoria)) return;

            // Haetaan UI:sta rahamäärä. Poistutaan funktiosta aikaisin, jos annettu arvo on virheellinen.
            if (!double.TryParse(moneyInput.Text, out double rahaMaara)) return;

            // Haetaan UI:sta käyttäjän selitys
            string selitys = explanationInput.Text;

            // Luodaan uusi meno
            Meno uusiMeno = new Meno(kategoria, rahaMaara, selitys);

            // Lisätään juuri luotu meno
            LisaaUusiMeno(uusiMeno);
        }

        private void LisaaUusiMeno(Meno uusiMeno)
        {
            menot.Add(uusiMeno);
        }
    }
}
