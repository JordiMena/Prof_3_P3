using System.Data;
using System.Diagnostics;
bool continuar = true;
while(continuar == true){
    Console.Clear();
    Console.WriteLine(@"

        ╔╗ ┬┌─┐┌┐┌┌┐ ┌─┐┌┐┌┬┌┬┐┌─┐  ┌─┐┬    ╔═╗┬┌─┐┌┬┐┌─┐┌┬┐┌─┐
        ╠╩╗│├┤ │││├┴┐├┤ ││││ │││ │  ├─┤│    ╚═╗│└─┐ │ ├┤ │││├─┤
        ╚═╝┴└─┘┘└┘└─┘└─┘┘└┘┴─┴┘└─┘  ┴ ┴┴─┘  ╚═╝┴└─┘ ┴ └─┘┴ ┴┴ ┴


        1.Determinar si un triangulo es Equilatero, Isoceles o O escaleno.
        2.Tabla de multiplicar.
        3.genero de una persona.
        0.Salir
    
    ");

    Console.WriteLine("Elige la opcion: ");
    int opcion1 = Convert.ToInt32(Console.ReadLine());    

        case 0:
        continuar = false;
        Console.WriteLine("Gracias por utilizar este programa.");
        break;


        case 1:
        Console.WriteLine(@"
        ███████╗██╗  ██╗███████╗██████╗  ██████╗██╗███████╗███████╗     ██╗    
        ██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔════╝██║██╔════╝██╔════╝    ███║    
        █████╗   ╚███╔╝ █████╗  ██████╔╝██║     ██║███████╗█████╗      ╚██║    
        ██╔══╝   ██╔██╗ ██╔══╝  ██╔══██╗██║     ██║╚════██║██╔══╝       ██║    
        ███████╗██╔╝ ██╗███████╗██║  ██║╚██████╗██║███████║███████╗     ██║    
        ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝╚══════╝╚══════╝     ╚═╝    
                                                                    
        ");
        Desarrollo.eje1();

        Console.Write("Presiona enter para continuar");
        Console.ReadKey();
        break;

        case 2:

        break;

        case 3:

        break;

        

    }


}
