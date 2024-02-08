using System;

interface IOperacion
{
    void RealizarOperacion();
}

class Suma : IOperacion
{
    private int num1;
    private int num2;

    public Suma(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public void RealizarOperacion()
    {
        Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");
    }
}

class Resta : IOperacion
{
    private int num1;
    private int num2;

    public Resta(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public void RealizarOperacion()
    {
        Console.WriteLine($"La resta de {num1} y {num2} es: {num1 - num2}");
    }
}

class Program
{
    static void Main()
    {
        IOperacion operacion1 = new Suma(5, 3);
        IOperacion operacion2 = new Resta(10, 7);

        MostrarResultado(operacion1);
        MostrarResultado(operacion2);
    }

    static void MostrarResultado(IOperacion operacion)
    {
        operacion.RealizarOperacion();
    }
}
