internal class Program
{
    private static void Main(string[] args)
    {

        //Un vendedor recibe un sueldo base de $XXXX. Ademas, Recibe una comisi[on del 10% sobre el valor de venta que realiza.

        //Declarar las variables.
        decimal SueldoBase, Venta1, Venta2, Venta3, Comision1, Comision2, Comision3, TotalComisiones, TotalMes, MaxComision, PromComision, TotalVentas;

        //Declarar las Constantes
        const decimal Comision = 10; // Aqui se pone 10, ya que mas adelante en la operacion se hara la conversion para que pueda aplicarse el 10% de la comision.
        const decimal Objetivo = 1000000; // 1 millon de pesos como objetivo
        const decimal Bono = 100000; // Bono de 100.000 pesos por superar la meta



        Console.WriteLine("Hello, World!");
    }
}