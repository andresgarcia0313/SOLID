""" Ejercicio de Netec """


class Empleado:
    """
    Clase que representa a un empleado.
    """
    def __init__(self, nombre: str, puesto: str, salario: float):
        self.nombre = nombre
        self.puesto = puesto
        self.salario = salario

    def obtener_detalles(self):
        """
        Obtiene los detalles del empleado.

        Returns:
            str: Una cadena con el nombre, puesto y salario del empleado.
        """
        return f"{self.nombre}, {self.puesto}, Salario: {self.salario}"

    def generar_informe(self):
        """
        Genera un informe del empleado.
        """
        return f"Informe del Empleado: {self.obtener_detalles()}"
# Uso


if __name__ == "__main__":
    empleado = Empleado("Rodrigo Silva", "Ingeniero de Software", 90000)
    informe = empleado.generar_informe()
    print(informe)
