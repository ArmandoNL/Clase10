using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n_Capas
{
    public partial class Persona : System.Web.UI.Page
    {
        ControladoraPersona controladora = new ControladoraPersona();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarPersona(object sender, EventArgs e)
        {
            Object[] objeto = new Object[4];
            objeto[0] = TextBox1.Text;
            objeto[1] = TextBox2.Text;
            objeto[2] = TextBox3.Text;
            objeto[3] = TextBox4.Text;

            controladora.agregarPersona(objeto);

        }
    }
}