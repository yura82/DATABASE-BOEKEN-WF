using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_BOEKEN_WF
{
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                var auterL = cxt.Auteurs.Select(aut => aut).ToList();
                cbAuteur.DisplayMember = "Voornaam";
                cbAuteur.ValueMember = "Id";
                cbAuteur.DataSource = auterL;
                var genreL = cxt.Genres.Select(gen => gen).ToList();
                cbGanre.DisplayMember = "Genre1";
                cbGanre.ValueMember = "Id";
                cbGanre.DataSource = genreL;
                var uitgevL = cxt.Uitgeverijens.Select(uit => uit).ToList();
                cbUitgeverij.DisplayMember = "Naam";
                cbUitgeverij.ValueMember = "Id";
                cbUitgeverij.DataSource = uitgevL;

            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                cxt.Boekens.Add(new Boeken()
                {
                    Tittel = txtTittel.Text,
                    AantalPaginas = Convert.ToInt32(numPages.Value),
                    Score = Convert.ToInt32(numScores.Value),
                    Publicatie = datePublish.Value,
                    UitgeverId = Convert.ToInt32(cbUitgeverij.SelectedValue)
                   
                }) ;
                MessageBox.Show("You have a new book in data base " + txtTittel.Text );
                cxt.SaveChanges();
                    
            }
        }
    }
}
