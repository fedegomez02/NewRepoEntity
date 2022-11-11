﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormspPub.Models;

namespace WindowsFormspPub.AdminDatos
{
    public static  class DacAuthor
    {

        public static Model1 context = new Model1();
        public static List<Author> Lista()
        {
            List<Author> lista = new List<Author>() { };
            lista = context.Authors.ToList();
            return lista;

        }

        public static Author TraerUno(string id)
        {


            Author author = new Author();
            author = context.Authors.Find(id);
            return author;
        }


        public static int Nuevo(Author author)
        {
            context.Authors.Add(author);
            int filasafectadas = context.SaveChanges();

            return filasafectadas;

        }

        public static int Modificar(Author author)
        {
            string idabuscar = author.au_id;
            Author authorabuscar = context.Authors.Find(idabuscar);

            if (authorabuscar != null)
            {

                authorabuscar = author;


            }


            int filasafectadas = context.SaveChanges();


            return filasafectadas;



        }

        public static int Eliminar(Author author)
        {

            string idabuscar = author.au_id;
            Author authorabuscar = context.Authors.Find(idabuscar);

            if (authorabuscar != null)
            {

                context.Authors.Remove(authorabuscar);


            }
            int filasafectadas = context.SaveChanges();
            return filasafectadas;

        }
    }
}
