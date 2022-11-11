using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormspPub.Models;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormspPub.AdminDatos
{
    public static class DacStore
    {
       static  Model1 model = new Model1();

        public static List<Store> Lista()
        {

            List<Store> lista = model.Stores.ToList();
            return lista;
        }

        public static Store TraerUno(string id)
        {

            Store store1 = model.Stores.Find(id);
            return store1;

        }
        public static int Nuevo(Store store)
        {

            Model1 model = new Model1();
            model.Stores.Add(store);

            int filasAfectadas = model.SaveChanges();
            MessageBox.Show("registro insertado ");
            return filasAfectadas;

           
        }
        public static int Modificar(Store store)
        {
            Store store1 = model.Stores.Find(store.stor_id);

            if(store != null)
            {
                store1 = store;
            }


            int filasAfectadas = model.SaveChanges();

            return filasAfectadas;

        }
        public static int Eliminar(Store store)
        {
            string idabuscar = store.stor_id;
            Store storeabuscar = model.Stores.Find(idabuscar);

            if (storeabuscar != null)
            {

                model.Stores.Remove(storeabuscar);

                MessageBox.Show("El registro ha sido robado");

            }
            int filasafectadas = model.SaveChanges();

            return filasafectadas;

        }



    }
}
