
/* 1. ESCRIBE UN PROGRAMA QUE: 
 * 
   -> PIDA DATOS A UN CLIENTE: NOMBRE, EMAIL Y CUPON
   -> DETERMINE SI UN CLIENTE TIENE UN CUPON DE DESCUENTO
   -> MUESTRE EL PRECIO REBAJADO EN FUNCION DEL DESCUENTO
   -> MUESTRE EL PRECIO DEL PRODUCTO SI NO TIENE DESCUENTO
 */

Console.WriteLine("D igite el precio del producto que va a llevar");
double precioProducto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Si posee un cupon de descuento digite true si no digite false");
bool cupon = Convert.ToBoolean(Console.ReadLine());
double total = 0d;
if (cupon == true)
{
    Console.WriteLine("Digite el numero equivalente al porcentaje que posee su cupon de descuento");
    double descuento = Convert.ToDouble(Console.ReadLine());
    descuento /= 100;
    total = precioProducto - descuento * precioProducto;
    descuento *= precioProducto;
    Console.WriteLine("El valor que debe pagar por el producto es de: " + total +" Pesos"+ "\nCon un ahorro de: " + descuento + " Pesos");
}
else
{
    total = precioProducto;
    Console.WriteLine("El valor que debe pagar por el producto es de: " + total + " Pesos" );
}

Console.WriteLine("\nDigite la opcion deseada del leguaje de programacion que prefiera: \n1. C# \n2. Java \n3. C++ \n4. Python \n5. Otro");
int seleccion = Convert.ToInt32(Console.ReadLine());

switch (seleccion) 
{
    case 1:
        Console.WriteLine("Biembenido al mundo de C#");
        break;
    case 2:
        Console.WriteLine("Biembenido al mundo de Java");
        break;
    case 3:
        Console.WriteLine("Biembenido al mundo de C++");
        break;
    case 4:
        Console.WriteLine("Biembenido al mundo de Python");
        break;
    case 5:
        Console.WriteLine("Biembenido al mundo de Otro");
        break;
    default:
        Console.WriteLine("El lenguaje que digito no se encuentra registrado en el programa");
        break;
}