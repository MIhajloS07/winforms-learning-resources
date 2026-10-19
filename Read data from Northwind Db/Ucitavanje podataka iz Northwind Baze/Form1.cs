using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ucitavanje_podataka_iz_Northwind_Baze
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da;
        private DataTable dt;
        public Form1() => InitializeComponent();

        //private void Form1_Load(object sender, System.EventArgs e) => UcitajPrevoznike();

        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        List<Prevoznik> prevoznici = Prevoznik.UcitajSve();
        //        if (prevoznici != null && prevoznici.Count > 0)
        //        {
        //            dgvPrevoznici.DataSource = prevoznici;
        //            dgvPrevoznici.Columns["ShipperID"].HeaderText = "ID Prevoznika";
        //            dgvPrevoznici.Columns["CompanyName"].HeaderText = "Naziv Kompanije";
        //            dgvPrevoznici.Columns["Phone"].HeaderText = "Telefon";
        //        }
        //        else
        //        {
        //            MessageBox.Show(
        //                "Nema dostupnih prevoznika za prikaz.",
        //                "Informacija",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Information
        //            );  
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(
        //            $"Greška prilikom učitavanja podataka: {ex.Message}",
        //            "Greška",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            $"Neočekivana greška: {ex.Message}",
        //            "Greška",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //        );
        //    }
        //}

        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    SqlConnection conn = new SqlConnection(Connection.ConnectionString);
        //    da = new SqlDataAdapter("SELECT ShipperID, CompanyName, Phone FROM Shippers", conn);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    dgvPrevoznici.DataSource = dt;
        //    dgvPrevoznici.Columns["ShipperID"].HeaderText = "ID Prevoznika";
        //    dgvPrevoznici.Columns["CompanyName"].HeaderText = "Naziv Kompanije";
        //    dgvPrevoznici.Columns["Phone"].HeaderText = "Telefon";
        //    dgvPrevoznici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvPrevoznici.AllowUserToAddRows = true;
        //    dgvPrevoznici.AllowUserToDeleteRows = true;
        //    dgvPrevoznici.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        //}

        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    lvProizvodi.View = View.Details;
        //    lvProizvodi.GridLines = true;
        //    lvProizvodi.FullRowSelect = true;
        //    lvProizvodi.Columns.Add("ID", 20);
        //    lvProizvodi.Columns.Add("Naziv Proizvoda", 180);
        //    lvProizvodi.Columns.Add("Kolicina po jedinici", 120);
        //    lvProizvodi.Columns.Add("Cena", 80);
        //    lvProizvodi.Columns.Add("Na stanju", 80);
        //    lvProizvodi.Columns.Add("Poruceno", 80);
        //    try
        //    {
        //        List<Prevoznik> proizvodi = Prevoznik.UcitajSve();    
        //        if (proizvodi != null && proizvodi.Count > 0)
        //        {
        //            foreach (Prevoznik p in proizvodi)
        //            {
        //                ListViewItem item = new ListViewItem(p.ShipperID.ToString());
        //                // Čuvamo ID u Tag svojstvu za kasnije korišćenje
        //                item.SubItems.Add(p.CompanyName);
        //                item.SubItems.Add(p.Phone);    

        //                item.Tag = p.ShipperID; 
        //                item.Tag = p.CompanyName;
        //                item.Tag = p.Phone;
        //                //item.SubItems.Add(p.City);
        //                lvProizvodi.Items.Add(item);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(
        //                "Nema dostupnih proizvoda za prikaz.",
        //                "Informacija",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Information
        //            );
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            $"Greška prilikom učitavanja proizvoda: {ex.Message}",
        //            "Greška",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //        );
        //    }
        //}

        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    //try
        //    //{
        //    //    List<Prevoznik> prevoznici = Prevoznik.UcitajSve();
        //    //    chart1.Series.Clear();
        //    //    chart1.Titles.Clear();
        //    //    chart1.Titles.Add("Broj prevoznika po gradovima");
        //    //    Series brojPrevoznika = chart1.Series.Add("ID prevoznika");
        //    //    brojPrevoznika.ChartType = SeriesChartType.Column;
        //    //    chart1.DataSource = prevoznici;
        //    //    brojPrevoznika.XValueMember = "CompanyName";
        //    //    brojPrevoznika.YValueMembers = "ShipperID"; // Koristimo ShipperID kao vrednost, ali može biti i broj prevoznika po gradovima ako postoji takva informacija
        //    //    chart1.ChartAreas[0].AxisX.Interval = 1; // Prikaz svakog prevoznika na X osi
        //    //    chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotacija labela za bolju čitljivost
        //    //    brojPrevoznika.IsValueShownAsLabel = true; // Prikaz vrednosti na vrhu kolona
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(
        //    //        $"Greška prilikom pokretanja aplikacije: {ex.Message}",
        //    //        "Greška",
        //    //        MessageBoxButtons.OK,
        //    //        MessageBoxIcon.Error
        //    //    );
        //    //}
        //    List<Prevoznik> prevoznici = Prevoznik.UcitajSve(); 
        //    comboBox1.DataSource = prevoznici;
        //}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            treeView1.Nodes.Clear();
            try
            {
                List<Proizvod> proizvodi = Proizvod.UcitajSve();
                // Grupisanje proizvoda po kategoriji
                var grupisaniProizvodi = proizvodi.GroupBy(p => p.CategoryName);
                foreach (var grupa in grupisaniProizvodi)
                {
                    TreeNode kategorijaNode = new TreeNode(grupa.Key); // Kategorija kao čvor
                    foreach (Proizvod p in grupa)
                    {
                        TreeNode proizvodNode = new TreeNode(p.ProductName); // Proizvod kao podčvor
                        proizvodNode.Tag = p; // Čuvamo ceo objekat proizvoda u Tag svojstvu za kasnije korišćenje
                        kategorijaNode.Nodes.Add(proizvodNode);
                    }
                    treeView1.Nodes.Add(kategorijaNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom učitavanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UcitajPrevoznike()
        {
            try
            {
                List<Prevoznik> prevoznici = Prevoznik.UcitajSve();
                cmbPrevoznici.DisplayMember = "CompanyName";
                cmbPrevoznici.ValueMember = "ShipperID";
                cmbPrevoznici.DataSource = prevoznici;
                cmbPrevoznici.SelectedIndex = -1; // Nema odabranog elementa
                txtNazivKompanije.Clear();
                txtTelefon.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Greška prilikom učitavanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Neočekivana greška: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cmbPrevoznici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrevoznici.SelectedItem is Prevoznik odabraniPrevoznik)
            {
                txtNazivKompanije.Text = odabraniPrevoznik.CompanyName;
                txtTelefon.Text = odabraniPrevoznik.Phone;
            }
            else
            {
                txtNazivKompanije.Clear();
                txtTelefon.Clear();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cmbPrevoznici.SelectedItem == null)
            {
                MessageBox.Show(
                    "Molimo odaberite prevoznika za izmenu.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNazivKompanije.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show(
                    "Naziv kompanije i telefon ne mogu biti prazni.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                int id = (int)cmbPrevoznici.SelectedValue;
                string companyName = txtNazivKompanije.Text.Trim();
                string phone = txtTelefon.Text.Trim();
                bool success = Prevoznik.Azuriraj(id, companyName, phone);
                if (success)
                {
                    MessageBox.Show(
                        "Podaci su uspešno ažurirani.",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    UcitajPrevoznike(); // Osvežavanje podataka u ComboBox-u
                }
                else
                {
                    MessageBox.Show(
                        "Nije moguće ažurirati podatke. Proverite unos i pokušajte ponovo.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    UcitajPrevoznike(); // Osvežavanje podataka u ComboBox-u
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom ažuriranja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (cmbPrevoznici.SelectedItem == null)
            {
                MessageBox.Show(
                    "Molimo odaberite prevoznika za brisanje.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Da li ste sigurni da želite obrisati prevoznika: {cmbPrevoznici.Text} ?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result != DialogResult.Yes) return;
            try
            {
                int id = (int)cmbPrevoznici.SelectedValue;
                bool success = Prevoznik.Obrisi(id);
                if (success)
                {
                    MessageBox.Show(
                        "Prevoznik je uspešno obrisan.",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    UcitajPrevoznike(); // Osvežavanje podataka u ComboBox-u
                }
                else
                {
                    MessageBox.Show(
                        "Nije moguće obrisati prevoznika. Proverite unos i pokušajte ponovo.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    UcitajPrevoznike(); // Osvežavanje podataka u ComboBox-u
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom brisanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivKompanije.Text) || string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show(
                    "Unesite adekvatne podatke i slozite se sa uslovima koriscenja aplikacije kako bi upisali podatke",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                string naziv = txtNazivKompanije.Text;
                string brojTelefona = txtTelefon.Text;
                int noviId = Prevoznik.Dodaj(naziv, brojTelefona);
                if (noviId > 0)
                {
                    MessageBox.Show(
                        $"Podaci su uspešno upisani. Novi ID prevoznika je: {noviId}",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    txtNazivKompanije.Clear();
                    txtTelefon.Clear();
                    txtNazivKompanije.Focus();
                    UcitajPrevoznike(); // Osvežavanje podataka u ComboBox-u
                }
                else
                {
                    MessageBox.Show(
                        "Došlo je do greške prilikom upisa podataka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Greška u konekciji baze",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(dt);
                MessageBox.Show(
                    "Podaci su uspešno sačuvani u bazu.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom čuvanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lvProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProizvodi.SelectedItems.Count > 0)
            {
                shipperIDTxt.ReadOnly = true; // ID ne može biti izmenjen
                ListViewItem selectedItem = lvProizvodi.SelectedItems[0];
                shipperIDTxt.Text = selectedItem.SubItems[0].Text; // ID
                CompanyNameTxt.Text = selectedItem.SubItems[1].Text; // Naziv Proizvoda
                PhoneTxt.Text = selectedItem.SubItems[2].Text; // Kolicina po jedinici
            }
            else
            {
                shipperIDTxt.Clear();
                CompanyNameTxt.Clear();
                PhoneTxt.Clear();
            }
        }

        private void btnIzmeniLV_Click(object sender, EventArgs e)
        {
            if (lvProizvodi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo odaberite proizvod za izmenu.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                ListViewItem selectedItem = lvProizvodi.SelectedItems[0];
                selectedItem.SubItems[1].Text = CompanyNameTxt.Text; // Naziv Proizvoda
                selectedItem.SubItems[2].Text = PhoneTxt.Text; // Kolicina po jedinici
                MessageBox.Show(
                    "Podaci su uspešno izmenjeni.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom izmene podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDodajLV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CompanyNameTxt.Text) || string.IsNullOrEmpty(PhoneTxt.Text))
            {
                MessageBox.Show(
                    "Unesite adekvatne podatke kako bi dodali proizvod",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                ListViewItem newItem = new ListViewItem(shipperIDTxt.Text);
                newItem.SubItems.Add(CompanyNameTxt.Text);
                newItem.SubItems.Add(PhoneTxt.Text);
                newItem.Tag = shipperIDTxt.Text; // Čuvamo ID u Tag svojstvu
                lvProizvodi.Items.Add(newItem);
                MessageBox.Show(
                    "Podaci su uspešno dodati.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom dodavanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnObrisiLV_Click(object sender, EventArgs e)
        {
            if (lvProizvodi.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo odaberite proizvod za brisanje.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                ListViewItem selectedItem = lvProizvodi.SelectedItems[0];
                lvProizvodi.Items.Remove(selectedItem);
                MessageBox.Show(
                    "Podaci su uspešno obrisani.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška prilikom brisanja podataka: {ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Prevoznik izabranPrevoznik)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add($"Broj prevoznika po gradovima - {izabranPrevoznik.CompanyName}");
                Series brojPrevoznika = chart1.Series.Add("ID prevoznika");
                brojPrevoznika.ChartType = SeriesChartType.Pie;
                brojPrevoznika.Points.AddXY(izabranPrevoznik.CompanyName, izabranPrevoznik.ShipperID); // Koristimo ShipperID kao vrednost, ali može biti i broj prevoznika po gradovima ako postoji takva informacija
                brojPrevoznika.Points.AddXY("Ostali prevoznici", 0); // Dodajemo "Ostali prevoznici" sa vrednošću 0 za vizuelnu ravnotežu
                brojPrevoznika.IsValueShownAsLabel = true; // Prikaz vrednosti na grafiku
                chart1.Legends[0].Enabled = true; // Prikaz legende
            }
            else
            {
                MessageBox.Show(
                    "Molimo odaberite prevoznika za prikaz grafikona.",
                    "Upozorenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Proizvod odabraniProizvod)
            {
                MessageBox.Show(
                    $"Detalji proizvoda:\n\nNaziv: {odabraniProizvod.ProductName}\nKategorija: {odabraniProizvod.CategoryName}\nCena: {odabraniProizvod.UnitPrice:C}\nNa stanju: {odabraniProizvod.UnitsInStock}",
                    "Detalji proizvoda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void prikaziBtn_Click(object sender, EventArgs e)
        {


        }
    }
}