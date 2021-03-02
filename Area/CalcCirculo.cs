using System;

namespace Area
{
    public class CalcCirculo
    {
        public double Raio;
        public double Pi;
        
        public double AreaCirculo(){
            return (Pi*(Math.Pow(Raio, 2)));
        }

        public override string ToString()
        {
            return AreaCirculo().ToString();
        }
    }
}