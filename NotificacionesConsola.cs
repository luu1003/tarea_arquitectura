using System;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Subscriptores
{
    public class NotificacionesConsola
    {
        public void OnCreditoActualizado()
        {
            Console.WriteLine("El credito fue procesado con exito, Revise su nuevo valor de credito");
        }

        public void OnFacturaCanceladaSalida(float pago)
        {
            if (pago == Reparacion.Valor)
            {
                Console.WriteLine("El pago fue procesado con exito, puede pasar a retirar su vehiculo");
            }
            else
            {
                Console.WriteLine("El pago no fue procesado, revise que la cantidad es el costo de la reparacion o intente de nuevo");
            }
        }

        public void OnReparacionFinalizada(bool final)
        {
            if (final == true)
            {
                Console.WriteLine("La reparacion del auto se ha hecho de manera exitosa, puede pasar a cancelar el costo de reparacion");
            }
            else
            {
                Console.WriteLine("La reparacion del auto no ha terminado aun, no se puede cancelar el costo de reparacion");
            }
        }

        public void OnVehiculoIngresado(bool carro)
        {
            if (carro == true)
            {
                Console.WriteLine("El ingreso del Carro se hizo de manera exitosa, Puede seguir con la reparacion");
            }
            else
                Console.WriteLine("El carro no se ha ingresado, o no hay ningun carro que ingresar");
        }
    }
}
