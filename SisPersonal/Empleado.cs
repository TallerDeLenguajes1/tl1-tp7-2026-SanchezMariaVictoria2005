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

        public DateTime FechaIngreso //propiedad para acceder a la fecha de ingreso
        {
            get => FechaIngreso;
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