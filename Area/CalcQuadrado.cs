namespace Area
{
    public class CalcQuadrado
    {
        public double Lado;

        public double AreaQuadrado(){
            return Lado * Lado;
        }

        public override string ToString()
        {
            return AreaQuadrado().ToString();
        }
    }
}