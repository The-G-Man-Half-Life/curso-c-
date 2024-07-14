using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

List<Sale> Sales = new List<Sale>()
{
            new Sale(1, new DateTime(2023, 7, 10), "headphones", 149.99, 3, "pepe guzman", "michael brown", 0),
            new Sale(1, new DateTime(2023, 7, 10), "laptop", 1200.50, 1, "pepe guzman", "michael brown", 12),
            new Sale(1, new DateTime(2023, 7, 10), "smartphone", 899.99, 2, "pepe guzman", "michael brown", 6),
            new Sale(2, new DateTime(2023, 11, 3), "tablet", 499.95, 1, "antonio ramirez", "alice johnson", 0),
            new Sale(2, new DateTime(2023, 11, 3), "camera", 599.75, 1, "antonio ramirez", "alice johnson", 12),
            new Sale(2, new DateTime(2023, 11, 3), "printer", 299.99, 1, "antonio ramirez", "alice johnson", 0),
            new Sale(3, new DateTime(2024, 2, 5), "external hard drive", 129.50, 2, "john coltan", "bob smith", 6),
            new Sale(3, new DateTime(2024, 2, 5), "monitor", 399.00, 1, "john coltan", "bob smith", 12),
            new Sale(3, new DateTime(2024, 2, 5), "keyboard", 49.99, 3, "john coltan", "bob smith", 0),
            new Sale(4, new DateTime(2024, 11, 27), "mouse", 19.95, 5, "hernan atrato", "emma davis", 6),
            new Sale(4, new DateTime(2024, 11, 27), "speakers", 99.99, 2, "hernan atrato", "emma davis", 12),
            new Sale(4, new DateTime(2024, 11, 27), "smart watch", 299.00, 1, "hernan atrato", "emma davis", 0),
            new Sale(5, new DateTime(2024, 12, 18), "power bank", 29.50, 4, "prudencia arracacha", "david wilson", 6),
            new Sale(5, new DateTime(2024, 12, 18), "router", 79.99, 1, "prudencia arracacha", "david wilson", 12),
            new Sale(5, new DateTime(2024, 12, 18), "scanner", 199.99, 1, "prudencia arracacha", "david wilson", 0),
            new Sale(6, new DateTime(2024, 2, 24), "software", 149.95, 3, "otis otalvarez", "sophia lee", 6),
            new Sale(6, new DateTime(2024, 2, 24), "webcam", 69.50, 2, "otis otalvarez", "sophia lee", 12),
            new Sale(6, new DateTime(2024, 2, 24), "vr headset", 399.00, 1, "otis otalvarez", "sophia lee", 0),
            new Sale(7, new DateTime(2024, 6, 12), "bluetooth earphones", 59.99, 2, "dumar auto", "olivia martinez", 12),
            new Sale(7, new DateTime(2024, 6, 12), "smart thermostat", 199.00, 1, "dumar auto", "olivia martinez", 0),
            new Sale(7, new DateTime(2024, 6, 12), "drone", 499.99, 1, "dumar auto", "olivia martinez", 6),
            new Sale(8, new DateTime(2024, 7, 13), "fitness tracker", 79.95, 3, "adam smith", "james thompson", 12),
            new Sale(8, new DateTime(2024, 7, 13), "portable speaker", 129.99, 2, "adam smith", "james thompson", 0),
            new Sale(8, new DateTime(2024, 7, 13), "action camera", 299.50, 1, "adam smith", "james thompson", 6),
            new Sale(9, new DateTime(2023, 12, 10), "gaming console", 399.00, 1, "beatriz vergara", "ethan harris", 12),
            new Sale(9, new DateTime(2023, 12, 10), "e-book reader", 129.00, 2, "beatriz vergara", "ethan harris", 0),
            new Sale(9, new DateTime(2023, 12, 10), "smart doorbell", 149.99, 1, "beatriz vergara", "ethan harris", 6),
            new Sale(10, new DateTime(2023, 7, 4), "robot vacuum", 299.95, 1, "jose miguel", "noah hernandez", 12),
            new Sale(10, new DateTime(2023, 7, 4), "electric scooter", 699.00, 1, "jose miguel", "noah hernandez", 0),
            new Sale(10, new DateTime(2023, 7, 4), "digital photo frame", 89.99, 4, "jose miguel", "noah hernandez", 6),
            new Sale(11, new DateTime(2023, 7, 4), "digital photo frame", 600000, 20, "michael brown", "patria hernandez", 6)
};


string tacticalSpace =
@"                                                                               
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                                                                                ";

