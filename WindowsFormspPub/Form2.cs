using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormspPub.AdminDatos;
using WindowsFormspPub.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsFormspPub
{
    public partial class Form2 : Form
    {
        public Store store1 = new Store()
        {
            stor_id = "2229",
            stor_name = "open sports",
            stor_address = "838 juana manso",
            city = "mar del plata",
            state = "BA",
            zip = "22222"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            DacStore.Nuevo(store1);

            Application.Exit();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Store store = DacStore.TraerUno(id);
            store.stor_id = txtStoreId.Text;
            store.stor_name = txtStoreName.Text;
            store.stor_address = txtStoreAddress.Text;
            store.city = txtCity.Text;
            store.state = txtState.Text;
            store.zip = txtZip.Text;

            DacStore.Modificar(store);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Store store = new Store();
            store.stor_id = id;
            DacStore.Eliminar(store);

            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DacStore.Lista();
        }
    }
}
