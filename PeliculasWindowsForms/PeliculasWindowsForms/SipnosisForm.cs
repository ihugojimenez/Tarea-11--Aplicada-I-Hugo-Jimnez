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
    public partial class SipnosisForm : Form
    {
        public SipnosisForm()
        {
            InitializeComponent();
        }

        private PeliculasEntities db = new PeliculasEntities();


        private void Mostrar(int n)
        {
            

            PeliculasDetalle pd = (from p in db.PeliculasDetalles
                                   where p.IdPelicula == n
                                   select p).FirstOrDefault();

            string aux = pd.Titulo + ":  " + pd.Sipnosis;
            SalidaTextBox.Text = aux;
            
        }

        private void MostrarEdit()
        {
            SipnosisListView.Items.Clear();

            var query = from p in db.PeliculasDetalles
                        select p;

            foreach (var item in query)
            {
                ListViewItem ilst = SipnosisListView.Items.Add(item.IdPelicula.ToString());
                ilst.SubItems.Add(item.Titulo);            }
        }

        private void SipnosisForm_Load(object sender, EventArgs e)
        {
            MostrarEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdSearchTextBox.Text))
            {
                NullTextIdErrorProvider.SetError(IdSearchTextBox, "No puede estar vacio");
            }
            else
            {
                NullTextIdErrorProvider.Clear();
                Mostrar(Convert.ToInt32(IdSearchTextBox.Text));
            }
                
       
            
        }

        private void IdSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
