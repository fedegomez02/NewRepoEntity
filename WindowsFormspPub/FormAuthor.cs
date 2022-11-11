using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormspPub.AdminDatos;
using WindowsFormspPub.Models;

namespace WindowsFormspPub
{
    public partial class FormAuthor : Form
    {
        Author Author = new Author() { address ="Juana manso", au_fname="22", au_id ="22", au_lname="carls", city="new york"};
        public FormAuthor()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
             Author author = new Author();
            DacAuthor.Nuevo(author);
            Application.Exit();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Author.address = txtAdress.Text;
           Author.au_fname = txtauFname.Text;   
            Author.au_id = txtAuid.Text;
            Author.au_lname = txtAulname.Text;
            Author.city = txtCity.Text;

            DacAuthor.Modificar(Author);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DacAuthor.Eliminar(Author);
        }
    }
}
