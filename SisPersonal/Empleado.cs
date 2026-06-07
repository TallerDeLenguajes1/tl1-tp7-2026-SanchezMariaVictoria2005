namespace EspacioEmpleados
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;

        private Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, int cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = (Cargos)cargo;
        }

        //propiedades
        public DateTime FechaIngreso //propiedad para acceder a la fecha de ingreso
        {
            get => fechaIngreso;
        }

        public DateTime FechaNacimiento //propiedad para acceder a la fecha de nacimiento
        {
            get => fechaNacimiento;
        }

        public double SueldoBasico //propiedada para acceder al sueldo basico
        {
            get => sueldoBasico;
        }

        

        //metodos
        public int Antiguedad()
        {
            return DateTime.Today.Year - fechaIngreso.Year;
        }

        public int Edad()
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }

        public int jubilacion()
        {
            return 65 - Edad();
        }


        public double Salario()
        {
            double adicional = 0;
            if (1 <= Antiguedad() && Antiguedad() < 20)
            {
                adicional += (sueldoBasico * 0.01) * Antiguedad();
            }
            else
            {
                adicional += (sueldoBasico * 0.25) * Antiguedad();
            }

            //aqui van los cargos 
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional += adicional * 0.50;
            }
            
            if (estadoCivil == 'c')
            {
                adicional += 150000;
            }
            
            return (sueldoBasico + adicional);
        }
    }
        

    enum Cargos
    {
       Auxiliar, 
       Administrativo,
       Ingeniero,
       Especialista,
       Investigado 

    }


}