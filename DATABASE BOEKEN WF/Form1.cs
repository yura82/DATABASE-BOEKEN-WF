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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                var infoboek = cxt.Boekens.Select(b => b).ToList();
                lbBoeken.DisplayMember = "Tittel";
                lbBoeken.ValueMember = "Id";
                lbBoeken.DataSource = infoboek;


            }

        }

        private void lbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataBase_BoekenEntities cxt = new DataBase_BoekenEntities())
            {
                // staap 1
                var joinQuery = cxt.Boekens
                    .Join(cxt.Uitgeverijens,
                    bk => bk.UitgeverId,
                    u => u.Id,
                    (bk, u) => new { bk, u });
                //staap 2
                var joinquery2 = cxt.BoekenGenres
                    .Join(cxt.Genres,
                    bg => bg.BoekId,
                    g => g.Id,
                    (bg, b) => new { bg, b })
                    .Join(cxt.Genres,
                    g2 => g2.bg.GenreId,
                    b => b.Id,
                    (g2,b) => new { g2,b});
                //staap 3,4,5
                var joinquery3 = cxt.BoekenAuteurs
                    .Join(cxt.Auteurs,
                    ba => ba.AuteurId,
                    a => a.Id,
                    (ba, a) => new { ba, a })
                    .Join(cxt.Auteurs,
                    a2 => a2.ba.AuteurId,
                    c => c.Id,
                    (a2, c) => new { a2, c });

                    var selectmyBoek = lbBoeken.SelectedItem as Boeken;
                lbMyBook.Text = "AantalPaginas : " + selectmyBoek.AantalPaginas.ToString() + "\n" +
                    "Score" + selectmyBoek.Score.ToString() + "\n" +
                    "Publicatie :" + selectmyBoek.Publicatie +
                    "Uitgevers :" + joinQuery.Where(x => x.bk.Id == selectmyBoek.Id).FirstOrDefault().u.Naam + "\n" +
                    "Ganres : " + joinquery2.Where(y => y.b.Id == selectmyBoek.Id).FirstOrDefault().g2.b.Genre1 + "\n" +
                    "Auteurs : " + joinquery3.Where(z => z.c.Id == selectmyBoek.Id).FirstOrDefault().a2.a.Achternaam + " " +
                    joinquery3.Where(z => z.c.Id == selectmyBoek.Id).FirstOrDefault().a2.a.Voornaam;
                         
 
                
            }
        }
        addBook AddBook = new addBook();
        private void btAddBoek_Click(object sender, EventArgs e)
        {

            AddBook.Show();
        }
    }
}
