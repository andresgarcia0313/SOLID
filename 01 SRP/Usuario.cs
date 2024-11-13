// Antes de aplicar SRP: Una clase con múltiples responsabilidades
public class Usuario
{
    public string Nombre { get; set; }
    public string Correo { get; set; }

    // Responsabilidad 1: Guardar información de usuario
    public void GuardarUsuario()
    {
        // Lógica para guardar el usuario en la base de datos
        Console.WriteLine("Usuario guardado en la base de datos");
    }

    // Responsabilidad 2: Enviar notificación por correo
    public void EnviarCorreo()
    {
        // Lógica para enviar un correo
        Console.WriteLine("Correo enviado al usuario");
    }
}

// Después de aplicar SRP: Separando responsabilidades
public class Usuario
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
}

// Clase que se encarga solo de la persistencia de usuarios
public class GestorUsuario
{
    public void GuardarUsuario(Usuario usuario)
    {
        // Lógica para guardar el usuario en la base de datos
        Console.WriteLine("Usuario guardado en la base de datos");
    }
}

// Clase que se encarga solo del envío de correos
public class Notificador
{
    public void EnviarCorreo(Usuario usuario)
    {
        // Lógica para enviar un correo
        Console.WriteLine("Correo enviado al usuario");
    }
}


/* 
Ejercicio Fácil:
Crea una clase Producto que tenga propiedades como nombre, precio y cantidad.
Separa el código en dos clases: una para almacenar información de producto 
y otra para manejar el cálculo de precios con descuentos.

Ejercicio Medio:
Tienes una aplicación de gestión de clientes. Crea dos clases: una para 
almacenar la información de los clientes y otra para enviar correos de
bienvenida. Asegúrate de que cada clase tenga solo una responsabilidad.

Ejercicio Avanzado:
Diseña un sistema de reservas de hotel. Crea clases separadas para gestionar 
la información de las habitaciones, procesar pagos y generar reportes. 
Asegúrate de aplicar el SRP en cada una de las clases involucradas.

SRP: Single Responsibility Principle
*/