using EspacioEmpleados;
DateTime fechaNacimiento = new DateTime(1994,5,2);
DateTime fechaIngreso = new DateTime(2015,7,15);

Empleado empleado1 = new Empleado("yo", "diaz", fechaNacimiento, 'c', fechaIngreso, 1000, 2);
empleado1.Antiguedad();
Console.WriteLine(empleado1.FechaIngreso);

Console.WriteLine("fin del programa");
