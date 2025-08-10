using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class Electrico : Carro
    {
        private int autonomia;

        public Electrico(string placa, string marca, string modelo, int año, string dueño, int autonomia)
            : base(placa, marca, modelo, año, dueño)
        {
            this.Autonomia = autonomia;
        }

        public Electrico(string placa, string marca, string modelo, int año, string dueño)
            : base(placa, marca, modelo, año, dueño)
        {
        }
        public int Autonomia { get => autonomia; set => autonomia = value; }
        public override string Reparacion_Puesto_Punto()
        {
            this.Reparacion = true;
            return $"Se comprobo el estado de la batería, se cambiaron los lubricantes, se examino el desgaste de las llantas, se examino la amortiguación y se cambia el líquido de frenos";
        }
    }
}
