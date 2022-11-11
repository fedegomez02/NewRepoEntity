using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormspPub.Models;

namespace WindowsFormspPub
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Publishers publisher = new Publishers() {pub_id="2089", pub_name = "antares",city = "Mar del plata",state = "BA", country = "Argentina"};
            model.Publishers.Add(publisher);

            int filasAfectadas = model.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string id = "1389";
            Publishers publishersDb = model.Publishers.Find(id);

            if (publishersDb != null)
            {
                publishersDb.pub_name = "Barley";
                publishersDb.state = "LE";

            }

            int filasAfectadas = model.SaveChanges();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            //Buscar el objeto en la DB

            var shipperDb = model.Publishers.Find(id);

            if (shipperDb != null)
            {
                // remover
                model.Publishers.Remove(shipperDb);
                //guardar cambio en la DB
                //Guadar en la DB
                int filasAfectadas = model.SaveChanges();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Eliminar OK");
                }

            }

        }

        private void MostrarLista_Click(object sender, EventArgs e)
        {
            List<Publishers> lista = model.Publishers.ToList();

            dataGridView1.DataSource = lista;

        }
    }
}
