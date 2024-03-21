using System;

public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Ingrese el peso del paciente en kg:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del paciente en metros (por ejemplo, 1.65 para 1 metro y 65 centímetros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);

            string categoria;
            if (imc < 18.5)
            {
                categoria = "Peso insuficiente";
            }
            else if (imc <= 24.9)
            {
                categoria = "Peso saludable";
            }
            else if (imc <= 29.9)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            Console.WriteLine($"El IMC del paciente es: {imc}");
            Console.WriteLine($"Categoría: {categoria}");

            Console.WriteLine("¿Desea calcular el IMC de otro paciente? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                break;
            }
        } while (true);

        Console.WriteLine("Gracias por usar la calculadora de IMC.");
    }

    public static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}
