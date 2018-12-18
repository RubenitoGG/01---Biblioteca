using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BibliotecaSQL
{
    public class ADAT
    {
        public static BibliotecaDataSet ds = new BibliotecaDataSet();
        public static int registrosAtualizados;
        // string cogemos conexion
        string strConection = Properties.Settings.Default.BibliotecaConnectionString.ToString();
        public static BibliotecaDataSet.LibroRow libroRow;
        public static BibliotecaDataSet.EjemplarRow ejemplarRow;

        public void BuscarLibro(string campo, string valor)
        {

            ds.Libro.Clear();
            try
            {
                // Establecemos la conexion 
                SqlConnection connection = new SqlConnection(strConection);
                // Creamos el constructor para insertar
                StringBuilder strQuery = new StringBuilder();
                strQuery.AppendFormat("Select * from Libro Where {0} = '{1}'", campo, valor);
                SqlDataAdapter adapter = new SqlDataAdapter(strQuery.ToString(), connection);
                adapter.Fill(ds.Libro);

                if (ds.Libro.Count == 1)

                    libroRow = ds.Libro[0];
                else
                {
                    if (ds.Libro.Count == 0)
                    {

                        libroRow = null;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Se ha producido un error"); libroRow = null; }
        }

        public void BuscarEjemplar(int codigo)
        {
            ds.Ejemplar.Clear();
            try
            {
                // Establecemos la conexion 
                SqlConnection connection = new SqlConnection(strConection);
                // Creamos el constructor para insertar
                StringBuilder strQuery = new StringBuilder();
                strQuery.AppendFormat("Select * from Ejemplar Where CodigoLibro = '{0}'", codigo);
                SqlDataAdapter adapter = new SqlDataAdapter(strQuery.ToString(), connection);
                adapter.Fill(ds.Ejemplar);


            }
            catch (Exception ex) { MessageBox.Show("Se ha producido un error" + ex.Message); }
        }

        public void InsertarLibro(string codigo, string isbn, string titulo, string editorial, string descripcion)
        {
            //BuscarLibro("Isbn", isbn);
     
            try
            {
                if (libroRow == null)
                {
                    // Establecemos la conexion 
                    SqlConnection connection = new SqlConnection(strConection);
                    connection.Open();
                    // Creamos el constructor para insertar y la query
                    //StringBuilder strInsert = new StringBuilder();
                    //strInsert.AppendFormat("Insert Libro values('{0}','{1}','{2}','{3}',{4})",codigo, isbn, titulo, editorial, descripcion);
                    //SqlCommand comando = new SqlCommand(strInsert.ToString(), connection);
                    //registrosAtualizados = comando.ExecuteNonQuery();
                    connection.Close();
                    Debug.WriteLine("funciona");
                }
                else { MessageBox.Show("El libro ya existe"); }
            }
            catch (Exception) { MessageBox.Show("Ha ocurrido un error"); }

        }

        public void InsertarEjemplar(string isbn, DateTime fechaPublicacion, int numEjem)
        {
            BuscarLibro("Isbn", isbn);
            //BuscarEjemplar(libroRow.CodigoLibro);

            try
            {
                if (libroRow != null)
                {
                    // Establecemos la conexion 
                    SqlConnection connection = new SqlConnection(strConection);
                    connection.Open();
                    // Creamos el constructor para insertar y la query
                    StringBuilder strInsert = new StringBuilder();
                    strInsert.AppendFormat("Insert Ejemplar values('{0}','{1}','{2}','{3}')", libroRow.CodigoLibro, numEjem, fechaPublicacion, "D");
                    SqlCommand comando = new SqlCommand(strInsert.ToString(), connection);
                    registrosAtualizados = comando.ExecuteNonQuery();
                    connection.Close();
                }
                else { MessageBox.Show("El ejemplar ya se encuantra con ese numero, pruebe con otro"); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error" + ex.Message); }
        }

        public void EliminarLibro(string isbn)
        {
            try
            {
                if (libroRow != null)
                {   // Establecemos la conexion 
                    SqlConnection connection = new SqlConnection(strConection);
                    connection.Open();
                    // Creamos el constructor para insertar y la query
                    StringBuilder strDelete = new StringBuilder();
                    strDelete.AppendFormat("Delete From Ejemplar Where CodigoLibro= '{0}';", libroRow.CodigoLibro);
                    strDelete.AppendFormat("Delete From libro Where CodigoLibro= '{0}'", libroRow.CodigoLibro);
                    SqlCommand comando = new SqlCommand(strDelete.ToString(), connection);
                    registrosAtualizados = comando.ExecuteNonQuery();
                    connection.Close();
                    if (registrosAtualizados > 0)
                        libroRow = null;
                    MessageBox.Show("Libro eliminado");
                }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error" + ex.Message); }
        }

        public void ModificarLibro(string isbn, string titulo, string editorial, string descripcion)
        {
            try
            {
                if (libroRow != null)
                {
                    // Establecemos la conexion 
                    SqlConnection connection = new SqlConnection(strConection);
                    connection.Open();
                    // Creamos el constructor para insertar y la query
                    StringBuilder strInsert = new StringBuilder();
                    strInsert.AppendFormat("Update Libro set isbn='{0}',Titulo='{1}',Editorial='{2}',Descripcion='{3}' Where CodigoLibro={4}", isbn, titulo, editorial, descripcion, libroRow.CodigoLibro);
                    SqlCommand comando = new SqlCommand(strInsert.ToString(), connection);
                    registrosAtualizados = comando.ExecuteNonQuery();
                    connection.Close();
                }
                else { MessageBox.Show("No Existe el libro "); }
            }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error" + ex.Message); }
        }
    }


}
