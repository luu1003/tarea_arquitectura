using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Eventos;

namespace b_taller_automovil.Clases
{
    public class Reparacion
    {
        private const float valor = 1200000;

        private readonly Publisher_VehiculoIngresado _publisherIngreso;
        private readonly Publisher_ReparacionFinalizada _publisherReparacion;

        public Carro carro;
        private DateTime fecha;
        private List<Repuesto> l_repuesto;
        private List<Mecanico> l_mecanicos;
        private bool ingreso = false;

        public Reparacion(Carro carro, List<Repuesto> l_repuesto, List<Mecanico> l_mecanicos, Publisher_VehiculoIngresado publisherIngreso, Publisher_ReparacionFinalizada publisherReparacion)
        {
            this.carro = carro;
            this.fecha = DateTime.Now;
            this.L_repuesto = l_repuesto;
            this.L_mecanicos = l_mecanicos;
            _publisherIngreso = publisherIngreso;
            _publisherReparacion = publisherReparacion;

            _publisherIngreso.Informar_Ingreso_Vehiculo(ingreso = true);
        }

        public void Finalizar_Reparacion()
        {
            try
            {
                if (this.carro.Reparacion == true)
                {
                    _publisherReparacion.Informar_Reparacion_Finalizada(true);
                }
                else
                {
                    _publisherReparacion.Informar_Reparacion_Finalizada(false);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error en el metodo Finalizar Reparacion");
            }
        }

        public static float Valor { get => valor;}
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Carro Carro { get => carro; set => carro = value; }
        public List<Repuesto> L_repuesto { get => l_repuesto; set => l_repuesto = value; }
        public List<Mecanico> L_mecanicos { get => l_mecanicos; set => l_mecanicos = value; }
        public string ResultadoPuestaPunto { get; set; }
    }
}
