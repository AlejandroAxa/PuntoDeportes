using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Proyecto.Modelo;
using System.Configuration;
using System.Data.SQLite;
namespace Proyecto.Logica
{
    public class ProductoLogica
    {
        //necesitamos agregar un referencia de servicio "System.Configuration"
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        //Singleton : es un patrón de diseño que permite nos permite hacer una instancia unica, restringir crear objetos
        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }

        public static ProductoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ProductoLogica();

                return _instancia;
            }
        }

        //IMPORTAR System.Data.SQLite
        public bool Guardar(Producto objeto)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "insert into producto(nombreProducto,precio,categoria) values (@nombreProducto,@precio,@categoria)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombreProducto", objeto.nombreProducto));
                cmd.Parameters.Add(new SQLiteParameter("@precio", objeto.precio));
                cmd.Parameters.Add(new SQLiteParameter("@categoria", objeto.categoria));
                cmd.CommandType = System.Data.CommandType.Text;

                //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;
        }

        public List<Producto> Listar()
        {
            List<Producto> oLista = new List<Producto>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "select IdProducto,nombreProducto,precio,categoria from producto";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Producto()
                        {
                            IdProducto = int.Parse(dr["IdProducto"].ToString()),
                            nombreProducto = dr["nombreProducto"].ToString(),
                            precio = dr["precio"].ToString(),
                            categoria = dr["categoria"].ToString()
                        });
                    }
                }
            }

            return oLista;
        }

        public bool Editar(Producto objeto)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "update producto set nombreProducto = @nombreProducto , precio = @precio, categoria = @categoria where idProducto = @idProducto";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idProducto", objeto.IdProducto));
                cmd.Parameters.Add(new SQLiteParameter("@nombreProducto", objeto.nombreProducto));
                cmd.Parameters.Add(new SQLiteParameter("@precio", objeto.precio));
                cmd.Parameters.Add(new SQLiteParameter("@categoria", objeto.categoria));
                cmd.CommandType = System.Data.CommandType.Text;

                //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;
        }

        public bool Eliminar(Producto objeto)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "delete from producto where idProducto = @idProducto";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idProducto", objeto.IdProducto));
                cmd.CommandType = System.Data.CommandType.Text;


                //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;
        }

    }
}
