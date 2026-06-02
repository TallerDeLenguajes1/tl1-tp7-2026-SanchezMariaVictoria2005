namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public void Sumar (double termino)
        {
            dato = dato + termino;
        }

        public void Restar(double termino)
        {
            dato = dato - termino;
        }

        public Calculadora()
        {
            dato = 0 ;
        }

    }

    

}