using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Eventos;

namespace b_taller_automovil.Clases
{

    public class Taller
    {
        private List<Reparacion> l_reparaciones_cientes;

        internal List<Reparacion> L_reparaciones_cientes { get => l_reparaciones_cientes; set => l_reparaciones_cientes = value; }
    }
}
