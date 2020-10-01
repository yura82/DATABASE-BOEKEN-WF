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
    public partial class NewAutGenUIt : Form
    {
        public NewAutGenUIt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewAutGenUIt_Load(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // staap 7
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                cxt.Auteurs.Add(new Auteur()
                {
                    Voornaam = txtVoornaam.Text,
                    Achternaam = txtAchternaam.Text,


                });

                cxt.SaveChanges();
                MessageBox.Show("You add new auteur : " + txtVoornaam.Text + " " + txtAchternaam.Text);
            }
           
            
        }

        private void btNewGenre_Click(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                cxt.Genres.Add(new Genre()
                {
                    Genre1 = txtGenre.Text
                });
                cxt.SaveChanges();
                MessageBox.Show("You add new genre : " + txtGenre.Text);
            }

        }

        private void btNewUItgev_Click(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                cxt.Uitgeverijens.Add(new Uitgeverijen()
                {
                    Naam = txtUitgeverijn.Text
                });
                cxt.SaveChanges();
                MessageBox.Show("You added new uitgeverijn: " + txtUitgeverijn.Text);
            }

        }
    }
}
