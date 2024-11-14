// Interfaz básica para las impresoras
public interface IImpresora
{
    void ImprimirDocumento(string documento);
}

// Interfaz para impresoras multifuncionales que también tienen escáner
public interface IImpresoraConEscaner : IImpresora
{
    void EscanearDocumento(string documento);
}

// Clase que implementa una impresora simple
public class ImpresoraSimple : IImpresora
{
    public void ImprimirDocumento(string documento)
    {
        Console.WriteLine("Imprimiendo documento en impresora simple.");
    }
}

// Clase que implementa una impresora multifuncional
public class ImpresoraMultifuncional : IImpresoraConEscaner
{
    public void ImprimirDocumento(string documento){
        Console.WriteLine("Imprimiendo documento en impresora multifuncional.");
    }

    public void EscanearDocumento(string documento){
        Console.WriteLine("Escaneando documento en impresora multifuncional.");
    }
}

// Uso del código
public class Programa
{
    public static void Main()
    {
        IImpresora impresora1 = new ImpresoraSimple();
        IImpresoraConEscaner impresora2 = new ImpresoraMultifuncional();

        impresora1.ImprimirDocumento("Informe");
        impresora2.ImprimirDocumento("Factura");
        impresora2.EscanearDocumento("Contrato");
    }
}