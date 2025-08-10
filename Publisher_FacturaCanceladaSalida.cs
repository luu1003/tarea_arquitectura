﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_FacturaCanceladaSalida
    {
        internal delegate void delegado_factura_salida();
        internal event delegado_factura_salida evt_factura_salida;

        public void Informar_Cancelamiento_Factura_Salida(float pago)
        {
            try
            {
                if (evt_factura_salida != null)
                {
                    evt_factura_salida();
                    if (pago == Reparacion.Valor)
                    {
                        Console.WriteLine("El pago fue procesado con exito, puede pasar a retirar su vehiculo");
                    }
                    else
                    {
                        Console.WriteLine("El pago no fue procesado, revise que la cantidad es el costo de la reparacion o intente de nuevo");
                    }

                }
                else Console.WriteLine("Llamada no valida al método");

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error en el evento Informar Factura Cancelada" + ex);
                throw;
            }

        }

    }
}
