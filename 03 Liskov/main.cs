/* The above C# class represents a base class for a figure with a method to calculate its area. */
// Clase base que representa una figura
public class Figura
{
    public virtual double CalcularArea() => 0;
}

// Subclase Rectángulo que extiende de Figura
public class Rectangulo : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    // Sobrescribe el método CalcularArea
    public override double CalcularArea()
    {
        return Ancho * Alto;
    }
}

// Subclase Círculo que extiende de Figura
public class Circulo : Figura
{
    public double Radio { get; set; }

    // Sobrescribe el método CalcularArea
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}

// Uso del polimorfismo y la sustitución
public class Programa
{
    public static void Main()
    {
        Figura figura1 = new Rectangulo { Ancho = 5, Alto = 10 };
        Figura figura2 = new Circulo { Radio = 7 };

        Console.WriteLine("Área Rectángulo: " + figura1.CalcularArea()); // 50
        Console.WriteLine("Área Círculo: " + figura2.CalcularArea()); // 153.94
    }
}
