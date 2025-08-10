using b_taller_automovil.Clases;
using b_taller_automovil.Eventos;
using b_taller_automovil.Servicios;
using b_taller_automovil.Subscriptores;
using System.Collections.Generic;

namespace b_taller_automovil
{
    public class CompositionRoot
    {
        public void WireUp()
        {
            // Create instances of subscribers
            var notificaciones = new NotificacionesConsola();

            // Create instances of publishers
            var publisherCredito = new Publisher_CreditoActualizado();
            var publisherFactura = new Publisher_FacturaCanceladaSalida();
            var publisherReparacion = new Publisher_ReparacionFinalizada();
            var publisherIngreso = new Publisher_VehiculoIngresado();

            // Subscribe to events
            publisherCredito.evt_credito += notificaciones.OnCreditoActualizado;
            publisherFactura.evt_factura_salida += notificaciones.OnFacturaCanceladaSalida;
            publisherReparacion.evt_reparacion += notificaciones.OnReparacionFinalizada;
            publisherIngreso.evt_ingreso += notificaciones.OnVehiculoIngresado;

            // Create instances of services, injecting publishers
            var servicioDePago = new ServicioDePago(publisherFactura, publisherCredito);

            // Create instances of domain objects, injecting publishers
            // This is just an example of how a Reparacion object would be created.
            // The actual creation would depend on the application's logic.
            var carro = new Gasolina("ABC-123", "Ford", "Focus", 2020, "John Doe", 4);
            var repuestos = new List<Repuesto>();
            var mecanicos = new List<Mecanico>();
            var reparacion = new Reparacion(carro, repuestos, mecanicos, publisherIngreso, publisherReparacion);
        }
    }
}
