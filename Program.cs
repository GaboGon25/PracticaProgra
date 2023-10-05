using PracticaProgra;
using System.Security.Cryptography;

int opcion = 0;
double lado1 = 0.0;
double lado2 = 0.0;

string valor = String.Empty;

IFigurasGeometricas operacion = new Cuadrado();

while (opcion != 5)
{
    Console.WriteLine("1- Cuadrado\n2-Rectangulo" +
        "\n3-Salir");
    Console.WriteLine("¿Que figura desea calcular?");
    valor = Console.ReadLine();
    opcion = Convert.ToInt32(valor);

    Console.Write("Digite el primer lado: ");
    lado1= Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite el segundo lado");
    lado2 = Convert.ToDouble(Console.ReadLine());

    // Polimorfismo
    if (opcion == 1)
        operacion = new Cuadrado();
    if (opcion == 2)
        operacion = new Rectangulo();
    

    operacion.CalcularArea(lado1, lado2);
    operacion.Mostrar();
}
