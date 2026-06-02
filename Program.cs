using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();
miCalculadora.Sumar(2);
miCalculadora.Restar(4);
miCalculadora.Multiplicar(10);
miCalculadora.Dividir(0);
miCalculadora.Limpiar();

Console.WriteLine("resultado:" + miCalculadora.Resultado);

Console.WriteLine("fin del programa");
