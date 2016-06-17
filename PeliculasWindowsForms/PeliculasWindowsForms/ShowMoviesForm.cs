using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasWindowsForms
{
    public partial class ShowMoviesForm : Form
    {
        public ShowMoviesForm()
        {
            InitializeComponent();
        }

        private PeliculasEntities db = new PeliculasEntities();

        private void Mostrar()
        {
            SalidalistView.Items.Clear();

            var query = from p in db.PeliculasDetalles
                        select p;

            foreach (var item in query)
            {
                ListViewItem ilst = SalidalistView.Items.Add(item.IdPelicula.ToString());
                ilst.SubItems.Add(item.IdCategoria.ToString());
                ilst.SubItems.Add(item.Titulo);
                ilst.SubItems.Add(item.Calificacion);
                ilst.SubItems.Add(item.Ano);
                ilst.SubItems.Add(item.Idioma);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowMoviesForm_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void SipnosisButton_Click(object sender, EventArgs e)
        {
            SipnosisForm Sf = new SipnosisForm();
            Sf.Show();
        }
    }
}
