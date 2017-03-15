using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n_Capas
{
    public class EntidadPersona
    {
        String cedula;
        String nombre;
        String apellidos;
        String fecha_nac;

        public EntidadPersona(Object[] objeto)
        {
            this.cedula = objeto[0].ToString();
            this.nombre = objeto[1].ToString();
            this.apellidos = objeto[2].ToString();
            this.fecha_nac = objeto[3].ToString();
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public String Fecha_Nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }
    }
}