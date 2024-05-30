/**************************
Autor: jose hot
Fecha:          29-05-2024
Descripción:    Ejercicio estructura de decisión múltiple
Se desea un programa que ayude diciendo
las preferencias según el género:
- Si es un hombre menor de edad sus preferencias son:
    Figuras de acción, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía
***************************/
using System;

class HelloWorld {
    static void Main() {
        Console.WriteLine("Ingrese su género (Hombre/Mujer):");
        string genero = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Sus preferencias son:");

        if (genero == "hombre") {
            if (edad < 18) {
                Console.WriteLine("- Figuras de acción");
                Console.WriteLine("- Caricaturas");
                Console.WriteLine("- Series TV");
            } else {
                Console.WriteLine("- Cine");
                Console.WriteLine("- Picnic");
                Console.WriteLine("- Filantropía");
            }
        } else if (genero == "mujer") {
            if (edad < 18) {
                Console.WriteLine("- Muñecas");
                Console.WriteLine("- Maquillaje");
                Console.WriteLine("- Series TV");
            } else {
                Console.WriteLine("- Maquillaje");
                Console.WriteLine("- Series TV");
                Console.WriteLine("- Cine");
                Console.WriteLine("- Filantropía");
            }
        } else {
            Console.WriteLine("Género no reconocido. Por favor ingrese 'Hombre' o 'Mujer'.");
        }
    }
}