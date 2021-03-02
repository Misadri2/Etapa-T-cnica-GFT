namespace Area
{
    public class CalcRetangulo
    {
        public double Largura;
        public double Altura;

        public double AreaRetangulo(){
            return Largura * Altura;
        }

        public override string ToString()
        {
            return AreaRetangulo().ToString();
        }
    }
}