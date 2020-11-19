using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTemp
{
    public class Temperature
    {

        private float degres;

        /// <summary>
        /// evenement qui se produit qd risque de gel 0 --- Gel
        /// evenement qui se produit qd on a de la fievre 38--- Fievre


        public delegate void DelegateTemperature(Temperature sender);
        public event DelegateTemperature Gel;
        public event DelegateTemperature Fievre;

        /// Cerise sur le gateau:
        /// 
        /// evenement preconfigurable...evenement declenche pour une temperature specifique
        private float[] temperatureDAlertes;
        public delegate void DelegateTemperatureAlerte(Temperature sender);
        public event DelegateTemperatureAlerte Alerte;

        public Temperature(float _degres)
        {
            this.degres = _degres;
        }
        public Temperature() : this(0)
        {
        }

        public Temperature(float _degres, float[] temperatureDAlertes)
        {
            this.degres = _degres;
            this.temperatureDAlertes = temperatureDAlertes;
        }

        public float Degres
        {
            get => degres;
            // set => degres = value; 
        }

        /// </summary>

        public void Monter()
        {
            this.degres += 0.5f;
            this.VerifierTemperature();
        }

        public void Diminuer()
        {
            this.degres -= 0.5f;
            this.VerifierTemperature();
        }

        public void VerifierTemperature()
        {
            if (this.degres <= 0)
            {
                Gel(this);
            }

            if (this.degres > 37)
            {
                Fievre(this);
            }

            if (temperatureDAlertes != null)
            {
                foreach (float f in temperatureDAlertes)
                {
                    if (this.degres == f)
                    {
                        Alerte(this);
                    }
                }
            }
        }
    }
}
