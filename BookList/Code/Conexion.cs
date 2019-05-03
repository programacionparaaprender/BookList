using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
//using System.Windows.Forms;
using System.Data;
//using System.Xml.Serialization.IXmlSerializable;
using System.Collections;
using System.Diagnostics;
using System.Configuration;
  

namespace BookList.Code
{
     
public class Conexion
    {
        String cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
        //static String cadenaConexion = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString();
        public void eliminar()
        {
            try
            {
                String nombre = "Electronica";
                String telefono = "02812344561";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand consulta = new SqlCommand(@"DELETE Departamento WHERE Nombre=@Nombre AND Telefono=@Telefono", conexion);
                consulta.Parameters.AddWithValue("@Nombre",nombre);
                consulta.Parameters.AddWithValue("@Telefono", telefono);
                consulta.ExecuteNonQuery();
                conexion.Close();
            }
            catch (ArgumentNullException)
            {
            }
        }
        public DataTable MostrarEstructuraAdapter()
        {
            //MostrarEstructuraAdapter = new DataTable();
            //string cadenaConexion = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString;
            String cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
            DataTable dt = new DataTable();
            try
            {
                //SqlConnection conexion = new SqlConnection(cadenaConexion);
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                
                string strCadSQL = "SELECT * FROM dbo.usuarios";
                SqlDataAdapter dataadapter = new SqlDataAdapter(strCadSQL, conexion);
                dataadapter.Fill(dt);
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;//Console.WriteLine(e.ToString());
            }
            return dt;
        }

        private void insertar()
        {
            String nombre = "Electronica";
            String telefono = "02812344561";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                string consulta = @"INSERT INTO Departamento (Nombre,Telefono) Values(@Nombre,@Telefono)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
   
    }
  
  }

  