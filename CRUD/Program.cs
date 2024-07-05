List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();
int contador = 0;
bool flag = true;
while (flag)
{

    Console.WriteLine(@"
1.Agregar productos al inventario
2.Cambiar datos de un producto
3.Buscar un producto por su nombre
4.Mostrar el inventario completo
5.Eliminar un producto del inventario
6.Apagar el programa");
    Console.WriteLine("Ingrese una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Console.Write("Ingrese el nombre del nuevo producto => ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del nuevo producto => ");
            string precioProducto = Console.ReadLine();
            double precioProductoI;
            bool isPrecioValido = double.TryParse(precioProducto, out precioProductoI);

            Console.Write("Ingrese la cantidad del nuevo producto => ");
            string cantidadProducto = Console.ReadLine();
            int cantidadProductoD;
            bool isCantidadValida = int.TryParse(cantidadProducto, out cantidadProductoD);

            if (!isPrecioValido || !isCantidadValida || string.IsNullOrEmpty(nombreProducto) || string.IsNullOrEmpty(precioProducto) || string.IsNullOrEmpty(cantidadProducto))
            {
                Console.WriteLine("Debes escribir correctamente los valores.");
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

            contador = 0;
            foreach (var c in productos)
            {
                contador++;
                Console.WriteLine($"{contador}. Nombre: {c["nombre"]} precio: {c["precio"]} cantidad {c["cantidad"]} {c["nombre"].GetType()}");
            }

            break;

        case 2:
            Console.WriteLine("Estos son los productos actuales");
            contador = 0;
            foreach (var c in productos)
            {
                contador++;
                Console.WriteLine($"{contador}. Nombre: {c["nombre"]} precio: {c["precio"]} cantidad {c["cantidad"]}");
            }
            Console.Write("Ingrese el indice del producto");
            int indiceProducto = Convert.ToInt16(Console.ReadLine());
            if (indiceProducto > productos.Count)
            {
                Console.WriteLine("Debes de ingresar el id de un producto dentro del rango");
                break;
            }
            else
            {
                Console.WriteLine(@"1. Nombre
            2.precio 
            3. cantidad");
                Console.Write("Ingrese el numero del elemento que desee cambiar su valor =Z");
                int elementoACambiar = Convert.ToInt16(Console.ReadLine());
                if (elementoACambiar == 1)
                {
                    Console.Write("Ingrese el nuevo nombre del producto");
                    string? nuevoNombre = Console.ReadLine();
                    productos[indiceProducto - 1]["nombre"] = nuevoNombre;
                }
                else if (elementoACambiar == 2)
                {
                    Console.Write("Ingrese el nuevo precio del producto");
                    int nuevoPrecio = Convert.ToInt16(Console.ReadLine());
                    productos[indiceProducto - 1]["precio"] = nuevoPrecio;
                }
                else if (elementoACambiar == 3)
                {
                    Console.Write("Ingrese la nueva cantidad del producto");
                    int nuevaCantidad = Convert.ToInt16(Console.ReadLine());
                    productos[indiceProducto - 1]["cantidad"] = nuevaCantidad;
                }
                else
                {
                    Console.WriteLine("Ingresa una opcion dentro del rango");
                    break;
                }
            }
            break;


        case 3:
        Console.Write("Ingrese el nombre del producto que desee encontrar=> ");
        string nombreProductoAEncontrar = Console.ReadLine().ToLower();

        for(int i = 0; i<productos.Count; i++)
        {
            if(Convert.ToString(productos[i]["nombre"]) == nombreProductoAEncontrar)
            {
                Console.WriteLine("Este es el producto que estas buscando");
                Console.WriteLine($"Nombre: {productos[i]["nombre"]} Precio: {productos[i]["precio"]} Cantidad: {productos[i]["cantidad"]}");
                break;
            }
            else
            {
                Console.WriteLine("Debes de escribir el nombre de un producto que este dentro del listado");
                break;
            }
        }
        break;


        case 4:
        Console.WriteLine("Estos son los productos actuales con su informacion detallada");
            contador = 0;
            foreach (var c in productos)
            {

                contador++;
                Console.WriteLine($"{contador}. Nombre: {c["nombre"]} precio: {c["precio"]} cantidad {c["cantidad"]}");
            }
            break;


        case 5:
            Console.WriteLine("Estos son los productos actuales");

            contador = 0;
            foreach (var c in productos)
            {

                contador++;
                Console.WriteLine($"{contador}. Nombre: {c["nombre"]} precio: {c["precio"]} cantidad {c["cantidad"]}");
            }

            Console.Write("Ingrese el numero del producto que desea eliminar");
            int idElementoAEliminar = Convert.ToInt16(Console.ReadLine());

            productos.RemoveAt(idElementoAEliminar - 1);
            break;
        case 6:
            Console.WriteLine("Adios");
            flag = false;
            break;
    }
}
