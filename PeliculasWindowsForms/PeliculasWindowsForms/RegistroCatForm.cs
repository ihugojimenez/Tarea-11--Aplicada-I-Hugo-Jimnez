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
    public partial class RegistroCatForm : Form
    {
        private PeliculasEntities db = new PeliculasEntities();
        public RegistroCatForm()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            PeliculasCatListView.Items.Clear();

            var query = from p in db.Movies
                        select p;

            foreach(var item in query)
            {
                ListViewItem ilv = PeliculasCatListView.Items.Add(item.CategoriaId.ToString());
                ilv.SubItems.Add(item.Descripcion);
            }
        }

        private void Agregar()
        {
            Movy m = new Movy()
            {
                CategoriaId = Convert.ToInt32(IDCatTextBox.Text),
                Descripcion = DesctextBoxT.Text

            };

            db.Movies.Add(m);
            db.SaveChanges();
        }

        private void Actualizar(int n)
        {
            Movy m = (from p in db.Movies
                      where p.CategoriaId == n
                      select p).FirstOrDefault();
            m.Descripcion = DesctextBoxT.Text;
            db.SaveChanges();
        }

        private void Eliminar(int n)
        {
            Movy mov = (from p in db.Movies
                        where p.CategoriaId == n
                        select p).FirstOrDefault();

            db.Movies.Remove(mov);
            db.SaveChanges();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Agregar();

        }

        private void ResgitroCatForm_Load(object sender, EventArgs e)
        {
            Mostrar();

        }
    }
}
