using System.Windows.Forms;
using Apoteka.Modeli;
using Apoteka.Servisi.Interfejs;

namespace Apoteka
{
    public partial class Form1 : Form
    {
        private readonly ILekServis _lekServis;

        public Form1(ILekServis lekServis)
        {
            _lekServis = lekServis;
            InitializeComponent();
            _ = Prikaz();
            fillCbx();
        }

        private void fillCbx()
        {
            cbxFilter.Items.Clear();

            cbxFilter.Items.Add("Po bolesti");
            cbxFilter.Items.Add("Po proizvodjacu");
        }

        private async Task Prikaz()
        {
            try
            {
                var lek = await _lekServis.UcitajPodatkeAsync();

                dataGridView1.DataSource = lek;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void dugmeDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Lek NoviLek = new()
                {
                    Naziv = naziv.Text,
                    Vrsta = vrsta.Text,
                    Proizvodjac = proizvodjac.Text,
                    Bolest = bolest.Text,
                    Kolicina = kolicina.Text
                };

                await _lekServis.KreirajNovLek(NoviLek);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _ = Prikaz();
            naziv.Text = "";
            vrsta.Text = "";
            proizvodjac.Text = "";
            bolest.Text = "";
            kolicina.Text = "";
        }

        private async void dugmeIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lekID.Text);

                Lek LekZaIzmenu = new()
                {
                    Naziv = naziv.Text,
                    Vrsta = vrsta.Text,
                    Proizvodjac = proizvodjac.Text,
                    Bolest = bolest.Text,
                    Kolicina = kolicina.Text
                };

                await _lekServis.IzmeniLek(LekZaIzmenu, id);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _ = Prikaz();
            lekID.Text = "";
            naziv.Text = "";
            vrsta.Text = "";
            proizvodjac.Text = "";
            bolest.Text = "";
            kolicina.Text = "";
        }

        private void dugmeObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lekID.Text);
                _lekServis.ObrisiLek(id);
            }
            catch (Exception ex) { }
            _ = Prikaz();
            lekID.Text = "";
            naziv.Text = "";
            vrsta.Text = "";
            proizvodjac.Text = "";
            bolest.Text = "";
            kolicina.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow oznaceniRed = dataGridView1.Rows[e.RowIndex];

                lekID.Text = oznaceniRed.Cells["ID"].Value.ToString();
                naziv.Text = oznaceniRed.Cells["naziv"].Value.ToString();
                vrsta.Text = oznaceniRed.Cells["vrsta"].Value.ToString();
                proizvodjac.Text = oznaceniRed.Cells["proizvodjac"].Value.ToString();
                bolest.Text = oznaceniRed.Cells["bolest"].Value.ToString();
                kolicina.Text = oznaceniRed.Cells["kolicina"].Value.ToString();
            }

            catch (Exception ex) { }

        }

        private async void dugmeFiltriraj_Click(object sender, EventArgs e)
        {
            var oznaceno = cbxFilter.SelectedItem;
            var vrednost = txtFilter.Text;
            var lek = await _lekServis.UcitajPodatkeAsync();

            try
            {
                if (vrednost == "")
                {
                    _ = Prikaz();
                }
                else
                {
                    switch (oznaceno)
                    {
                        case "Po bolesti":
                            lek = await _lekServis.prikazLekovaPoBolesti(vrednost);
                            break;
                        case "Po proizvodjacu":
                            lek = await _lekServis.prikazLekovaPoProizvodjacu(vrednost);
                            break;
                        default:
                            _ = Prikaz();
                            break;
                    }
                    dataGridView1.DataSource = lek;
                }
            }
            catch (Exception ex) { }
        }
    }
}