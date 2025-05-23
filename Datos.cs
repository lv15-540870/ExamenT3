using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT3
{
    internal class Datos
    {
        String cadenaConexion = "Data Source=HP-INTEL-I7\\SQLEXPRESS; integrated security=true; initial catalog=InventarioDB; encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); //Abrir Coneixon a BD
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet consulta(string cons)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cons, abrirConexion());
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool comando(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
    
