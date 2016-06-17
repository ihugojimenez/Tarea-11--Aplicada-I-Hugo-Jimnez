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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void pEliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            RegistroCatForm Rc = new RegistroCatForm();
            //Rc.MdiParent = this;
            Rc.Show();
            
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroPeliculasForm RP = new RegistroPeliculasForm();
            //RP.MdiParent = this;
            RP.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMoviesForm SM = new ShowMoviesForm();
            SM.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
