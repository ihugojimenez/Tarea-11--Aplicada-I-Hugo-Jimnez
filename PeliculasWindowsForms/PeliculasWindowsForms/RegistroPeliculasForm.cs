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
    public partial class RegistroPeliculasForm : Form
    {
        public RegistroPeliculasForm()
        {
            InitializeComponent();
        }
        private PeliculasEntities db1 = new PeliculasEntities();
        
        private void AddMovie()
        {
            PeliculasDetalle Pd = new PeliculasDetalle()
            {
                IdPelicula = Convert.ToInt32(IdPeliTextBox.Text),
                IdCategoria = Convert.ToInt32(IdCatTextBox.Text),
                Titulo = TituloTextBox.Text,
                Sipnosis = SipnosisTextBox.Text,
                Calificacion = CalTextBox.Text,
                Ano = AnoTextBox.Text,
                Idioma = IdiomaTextBox.Text

            };
            db1.PeliculasDetalles.Add(Pd);
            db1.SaveChanges();
           
        }

       

        private void Eliminar(int n)
        {
            PeliculasDetalle pd = (from p in db1.PeliculasDetalles
                                   where p.IdPelicula == n
                                   select p).FirstOrDefault();
            db1.PeliculasDetalles.Remove(pd);
            db1.SaveChanges();
           
        }

        

        private void Actualizar(int n)
        {
            PeliculasDetalle pd = (from p in db1.PeliculasDetalles
                                   where p.IdPelicula == n
                                   select p).FirstOrDefault();

            pd.IdPelicula = Convert.ToInt32(IdPeliTextBox.Text);
            pd.IdCategoria = Convert.ToInt32(IdCatTextBox.Text);
            pd.Titulo = TituloTextBox.Text;
            pd.Sipnosis = SipnosisTextBox.Text;
            pd.Calificacion = CalTextBox.Text;
            pd.Ano = AnoTextBox.Text;
            pd.Idioma = IdiomaTextBox.Text;

            db1.PeliculasDetalles.Add(pd);
            db1.SaveChanges();
           
        }

        private void buscar(int n)
        {

        }

        private void RegistroPeliculasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peliculasDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.peliculasDataSet.Movies);
            

        }

        private void CategoriasPeliComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddMovie();

        }
    }
}
