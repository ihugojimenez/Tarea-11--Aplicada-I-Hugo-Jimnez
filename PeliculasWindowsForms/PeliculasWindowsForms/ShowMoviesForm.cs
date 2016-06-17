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

        private void mostrar()
        {
            PeliculasListView.Clear();

            var query = from p in db.PeliculasDetalles
                        select p;

            foreach (var item in query)
            {
                ListViewItem ilv = PeliculasListView.Items.Add(item.IdPelicula.ToString());
                ilv.SubItems.Add(item.IdCategoria.ToString());
                ilv.SubItems.Add(item.Titulo);
                ilv.SubItems.Add(item.Calificacion);
                ilv.SubItems.Add(item.Ano);
                ilv.SubItems.Add(item.Idioma);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowMoviesForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