bool bandera = true;
while (bandera == true)
{
    //menu

    Console.WriteLine
(
@"
--------------------------------------------------------------------------
|   1. Permitir registrar nuevas ventas en una lista o otra estructura    |
|   de datos si desean intentarlo.
|   
|   2. Desarrollar funcion para calcular el valor total de una venta 
|   específica.
|   
|   3. Desarrollar funcion para calcular el promedio de ventas diarias
|   
|   4. Mostrar el empleado del Mes (empleado que tenga las mejores ventas)
|   
|   5. Mostrar el cliente del Mes (cliente que haya comprado mas)
|   
|   6. Filtrar una lista de ventas para obtener todas las ventas realizadas
|   después de una fecha específica.
|   
|   7. Seleccionar los nombres de los vendedores que realizaron ventas por 
|   encima de cierto valor.
|   
|   8. Agrupar las ventas por mes y calcular el total de ventas mensuales.
|   
|   9. Encontrar el vendedor con el mayor número de ventas en un período 
|   específico.
|   
|   10. Ordenar las ventas por valor total descendente y mostrar las 
|   primeras N ventas.
|   
|   11. Encontrar los productos más vendidos por cantidad en un año 
|   determinado.
|   
|   12. Validar si existe alguna venta con un valor específico.
|   
|   13. Buscar todas las ventas realizadas a un cliente específico.
|   
|   14. Calcular el total de ventas para cada vendedor y mostrar el promedio
|   de ventas por vendedor.
|   
|   15. Encontrar el mes con el mayor número de ventas y mostrar las ventas
|   de ese mes.
|
|   16. Mostrar todas las compras.
-------------------------------------------------------------------------------
");

    Console.WriteLine(tacticalSpace);
    Console.Write("Ingrese un numero para ejecutar una opcion:");
    string? takenOption = Console.ReadLine();

    int takenOptionG;
    bool Convertion = int.TryParse(takenOption, out takenOptionG);

    if (Convertion == true && takenOptionG <= 16 && takenOptionG >= 1)
    {
        Clear();

        switch (takenOptionG)
        {
            case (1):
                RegisterNewSale(Sales);
                break;
            case (2):
                ToSeeTotalSalesValueSell(Sales);
                break;
            case (3):
                ToCalculateAverageSalesByDay(Sales);
                break;
            case (4):
                ToShowTheMostValuableEmployee(Sales);
                break;
            case (5):
                ToShowTheMostValuableShopper(Sales);
                break;
            case (6):
                break;
            case (7):
                break;
            case (8):
                break;
            case (9):
                break;
            case (10):
                break;
            case (11):
                break;
            case (12):
                break;
            case (13):
                break;
            case (14):
                break;
            case (15):
                break;
            case (16):
                ToShowProducts(Sales);
                break;
        }
    }

    else
    {
        Clear();
        Console.WriteLine("Debes de escrbir un termino valido");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("presione cualquier tecla para continuar");
        Console.ReadKey();
    }


    //funciones
    void Clear()
    {
        Console.Clear();
    }

    void RegisterNewSale(List<Sale> list)
    {
        int lastId = Sales[Sales.Count - 1].Id;
        int newId = lastId + 1;
        bool wantsToKeepBuying = true;

        Console.WriteLine(tacticalSpace);
        Console.Write("Ingrese la fecha de su compra(YYYY/MM/DD):");
        string? newDate = Console.ReadLine();
        DateTime newDateG;
        bool convertToDateTime = DateTime.TryParse(newDate, out newDateG);

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese el nombre del producto:");
        string? newProductName = Console.ReadLine();

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese el valor del producto:");
        string? newProductValue = Console.ReadLine();
        double newProductValueG;
        bool convertToDouble = double.TryParse(newProductValue, out newProductValueG);

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese la cantidad del producto:");
        string? newProductAmount = Console.ReadLine();
        int newProductAmountG;
        bool convertToInt = int.TryParse(newProductAmount, out newProductAmountG);

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese el nombre del vendedor del producto:");
        string? newsellerName = Console.ReadLine();

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese su nombre por favor: ");
        string? newBuyerName = Console.ReadLine();

        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese el tiempo de garantia del producto: ");
        string? newProductWarranty = Console.ReadLine();
        int newProductWarrantyG;
        bool convertToInt2 = int.TryParse(newProductWarranty, out newProductWarrantyG);


        if ((convertToDateTime == true) && (string.IsNullOrWhiteSpace(newProductName) == false) && (convertToDouble == true) && (convertToInt == true) && (string.IsNullOrWhiteSpace(newsellerName) == false) && (string.IsNullOrWhiteSpace(newBuyerName) == false) && (convertToInt2 == true))
        {
            Sales.Add(new Sale(newId, newDateG, newProductName, newProductValueG, newProductAmountG, newsellerName, newBuyerName, newProductWarrantyG));
            Clear();

            Console.WriteLine("Venta registrada exitosamente");

            Console.WriteLine(tacticalSpace);


            while (true)
            {
                Console.Write("¿Quieres seguir comprando? (si, no)");
                string? inputWantsToKeepBuying = Console.ReadLine().ToLower();

                Console.WriteLine(tacticalSpace);

                if (inputWantsToKeepBuying == "si")
                {
                    Clear();
                    Console.Write("Ingrese el nombre del producto:");
                    string? newProductName2 = Console.ReadLine();

                    Console.WriteLine(tacticalSpace);

                    Console.Write("Ingrese el valor del producto:");
                    string? newProductValue2 = Console.ReadLine();
                    double newProductValue2G;
                    bool convertToDouble2 = double.TryParse(newProductValue2, out newProductValue2G);

                    Console.WriteLine(tacticalSpace);

                    Console.Write("Ingrese la cantidad del producto:");
                    string? newProductAmount2 = Console.ReadLine();
                    int newProductAmount2G;
                    bool convertToInt2G = int.TryParse(newProductAmount2, out newProductAmount2G);

                    Console.WriteLine(tacticalSpace);

                    Console.Write("Ingrese el tiempo de garantia del producto: ");
                    string? newProductWarranty2 = Console.ReadLine();
                    int newProductWarranty2G;
                    bool convertToInt3G = int.TryParse(newProductWarranty2, out newProductWarranty2G);

                    Sales.Add(new Sale(newId, newDateG, newProductName2, newProductValue2G, newProductAmount2G, newsellerName, newBuyerName, newProductWarranty2G));

                    Console.WriteLine(tacticalSpace);
                }

                else if (inputWantsToKeepBuying == "no")
                {
                    Clear();
                    break;
                }

                else
                {
                    Clear();
                    Console.WriteLine("Debes de escribir un valor valido");
                    Console.WriteLine(tacticalSpace);
                }
            }

        }

        else
        {
            Console.WriteLine("Alguno de los valores ingresados es erroneo vuelva a intentarlo");
        }
    }

    void ToSeeTotalSalesValueSell(List<Sale> list)
    {
        var uniqueId = list.DistinctBy(item => item.Id).ToList();

        Clear();

        Console.WriteLine
        (
        @"___________
|    ID   |
-----------"
        );

        foreach (var item in uniqueId)
        {
            Console.WriteLine
            (
            @$"|     {item.Id,-4}|
|_________|"
            );
        }
        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese el numero de la venta: ");
        string? idSelected = Console.ReadLine();
        int idSelectedG;
        bool ConversionToInt = int.TryParse(idSelected, out idSelectedG);

        if (string.IsNullOrWhiteSpace(idSelected) == true || ConversionToInt == false || uniqueId.Count() < idSelectedG)
        {
            Clear();
            Console.WriteLine("El valor ingresado es erroneo");
            Console.WriteLine(tacticalSpace);
            Console.Write("Ingrese cualquier letra para continuar:");
            Console.ReadKey();
        }
        else
        {
            var elementsOfTheSale = list.Where(sale => sale.Id == idSelectedG);

            double totalValueSale = 0;

            foreach (var item in elementsOfTheSale)
            {
                totalValueSale = totalValueSale + (item.ProductValue * item.ProductAmount);
            }

            Console.WriteLine(tacticalSpace);
            Console.WriteLine($"El precio de la venta {idSelectedG} es: {totalValueSale}$");
            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }

    void ToCalculateAverageSalesByDay(List<Sale> list)
    {
        Console.WriteLine(tacticalSpace);
        Console.Write("Ingrese una fecha(YYYY/MM/DD):");
        string? requestedDate = Console.ReadLine();
        DateTime requestedDateG;
        bool couldItBeTransformedToDateTime = DateTime.TryParse(requestedDate, out requestedDateG);

        bool DoesDateMatch = list.Any(date => date.SaleDate == requestedDateG);

        if (couldItBeTransformedToDateTime == false || string.IsNullOrWhiteSpace(requestedDate) || DoesDateMatch == false)
        {
            Clear();
            Console.WriteLine("El valor ingresado es erroneo");
            Console.WriteLine(tacticalSpace);
            Console.Write("Ingrese cualquier letra para continuar:");
            Console.ReadKey();
        }
        else
        {
            var salesInSameDay = list.Where(date => date.SaleDate == requestedDateG).ToList();

            double totalCashOfTheDay = 0;
            foreach (var item in salesInSameDay)
            {

                totalCashOfTheDay = totalCashOfTheDay + (item.ProductValue * item.ProductAmount);

            }

            int totalAmountOfCostumers = salesInSameDay.DistinctBy(item => item.Id).Count();

            double averageAmountOfCashInTheDay = totalCashOfTheDay / totalAmountOfCostumers;

            Console.WriteLine(tacticalSpace);

            Console.WriteLine($"El promedio de las ventas el dia {requestedDateG.ToString("yyyy/MM/dd")} fue: {averageAmountOfCashInTheDay}$");

            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            Clear();
        }
    }

    void ToShowTheMostValuableEmployee(List<Sale> list)
    {
        Clear();
        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese la fecha Inicial(YYYY/MM/DD): ");
        string? date2 = Console.ReadLine();
        DateTime date2G;
        bool couldItBeTransformedToDate = DateTime.TryParse(date2, out date2G);

        Console.Write("Ingrese la fecha final(YYYY/MM/DD): ");
        string? date3 = Console.ReadLine();
        DateTime date3G;
        bool couldItBeTransformedToDate2 = DateTime.TryParse(date3, out date3G);

        var employeesInDateRange = list.Where(date => date.SaleDate <= date3G && date.SaleDate >= date2G).ToList();

        if (couldItBeTransformedToDate == false || couldItBeTransformedToDate2 == false || string.IsNullOrWhiteSpace(date2) == true || employeesInDateRange.Count == 0)
        {
            Clear();
            Console.WriteLine("El valor ingresado es erroneo");
            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(tacticalSpace);
            var EmployeesMadeCash = employeesInDateRange
            .GroupBy(employee => employee.Seller)
            .Select(group => new
            {
                Seller = group.Key,
                TotalSales = group.Sum(employee => employee.ProductAmount * employee.ProductValue)
            }).OrderByDescending(result => result.TotalSales);

            int count = 1;

            Console.WriteLine($"Este es el ranking de los vendedores entre {date2G.ToString("yyyy/MM/dd")} y {date3G.ToString("yyyy/MM/dd")}:");

            Console.WriteLine(
@$"__________________________________________________________
| Rank |         Seller           |     Cash obtained     |
|_________________________________________________________|"
            );

            foreach (var item in EmployeesMadeCash)
            {
                Console.WriteLine(
    @$"|  {count,-4}|  {item.Seller,-24}|  {item.TotalSales,-21}|"
    );
                count++;
            }

            Console.WriteLine(
            @$"|_________________________________________________________|");

            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
    }

    void ToShowTheMostValuableShopper(List<Sale> list)
    {
        Clear();
        Console.WriteLine(tacticalSpace);

        Console.Write("Ingrese la fecha Inicial(YYYY/MM/DD): ");
        string? date2 = Console.ReadLine();
        DateTime date2G;
        bool couldItBeTransformedToDate = DateTime.TryParse(date2, out date2G);

        Console.Write("Ingrese la fecha final(YYYY/MM/DD): ");
        string? date3 = Console.ReadLine();
        DateTime date3G;
        bool couldItBeTransformedToDate2 = DateTime.TryParse(date3, out date3G);

        var shopperInDateRange = list.Where(date => date.SaleDate <= date3G && date.SaleDate >= date2G).ToList();

        if (couldItBeTransformedToDate == false || couldItBeTransformedToDate2 == false || string.IsNullOrWhiteSpace(date2) == true || shopperInDateRange.Count == 0)
        {
            Clear();
            Console.WriteLine("El valor ingresado es erroneo");
            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine(tacticalSpace);
            var shoppersSpentCash = shopperInDateRange
            .GroupBy(shopper => shopper.Buyer)
            .Select(group => new
            {
                Buyer = group.Key,
                TotalBuys = group.Sum(shopper => shopper.ProductAmount * shopper.ProductValue)
            }).OrderByDescending(result => result.TotalBuys);

            int count = 1;

            Console.WriteLine($"Este es el ranking de los Compradores entre {date2G.ToString("yyyy/MM/dd")} y {date3G.ToString("yyyy/MM/dd")}:");

            Console.WriteLine(
@$"__________________________________________________________
| Rank |         Buyer            |     Cash spent        |
|_________________________________________________________|"
            );

            foreach (var item in shoppersSpentCash)
            {
                Console.WriteLine(
    @$"|  {count,-4}|  {item.Buyer,-24}|  {item.TotalBuys,-21}|"
    );
                count++;
            }

            Console.WriteLine(
            @$"|_________________________________________________________|");

            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
    }


    void ToShowProducts(List<Sale> list)
    {
        Clear();
        Console.WriteLine("Aqui estan las ventas actuales");
        Console.WriteLine
        (
@"
______________________________________________________________________________________________________
|                                                                                                    |
|____________________________________________________________________________________________________|"
        );

        foreach (var item in list)
        {
            Console.WriteLine
            (
@$"|{item.Id,-4}|{item.SaleDate.ToString("yyyy-MM-dd"),-12}|{item.ProductName,-20}|{item.ProductValue,-10}|{item.ProductAmount,-4}|{item.Seller,-20}|{item.Buyer,-20}|{item.WarrantyTime,-4}|"
            );
        }

        Console.WriteLine
        (
@"|_____________________________________________________________________________________________________|
"
        );

        Console.Write("Presine cualquier letra para continuar:");
        Console.ReadKey();
    }
}


