// Interfaz que define el contrato para la clase de descuento
public interface IDescuento
{
    decimal CalcularDescuento(decimal precio);
}

// Clase base que calcula el precio sin descuento
public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    // Método que usa el descuento correspondiente sin modificar el código
    public decimal ObtenerPrecioConDescuento(IDescuento descuento)
    {
        return Precio - descuento.CalcularDescuento(Precio);
    }
}

// Implementación concreta de un descuento específico para estudiantes
public class DescuentoEstudiantes : IDescuento
{
    public decimal CalcularDescuento(decimal precio)
    {
        return precio * 0.10m;  // Descuento del 10%
    }
}

// Implementación concreta de un descuento específico para clientes frecuentes
public class DescuentoFrecuentes : IDescuento
{
    public decimal CalcularDescuento(decimal precio)
    {
        return precio * 0.20m;  // Descuento del 20%
    }
}
