using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
namespace web_umg_bd
{
    public class ConexionBD
    {
        private string cadena = "server=localhost; database=db_tarea; user=user_tarea2; password=1234";
        public MySqlConnection conectar = new MySqlConnection();
        

        public void AbrirConexion(){
            try {
                conectar.ConnectionString = cadena;
                conectar.Open();
               
            } 
            catch(Exception ex){
                System.Diagnostics.Debug.WriteLine(ex.Message);
                
            }

        }
        public void CerarConexion(){
            
                if (conectar.State == ConnectionState.Open)
                {
                conectar.Close();           
                }
        }
    }
}