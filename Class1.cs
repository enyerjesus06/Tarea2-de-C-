


 public class Class4
{
    public void CalculosSP()
     {
        /* Declarar las variables: Num1, Num2, Num3, Num4, Suma, Producto...*/
        int Num1 = 0;
        int Num2 = 0;
        int Num3 = 0;
        int Num4 = 0;
        int Suma = 0;
        int Producto = 0;
        string linea = string.Empty;

        try
        {
            Console.WriteLine("Introduce el primer número: ");
            linea = Console.ReadLine();
            Num1 = Convert.ToInt32(linea);

            Console.WriteLine("Introduce el segundo número: ");
            linea = Console.ReadLine();
            Num2 = Convert.ToInt32(linea);

            Console.WriteLine("Introduce el tercer número: ");
            linea = Console.ReadLine();
            Num3 = Convert.ToInt32(linea);

            Console.WriteLine("Introduce el cuarto número: ");
            linea = Console.ReadLine();
            Num4 = Convert.ToInt32(linea);


            Suma = (Num1 + Num2);
            Producto = (Num3 * Num4);


            Console.WriteLine($"La suma de los dos primeros números es: {Suma} ");

            Console.WriteLine($"El producto de los dos segundos números es: {Producto} ");

        }

        catch (Exception ex)
        
        { 
        Console.WriteLine($"Ocurrio el siguiente error:{ex.Message}");

        
        }

    }

 }

