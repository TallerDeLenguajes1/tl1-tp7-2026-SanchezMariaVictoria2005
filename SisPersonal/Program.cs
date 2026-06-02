using EspacioEmpleados;
DateTime fechaNacimiento = new DateTime(1994,5,2);
DateTime fechaIngreso = new DateTime(2015,7,15);

Empleado empleado1 = new Empleado("yo", "diaz", fechaNacimiento, 'c', fechaIngreso, 1000, 2);


Console.WriteLine(empleado1.FechaIngreso);
Console.WriteLine(empleado1.FechaNacimiento);
empleado1.Edad();
empleado1.jubilacion();
Console.WriteLine(empleado1.SueldoBasico);


Console.WriteLine("fin del programa");
