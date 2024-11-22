using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;

public class Desarrollo{
    public static void eje1(){
        Console.WriteLine("Escribe el primer lado");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escribe el segundo lado");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escribe el tercer lado");
        double lado3 = Convert.ToDouble(Console.ReadLine());

         if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine(@"El triangulo es Equilatero
                 
             ");
        }
        else if(lado1 == lado2 || lado2 == lado3|| lado1 == lado3)
        {
            Console.WriteLine(@"El triangulo es Isosceles
             
            ");    
        }
        else
        {
            Console.WriteLine(@"El triangulo es Escaleno
            
            ");
        }

    }

    public static void eje2()
    {
        Console.WriteLine("Escibe el numero que deseas multiplicar");
        double number = Convert.ToDouble(Console.ReadLine());

        for (int i = 12; i >= 1; i --)
        {
            double r = number * i;
            Console.WriteLine($"{number} x {i} = {r}");
        }

    }

        public static void eje3()
    {
        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine()!;

        string url = "https://api.genderize.io/?name=" + nombre;

        string json = new WebClient().DownloadString(url);

        Genero datos = JsonConvert.DeserializeObject<Genero>(json)!;
        
        var genero = (datos.gender == "male")?"Masculino": "Femenino";

        Console.Write($"Su genero es: {genero}");

    }

     public class Genero
    {
        public int count { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public double probability { get; set; }
    }

    
}
    }
  {
