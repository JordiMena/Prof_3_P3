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
  {
