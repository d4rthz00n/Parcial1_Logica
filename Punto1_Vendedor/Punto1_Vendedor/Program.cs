internal class Program
{
    private static void Main(string[] args)
    {

        //Un vendedor recibe un sueldo base de $XXXX. Ademas, Recibe una comision del 10% sobre el valor de venta que realiza.

        //Declarar las variables.
        double SueldoBase, Venta1, Venta2, Venta3, Comision1, Comision2, Comision3, TotalComisiones, TotalMes, MaxComision, PromComision, TotalVentas;

        //Declarar las Constantes
        const double PerComision = 0.10; // Aqui se pone 10, ya que mas adelante en la operacion se hara la conversion para que pueda aplicarse el 10% de la comision.
        const double Objetivo = 1000000; // 1 millon de pesos como objetivo
        const double Bono = 100000; // Bono de 100.000 pesos por superar la meta

        //Solicitar datos al usuario para realizar el procedimiento requerido.

        //Solicitamos el sueldo base del vendedor, y asignamos el valor a la variable Venta1.
        Console.WriteLine("Ingrese Sueldo Base del Vendedor: ");
        SueldoBase = Convert.ToDouble(Console.ReadLine());

        //Solicitar el valor de las tres ventas del mes
        Console.WriteLine("Ingrese Valor de la Primer Venta: ");
        Venta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese Valor de la Segunda Venta: ");
        Venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese Valor de la Tercer Venta: ");
        Venta3 = Convert.ToDouble(Console.ReadLine());

        //Proceso de la informacion recolectada

        //Calcular comisiones
        //Aqui es mas adelante, aqui declaramos que el valor de la comision (10) equivale al 10%
        //PerComision = Comision * 100;

        //Calculamos la comision del 10% sobre cada venta realizada.
        Comision1 = Venta1 * PerComision;
        Comision2 = Venta2 * PerComision;
        Comision3 = Venta3 * PerComision;

        //Hora de responder las dudas que tiene el que creo el examen.

        //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes ?
        TotalComisiones = Comision1 + Comision2 + Comision3;
        Console.WriteLine($"Total de Comisiones devengadas: {TotalComisiones:C0}");

        //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
        TotalMes = SueldoBase + TotalComisiones;
        Console.WriteLine($"Billullo Total: {TotalMes}");

        //¿Cuál fue la venta que le generó la mayor comisión?
        if (Comision1 > Comision2 && Comision1 > Comision3)
        {
            MaxComision = Comision1;
            Console.WriteLine($"La venta con Mayor Comision fue La Primer Venta, con una comision de {MaxComision}");
        }
        else if (Comision2 > Comision1 && Comision2 > Comision3)
        {
            MaxComision = Comision2;
            Console.WriteLine($"La venta con Mayor Comision fue La Segunda Venta, con una comision de {MaxComision:C0}");
        }
        else
        {
            MaxComision = Comision3;
            Console.WriteLine($"La venta con Mayor Comision fue La Tercer Venta, con una comision de {MaxComision:C0}");
        }

        //¿Cuál fue el promedio de las comisiones que recibió por cada venta? 
        PromComision = TotalComisiones / 3;
        Console.WriteLine($"El Promedio de las Comisiones por venta es: {PromComision:C}");

        //Mirar si se hace acreador al bono de cumplimiento de la meta del mes.
        TotalVentas = Venta1 + Venta2 + Venta3;
        if (TotalVentas >= Objetivo)
        {
            Console.WriteLine("El vendedor ha superado el objetivo y recibe un beneficio de $100.000,00");
            double TotalMasBono = TotalMes + Bono;
        }
        else 
        {
            Console.WriteLine("El vendedor no ha alcanzado el objetivo, por lo tanto no recibe el bono");
        }

        //Eso es to eso es to eso es todo amigos... mentiris, aun falta.
        //Mostrar el total Final
        Console.WriteLine($"El total final a recibir en el mes es: {TotalMes:C}");
    }
}