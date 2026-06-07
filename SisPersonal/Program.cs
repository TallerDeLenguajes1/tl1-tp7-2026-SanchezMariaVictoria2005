using EspacioEmpleados;
DateTime fechaNacimiento = new DateTime(1994,5,2);
DateTime fechaIngreso = new DateTime(2011,5,15);

Empleado empleado1 = new Empleado("yo", "diaz", fechaNacimiento, 'c', fechaIngreso, 650000, 2);


Console.WriteLine(empleado1.FechaIngreso);
Console.WriteLine(empleado1.FechaNacimiento);
empleado1.Edad();
empleado1.jubilacion();
Console.WriteLine(empleado1.SueldoBasico);
Console.WriteLine(empleado1.Salario());

Console.WriteLine("fin del programa");
