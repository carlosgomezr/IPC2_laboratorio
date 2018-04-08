using IPC2_laboratorio.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPC2_laboratorio
{
    public partial class _Default : Page
    {
        Conexion conn = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.insertarUsuario(TextBox1.Text, TextBox2.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = conn.selectUsuario();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.abrirConexion();
            conn.cerrarConexion();
        }
    }
}