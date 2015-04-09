using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioEntregaPaquetes.Modelo;


namespace ServicioEntregaPaquetes.Modelo
{
    public class OrdenaryPakcage : Package
    {
        #region "Atributos"
        private byte days;
        private string p1;
        private double p2;
        private int p3;
        #endregion

        #region "Propiedades"
        public byte Days
        {
            get { return days; }

        }
        #endregion

        #region "Constructores"
        public OrdenaryPakcage()
            : base()
        {
            this.days = 3;


        }
        public OrdenaryPakcage(string code, Person sender, Person recipients, double weight, double cost, byte days)
            : base(code, sender, recipients, weight, cost)
        {
            this.days = days;


        }

        public OrdenaryPakcage(string p1, Person sender, Person recipients, Person addresse, double p2, int p3)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.Sender = sender;
            this.Recipients = recipients;
            this.p2 = p2;
            this.p3 = p3;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\nDays: " + this.days;

        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            OrdenaryPakcage o = (OrdenaryPakcage)obj;
            bool result = false;

            if (this.days == o.days)

                result = true;

            return result;
        }
        #endregion

        #region "Métodos"

        public override double calculateCost()
        {

            return (this.Cost * this.Weight);
        }

        #endregion

    }
}