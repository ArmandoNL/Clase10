using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n_Capas
{
    public class ControladoraBDPersona
    {
        Adaptador adaptador = new Adaptador();
        internal void agregarPersona(EntidadPersona persona)
        {
            String consulta = "select * from Persona";
            adaptador.consultar(consulta);
        }
    }
}