using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n_Capas
{
    public class ControladoraPersona
    {
        ControladoraBDPersona controladoraBD = new ControladoraBDPersona();
        internal void agregarPersona(object[] objeto)
        {
            EntidadPersona persona = new EntidadPersona(objeto);

            controladoraBD.agregarPersona(persona);
        }
    }
}