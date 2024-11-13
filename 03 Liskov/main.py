import math


# Clase base que representa una figura
class Figura:
    def calcular_area(self):
        return 0


# Subclase Rectángulo que extiende de Figura
class Rectangulo(Figura):
    def __init__(self, ancho, alto):
        self.ancho = ancho
        self.alto = alto

    def calcular_area(self):
        return self.ancho * self.alto


# Subclase Círculo que extiende de Figura
class Circulo(Figura):
    def __init__(self, radio):
        self.radio = radio

    def calcular_area(self):
        return math.pi * (self.radio ** 2)


# Uso del polimorfismo y la sustitución
def main():
    figura1 = Rectangulo(5, 10)
    figura2 = Circulo(7)

    print("Área Rectángulo:", figura1.calcular_area())  # 50
    print("Área Círculo:", figura2.calcular_area())      # 153.94


if __name__ == "__main__":
    main()
