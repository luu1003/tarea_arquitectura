using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_ReparacionFinalizada
    {
        internal delegate void delegado_reparacion(bool final);
        internal event delegado_reparacion evt_reparacion;

        public void Informar_Reparacion_Finalizada(bool final)
        {
            try
            {
                if (evt_reparacion != null)
                {
                    evt_reparacion(final);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error en el evento Informar Reparacion Finalizada" + ex);
                throw;
            }

        }
    }
}
