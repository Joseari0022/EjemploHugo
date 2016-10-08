using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class UsuariosBLL
    {
        Usuarios usuario = new Usuarios();

        public static void Insetar(Usuarios u)
        {

            try
            {
                using (var db = new SistemasVentasDb())
                {
                    db.Usuarios.Add(u);
                    db.SaveChanges();
                    db.Dispose();
                }
            }catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
