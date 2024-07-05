List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();
productos.Add(
    new Dictionary<string, object>
        {
            {"nombre", "coco cola"},
            {"precio", "100000"},
            {"cantidad", 100}
        }
        );
productos.Add(
    new Dictionary<string, object>
        {
            {"nombre", "mani tajin"},
            {"precio", "200000"},
            {"cantidad", 500}
        }
        );
productos.Add(
    new Dictionary<string, object>
        {
            {"nombre", "toronjarina"},
            {"precio", "1890"},
            {"cantidad", 1000}
        }
        );

string separador = (@"

--------------------------------------------------------
     **********************************************
--------------------------------------------------------

");
string separador2 = (@"
--------------------------------------------------------
     **********************************************
--------------------------------------------------------
");

int contador = 0;
bool flag = true;
while (flag)
{

Console.WriteLine(separador);

Console.WriteLine(@"
      _____________________________________________
     |             Tienda Toronjarina              |
     |---------------------------------------------|
     |   1.  Agregar productos al inventario       |
     |   2.   Cambiar datos de un producto         | 
     |   3.  Buscar un producto por su nombre      |
     |   4.   Mostrar el inventario completo       |
     |   5.  Eliminar un producto del inventario   |
     |   6.        Apagar el programa              |
     |_____________________________________________|
     |   'Los mejores productos al mejor precio'   |
     |_____________________________________________|
");
Console.WriteLine(separador);

    Console.Write(@"
                Ingrese una opción => ");
    string? optionInput = Console.ReadLine();
    int opcion;
    bool verification = int.TryParse(optionInput, out opcion);

    if (verification == true || string.IsNullOrEmpty(optionInput)!)
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine(separador);

                Console.Write(@"
        Ingrese el nombre del nuevo producto => ");
                string? nombreProducto = Console.ReadLine();

                Console.WriteLine(separador2);

                Console.Write(@"
        Ingrese el precio del nuevo producto => ");
                string? precioProducto = Console.ReadLine();
                double precioProductoI;
                bool isPrecioValido = double.TryParse(precioProducto, out precioProductoI);

                Console.WriteLine(separador2);

                Console.Write(@"
        Ingrese la cantidad del nuevo producto => ");
                string? cantidadProducto = Console.ReadLine();
                int cantidadProductoD;
                bool isCantidadValida = int.TryParse(cantidadProducto, out cantidadProductoD);

                Console.WriteLine(separador2);

                if (!isPrecioValido || !isCantidadValida || string.IsNullOrEmpty(nombreProducto) || string.IsNullOrEmpty(precioProducto) || string.IsNullOrEmpty(cantidadProducto))
                {

                    Console.WriteLine(separador2);

                    Console.WriteLine("Debes escribir correctamente los valores.");
                    break;
                }
                else
                {
                    productos.Add(
                        new Dictionary<string, object>
                            {
                                    {"nombre", nombreProducto},
                                    {"precio", precioProductoI},
                                    {"cantidad", cantidadProductoD}
                            }
                            );
                }
Console.WriteLine(
@"
___________________________________________________________________________
|  ID  |      Nombre       |   precio   |   cantidad   |    precio total   |");
    contador = 0;
    foreach (var c in productos)
    {
        contador++;
        Console.WriteLine(
@$"|__________________________________________________________________________|
|   {contador,-3}|    {c["nombre"],-15}|  {c["precio"],-10}|     {c["cantidad"],-8} |  {Convert.ToInt32(c["precio"]) * Convert.ToInt32(c["cantidad"]),-17}|");}
Console.WriteLine(@"|__________________________________________________________________________|
");

                break;


            case 2:
Console.WriteLine(
@"
___________________________________________________________________________
|  ID  |      Nombre       |   precio   |   cantidad   |    precio total   |");
    contador = 0;
    foreach (var c in productos)
    {
        contador++;
        Console.WriteLine(
@$"|__________________________________________________________________________|
|   {contador,-3}|    {c["nombre"],-15}|  {c["precio"],-10}|     {c["cantidad"],-8} |  {Convert.ToInt32(c["precio"]) * Convert.ToInt32(c["cantidad"]),-17}|");}
Console.WriteLine(@"|__________________________________________________________________________|
");

Console.WriteLine(separador2);
                Console.Write("        Ingrese el indice del producto => ");
                string? indiceProductoI = Console.ReadLine();
Console.WriteLine(separador2);
                
                int indiceProducto;
                bool isIntProducto = int.TryParse(indiceProductoI, out indiceProducto);

                if (indiceProducto > productos.Count || string.IsNullOrEmpty(indiceProductoI) || isIntProducto == false)
                {
                    Console.WriteLine(separador2);
                    Console.WriteLine("     Debes de ingresar un valor apropiado");
                    Console.WriteLine(separador2);
                    break;
                }

                else
                {
                    Console.WriteLine
    (@"    ________________________________________________
    | 1.                Nombre                     |
    | 2.                precio                     |
    | 3.                cantidad                   |
    |______________________________________________|
");

                    Console.Write("Ingrese el numero del elemento que desee cambiar su valor  => ");
                    string? elementoACambiarI = Console.ReadLine();
                    int elementoACambiar;
                    bool isok = int.TryParse(elementoACambiarI, out elementoACambiar);

                    if (isok == false || string.IsNullOrEmpty(elementoACambiarI) || elementoACambiar > 3)
                    {         
                        Console.WriteLine(separador2);               
                        Console.WriteLine("        Ingresa una opcion dentro del rango");
                        break;
                    }

                    else
                    {
                        if (elementoACambiar == 1)
                        {
                            Console.WriteLine(separador2);
                            Console.Write("       Ingrese el nuevo nombre del producto => ");
                            string? nuevoNombre = Console.ReadLine();
                            productos[indiceProducto - 1]["nombre"] = nuevoNombre;
                        }

                        else if (elementoACambiar == 2)
                        {
                            Console.WriteLine(separador2);
                            Console.Write("       Ingrese el nuevo precio del producto => ");
                            int nuevoPrecio = Convert.ToInt16(Console.ReadLine());
                            productos[indiceProducto - 1]["precio"] = nuevoPrecio;
                        }

                        else if (elementoACambiar == 3)
                        {
                            Console.WriteLine(separador2);
                            Console.Write("       Ingrese la nueva cantidad del producto => ");
                            int nuevaCantidad = Convert.ToInt16(Console.ReadLine());
                            productos[indiceProducto - 1]["cantidad"] = nuevaCantidad;
                        }
                    }

                }
                break;


            case 3:
                bool flag3 = false;
                Console.WriteLine(separador2);
                Console.Write("Ingrese el nombre del producto que desee encontrar => ");
                string nombreProductoAEncontrar = Console.ReadLine().ToLower();

                for (int i = 0; i < productos.Count; i++)
                {
                    if (Convert.ToString(productos[i]["nombre"]) == nombreProductoAEncontrar)
                    {
                        Console.WriteLine(separador2);
                        Console.WriteLine("        Este es el producto que estas buscando");

Console.WriteLine(
@"
___________________________________________________________________________
|  ID  |      Nombre       |   precio   |   cantidad   |    precio total   |");
    contador = 0;

        contador++;
        Console.WriteLine(
@$"|__________________________________________________________________________|
|   {contador,-3}|    {productos[i]["nombre"],-15}|  {productos[i]["precio"],-10}|     {productos[i]["cantidad"],-8} |  {Convert.ToInt32(productos[i]["precio"]) * Convert.ToInt32(productos[i]["cantidad"]),-17}|");
Console.WriteLine(@"|__________________________________________________________________________|
");
                        flag3 = false;
                        break;
                    }
                    else
                    {
                        flag3 = true;
                    }
                }
                if (flag3 == true)
                {
                    Console.WriteLine("El producto no existe");
                }

                break;


            case 4:Console.WriteLine(separador2);

Console.WriteLine(separador2);
Console.WriteLine(
@"
___________________________________________________________________________
|  ID  |      Nombre       |   precio   |   cantidad   |    precio total   |");
    contador = 0;
    foreach (var c in productos)
    {
        contador++;
        Console.WriteLine(
@$"|__________________________________________________________________________|
|   {contador,-3}|    {c["nombre"],-15}|  {c["precio"],-10}|     {c["cantidad"],-8} |  {Convert.ToInt32(c["precio"]) * Convert.ToInt32(c["cantidad"]),-17}|");}
Console.WriteLine(@"|__________________________________________________________________________|
");
break;


            case 5:
                Console.WriteLine(separador2);
                Console.WriteLine("        Estos son los productos actuales");

Console.WriteLine(
@"
___________________________________________________________________________
|  ID  |      Nombre       |   precio   |   cantidad   |    precio total   |");
    contador = 0;
    foreach (var c in productos)
    {
        contador++;
        Console.WriteLine(
@$"|__________________________________________________________________________|
|   {contador,-3}|    {c["nombre"],-15}|  {c["precio"],-10}|     {c["cantidad"],-8} |  {Convert.ToInt32(c["precio"]) * Convert.ToInt32(c["cantidad"]),-17}|");}
Console.WriteLine(@"|__________________________________________________________________________|
");
                Console.WriteLine(separador2);
                Console.Write("Ingrese el numero del producto que desea eliminar =>");
                string? idElementoAEliminarI = Console.ReadLine();
                int idElementoAEliminar;
                bool isconvertible = int.TryParse(idElementoAEliminarI, out idElementoAEliminar);

                Console.Write("     Estas seguro de esto?(yes/no) => ");
                string? confirmation = Console.ReadLine();

                if (confirmation == "yes" && idElementoAEliminar < productos.Count+1)
                {
                    productos.RemoveAt(idElementoAEliminar - 1);
                    Console.WriteLine(separador2);
                    break;
                }

                else if (confirmation == "no" && idElementoAEliminar < productos.Count+1)
                {
                    Console.WriteLine("     El elemento no ha sido eliminado");
                    Console.WriteLine(separador2);
                    break;
                }
                else
                {
                    Console.WriteLine("uno de los valores digitado es inusable en esta situacion");
                    break;
                }

                break;
            case 6:
                Console.WriteLine("        Adios");
                flag = false;
                break;
        }
    }
    else
    {
        Console.WriteLine("Lo que has escrito no se entiende vuelve a intentarlo");
    }

}
