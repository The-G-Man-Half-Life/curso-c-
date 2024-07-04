List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();

        Console.WriteLine("Ingrese una opción (1 para agregar producto):");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                while (true)
                {
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
                        Dictionary<string, object> producto = new Dictionary<string, object>
                        {
                            {"nombre", nombreProducto},
                            {"precio", precioProductoI},
                            {"cantidad", cantidadProductoD}
                        };

                        productos.Add(producto);

                        // Mostrar los productos agregados hasta ahora
                        Console.WriteLine("Productos agregados:");
                        foreach (var prod in productos)
                        {
                            Console.WriteLine($"Nombre: {prod["nombre"]}, Precio: {prod["precio"]}, Cantidad: {prod["cantidad"]}");
                            Console.Write(productos);
                        }

                        break;
                    }
                }
                break;

            default:
                Console.WriteLine("Escoge un número válido.");
                break;
        }

