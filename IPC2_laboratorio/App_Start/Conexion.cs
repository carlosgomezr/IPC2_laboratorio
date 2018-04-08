using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace IPC2_laboratorio.App_Start
{
    public class Conexion
    {
        String db_name = "server=DESKTOP-1SSDJ8V ; database=IPC2_laboratorio ; integrated security = true";//Conexion a la base de datos
           
        SqlConnection conn;

        //constructor por defecto
        public Conexion() {
        }

        public String abrirConexion() {
            try{
                conn = new SqlConnection(db_name);
                conn.Open();
                MessageBox.Show("Se ha abierto la conexión a la db");
                return "Se ha abierto la conexión a la db";

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir conexión ", "IPC 2");
                return "Error al abrir conexión " + e.ToString();
            }
        }

        public String cerrarConexion() {
            try {
                conn.Close();
                MessageBox.Show("Se ha cerrado la conexión a la db.", "IPC 2");
                return "Se ha cerrado la conexión a la db.";
            }
            catch (Exception e) {
                MessageBox.Show("Error al cerrar conexión ", "IPC 2");
                return "Error al cerrar conexión " + e.ToString();
            }
        }

        public String insertarUsuario(String nombre, String edad) {
            try {
                if (nombre.Length > 3 && Int32.Parse(edad.ToString()) > 0)
                { //el nombre debe tener mas de 3 caracteres y la edad debe ser mayor a 0

                    abrirConexion(); //se abrio la conexión a la base de datos
                    SqlCommand query = new SqlCommand("insert into Usuario values('" + nombre + "'," + edad + ");", conn); //realizo la consulta que deseo ejecutar
                    query.ExecuteNonQuery(); //ejecuto la consulta
                    MessageBox.Show("Usuario ingresado", "IPC 2"); //mensaje para mostrar se inserto el usuario correctamente
                    cerrarConexion();//se cierra la conexión a la base de datos
                    return "Usuario ingresado";
                }
                else
                {
                    MessageBox.Show("Usuario y/0 edad inválida", "IPC 2"); //mensaje de Error al ingresar datos en la pagina
                    return "Usuario No ingresado";
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error al ingresar Usuario ", "IPC 2");
                return "Error al ingresar Usuario "+e.ToString();
            }
        }

        public String selectUsuario() {
            try {
                abrirConexion();
                String info = "<table><tr>  <td> USUARIO </td><td> EDAD </td> </tr>";
                SqlCommand query = new SqlCommand("SELECT * FROM Usuario", conn);
                SqlDataReader reader;
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    info += "<tr>  <td> " + reader["nombre"].ToString() + "</td><td>" + reader["edad"].ToString() + "</td> </tr>";
                }
                info += "</table>";
                cerrarConexion();
                return info;
            }
            catch (Exception e) {
                MessageBox.Show("Error al mostrar usuarios", "IPC 2");
                return "Error al mostrar usuarios";
            }


        }
    }
}