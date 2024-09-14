internal class Program
{
    private static void Main(string[] args)
    {
        //Escriba un programa que pida los coeficientes de una ecuación de primer grado (a * x + b = 0) y muestre la solución.
        //Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b/a

        //Definimos las variables

        double a, b, x;

        //Inicializar y Asignar Valor de 'a'
        Console.WriteLine("Ingrese el valor de 'a': ");
        a = Convert.ToDouble(Console.ReadLine());

        //Inicializar y Asignar Valor de 'b'
        Console.WriteLine("Ingrese el valor de 'b': ");
        b = Convert.ToDouble(Console.ReadLine());

        //Revisar los casos de acuerdo a los valores de 'a' y 'b'
        if (a == 0)
        {
            if (b == 0)
            {
                // Caso 1: a = 0 y b = 0
                Console.WriteLine("Todos los Numeros son Solucion.");
            }
            else
            {
                // Caso 2: a = 0 y b != 0
                Console.WriteLine("La ecuacion no tiene solucion.");
            }
        }
        else
        {
            // Caso 3: a != 0, se aplica la formula x = -b/a
            x = -b / a;
            Console.WriteLine("La solucion de x = {x}");
        }
    }
}