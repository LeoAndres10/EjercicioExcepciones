
using EjercicioExcepciones;
using System.Linq.Expressions;

Operaciones operaciones = new Operaciones();
int opcion = 0;
double n1, n2;

while (opcion!=5)
{

    Console.WriteLine("******MENU******");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Salir");
    opcion=Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            try { 
            Console.WriteLine("SUMA");
            Console.WriteLine("Ingrese primer numero: ");
            n1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            operaciones.Suma(n1, n2);

            }catch (FormatException e)
            {
                Console.WriteLine(e.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            break;

            case 2:

            try { 
            Console.WriteLine("Resta");
            Console.WriteLine("Ingrese primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            operaciones.Resta(n1, n2);
            }catch (FormatException e)
            {
        Console.WriteLine(e.ToString());

            }catch (Exception e)
            {
        Console.WriteLine($"Error: {e.ToString()}");
            }

    break;

            case 3:
            try
            {
                Console.WriteLine("MULTIPLICACION");
                Console.WriteLine("Ingrese primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                operaciones.multiplicacion(n1, n2);
            }catch (FormatException e)
            {
                Console.WriteLine(e.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }

            break;


            case 4:

            try
            {
                Console.WriteLine("DIVISION");
                Console.WriteLine("Ingrese primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                operaciones.Division(n1, n2);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            break;

            default: Console.WriteLine("Opcion incorrecta");

            break;
    }

}