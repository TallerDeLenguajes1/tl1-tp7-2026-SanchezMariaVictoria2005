namespace Empleados
{
    public class Empleados
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;

        private Cargos cargo;

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