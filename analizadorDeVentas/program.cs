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
            new Sale(11, new DateTime(2023, 7, 4), "digital photo frame", 600000, 20, "pepe guzman", "patria hernandez", 6)
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
@"------------------------------------MENU----------------------------------
|   1. Permitir registrar nuevas ventas en una lista o otra estructura   |
|   de datos si desean intentarlo.                                       |
|                                                                        |
|   2. Desarrollar funcion para calcular el valor total de una venta     |
|   específica.                                                          |
|                                                                        |
|   3. Desarrollar funcion para calcular el promedio de ventas diarias   |
|                                                                        |
|   4. Mostrar el empleado del Mes                                       |
|                                                                        |
|   5. Mostrar el cliente del Mes                                        |
|                                                                        |
|   6. Filtrar una lista de ventas para obtener todas las ventas         |
|   realizadas después de una fecha específica.                          |
|                                                                        |
|   7. Seleccionar los nombres de los vendedores que realizaron ventas   |
|   por encima de cierto valor.                                          |
|                                                                        |
|   8. Agrupar las ventas por mes y calcular el total de ventas          |
|   mensuales.                                                           |
|                                                                        |
|   9. Encontrar el vendedor con el mayor número de ventas en un período |
|   específico.                                                          |
|                                                                        |
|   10. Ordenar las ventas por valor total descendente y mostrar las     |
|   primeras N ventas.                                                   |
|                                                                        |
|   11. Encontrar los productos más vendidos por cantidad en un año      |
|   determinado.                                                         |
|                                                                        |
|   12. Validar si existe alguna venta con un valor específico.          |
|                                                                        |
|   13. Buscar todas las ventas realizadas a un cliente específico.      |
|                                                                        |
|   14. Calcular el total de ventas para cada vendedor y mostrar el      |
|   promedio de ventas por vendedor.                                     |
|                                                                        |
|   15. Ver mes con mayor numero de ventas y sus ventas.                 |
|                                                                        |
|   16. Mostrar todas las compras.                                       |
|________________________________________________________________________|
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
                ToShowSalesAfterASpecificDate(Sales);
                break;
            case (7):
                ToShowSellersWithCertainAmountOfMadeCash(Sales);
                break;
            case (8):
                ToShowSalesByMonth(Sales);
                break;
            case (9):
                ToShowTheBestSellerInAPeriodOfTime(Sales);
                break;
            case (10):
                OrderAllSalesAndShowTheFirstNSales(Sales);
                break;
            case (11):
                FindMostBoughtProductsByYear(Sales);
                break;
            case (12):
                FindPurchaseForAnExactPrice(Sales);
                break;
            case (13):
                FindPurchasesFromAnExactCostumer(Sales);
                break;
            case (14):
                TotalAmountOfCashForSellerAndAverage(Sales);
                break;
            case (15):
                FindMonthWithTheBiggestAmountOfSales(Sales);
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

    if (string.IsNullOrWhiteSpace(idSelected) == true || ConversionToInt == false || uniqueId.Count < idSelectedG)
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

void ToShowSalesAfterASpecificDate(List<Sale> list)
{
    Clear();

    Console.Write("Ingrese una fecha para ver todas las compras realizadas:");
    string? date = Console.ReadLine();
    DateTime dateG;
    bool couldItBeTransformedToDate = DateTime.TryParse(date, out dateG);

    var SalesAfterThatDay = list.Where(sale => sale.SaleDate >= dateG);

    if (couldItBeTransformedToDate == false || string.IsNullOrWhiteSpace(date) == true || SalesAfterThatDay.Count() == 0)
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
        Console.WriteLine($"Estas son todas las ventas despues del {dateG}");
        Console.WriteLine
        (
@"
______________________________________________________________________________________________________
|                                                                                                    |
|____________________________________________________________________________________________________|"
        );

        foreach (var item in SalesAfterThatDay)
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

void ToShowSellersWithCertainAmountOfMadeCash(List<Sale> list)
{
    Clear();
    Console.WriteLine(tacticalSpace);

    Console.Write("Ingrese la cantidad de dinero sin puntos ni comas: ");
    string? amountOfCash = Console.ReadLine();
    double amountOfCashG;
    bool couldItBeTransformedToDouble = double.TryParse(amountOfCash, out amountOfCashG);

    var employeesWithAmountOfCash = list
    .GroupBy(employee => employee.Seller)
    .Select(group => new
    {
        Seller = group.Key,
        TotalSales = group.Sum(employee => employee.ProductAmount * employee.ProductValue)
    })
    .Where(seller => seller.TotalSales > amountOfCashG)
    .OrderByDescending(result => result.TotalSales);

    if (couldItBeTransformedToDouble == false || string.IsNullOrWhiteSpace(amountOfCash) == true || employeesWithAmountOfCash.Count() == 0)
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

        int count = 1;

        Console.WriteLine($"Este es el ranking de los vendedores que hicieron mas de {amountOfCashG}$:");

        Console.WriteLine(
@$"__________________________________________________________
| Rank |         Seller           |     Cash obtained     |
|_________________________________________________________|"
        );

        foreach (var item in employeesWithAmountOfCash)
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

void ToShowSalesByMonth(List<Sale> list)
{
    var monthlySales = Sales
.GroupBy(sale => new { sale.SaleDate.Year, sale.SaleDate.Month })
.Select(group => new
{
    Year = group.Key.Year,
    Month = group.Key.Month,
    TotalSalesValue = group.Sum(sale => sale.ProductValue * sale.ProductAmount)
})
.OrderBy(result => result.Year)
.ThenBy(result => result.Month)
.ToList();

    foreach (var month in monthlySales)
    {
        Console.WriteLine($"Year: {month.Year}, Month: {month.Month}, Total Sales Value: {month.TotalSalesValue:C}");
    }
}

void ToShowTheBestSellerInAPeriodOfTime(List<Sale> list)
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

void OrderAllSalesAndShowTheFirstNSales(List<Sale> list)
{
    Clear();
    Console.WriteLine(tacticalSpace);

    Console.Write("Ingrese (1) para ver las ventas Ascendentes o (2) para verlas de manera descendente: ");
    string? order = Console.ReadLine();
    int orderG;
    bool couldItBeTransformedToInt = int.TryParse(order, out orderG);

    Console.Write("Ingrese la cantidad de ventas que desea ver: ");
    string? takeHowMuch = Console.ReadLine();
    int takeHowMuchG;
    bool couldItBeTransformedToInt2 = int.TryParse(takeHowMuch, out takeHowMuchG);

    Console.WriteLine(tacticalSpace);

    var Sales = list
    .GroupBy(shopper => shopper.Id)
    .Select(group => new
    {
        Id = group.First().Id,
        Buyer = group.First().Buyer,
        TotalBuys = group.Sum(shopper => shopper.ProductAmount * shopper.ProductValue),
    });

    if (couldItBeTransformedToInt == false || couldItBeTransformedToInt2 == false || string.IsNullOrWhiteSpace(takeHowMuch) == true || (orderG > 2 && orderG < 1))
    {
        Clear();
        Console.WriteLine("Uno de los valores ingresados es erroneo");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }

    else if (orderG == 1)
    {
        var listAscendant = Sales.OrderBy(item => item.TotalBuys).Take(takeHowMuchG);

        Console.WriteLine($"Este es el ranking de las mayores ventas de menor a mayor:");

        Console.WriteLine(
@$"__________________________________________________________
|  ID  |         Buyer            |     Cash spent        |
|_________________________________________________________|"
        );

        foreach (var item in listAscendant)
        {
            Console.WriteLine(
@$"|  {item.Id,-4}|  {item.Buyer,-24}|  {item.TotalBuys,-21}|"
);

        }

        Console.WriteLine(
        @$"|_________________________________________________________|");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }
    else
    {
        var listDescendant = Sales.OrderByDescending(item => item.TotalBuys).Take(takeHowMuchG);

        Console.WriteLine($"Este es el ranking de las mayores ventas de mayor a menor:");

        Console.WriteLine(
@$"__________________________________________________________
|  ID  |         Buyer            |     Cash spent        |
|_________________________________________________________|"
        );

        foreach (var item in listDescendant)
        {
            Console.WriteLine(
@$"|  {item.Id,-4}|  {item.Buyer,-24}|  {item.TotalBuys,-21}|"
);
        }

        Console.WriteLine(
        @$"|_________________________________________________________|");

        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();

    }
}

void FindMostBoughtProductsByYear(List<Sale> list)
{
    Clear();
    Console.WriteLine(tacticalSpace);

    Console.Write("Ingrese el año:");
    string? year = Console.ReadLine();
    int yearG;
    bool couldItBeTransformedToInt = int.TryParse(year, out yearG);

    var productInDateRange = list.Where(date => date.SaleDate >= new DateTime(yearG, 01, 01) && date.SaleDate <= new DateTime(yearG, 12, 31)).ToList();

    if (couldItBeTransformedToInt == false || string.IsNullOrWhiteSpace(year) == true || productInDateRange.Count == 0)
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
        var productAmountinOrder = productInDateRange
        .GroupBy(product => product.ProductName)
        .Select(group => new
        {
            Product = group.First().ProductName,
            TotalAmount = group.Sum(product => product.ProductAmount),
            TotalBuys = group.Sum(shopper => shopper.ProductAmount * shopper.ProductValue)
        }).OrderByDescending(result => result.TotalAmount);

        int count = 1;

        Console.WriteLine($"Este es el ranking de los productos mas comprados en {yearG}:");

        Console.WriteLine(
@$"
_____________________________________________________________________
| Rank |           Buyer          |  Amount |      Cash spent       |
|______|__________________________|_________|_______________________|"
        );

        foreach (var item in productAmountinOrder)
        {
            Console.WriteLine(
@$"|  {count,-4}|  {item.Product,-24}|  {item.TotalAmount,-7}|  {item.TotalBuys,-21}|"
);
            count++;
        }

        Console.WriteLine(
        @$"|___________________________________________________________________|");

        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }

}

void FindPurchaseForAnExactPrice(List<Sale> list)
{
    Console.WriteLine(tacticalSpace);

    Console.Write("Ingrese el valor de la compra para saber si existe: ");
    string? price = Console.ReadLine();
    double priceG;
    bool couldItBeTransformedToDouble = double.TryParse(price, out priceG);

    var matchingSales = list.GroupBy(sale => sale.Id)
    .Select(group => new
    {
        Id = group.First().Id,
        CashOfTheSale = group.Sum(group => group.ProductAmount * group.ProductValue)
    })
    .Where(group => group.CashOfTheSale == priceG)
    .OrderBy(group => group.Id);

    if (couldItBeTransformedToDouble == false || String.IsNullOrWhiteSpace(price))
    {
        Clear();
        Console.WriteLine("Uno de los valores ingresados es erroneo");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }
    else if (matchingSales.Count() == 0)
    {
        Clear();
        Console.WriteLine("El valor ingresado no corresponde al valor de ninguna venta en la base de datosd");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }
    else
    {
        Clear();
        Console.WriteLine($"Aqui estan las ventas que tienen un valor de {priceG}$");

        Console.WriteLine(
@$"________________________________
|  ID  |     Cash obtained     |
|______________________________|"
        );

        foreach (var item in matchingSales)
        {
            Console.WriteLine
(
@$"|  {item.Id,-4}|  {item.CashOfTheSale,-21}|"
);
        }

        Console.WriteLine(
@$"|______________________________|");

        Console.WriteLine(tacticalSpace);
        Console.Write("Ingrese el ID de la venta para saber todos los detalles de la venta:");

        string? selectedId = Console.ReadLine();
        int selectedIdG;
        bool couldItBeTransformedToInt = int.TryParse(selectedId, out selectedIdG);

        bool matchingId = matchingSales.Any(id => id.Id == selectedIdG);

        if (string.IsNullOrWhiteSpace(selectedId) || couldItBeTransformedToInt == false || matchingId == false)
        {
            Clear();
            Console.WriteLine("El valor ingresado es errone o no esta en la tabla");
            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
        else
        {
            var SpecificSale = list.Where(sale => sale.Id == selectedIdG);

            Clear();
            Console.WriteLine($"Aqui estan las ventas actuales del id: {selectedIdG}");
            Console.WriteLine
            (
    @"
_______________________________________________________________________________________________________
| ID |    Date    |        Name        |   Name   |Quan|        Seller      |        Buyer       | WT |
|____|____________|____________________|__________|____|____________________|____________________|____|"
            );

            foreach (var item in SpecificSale)
            {
                Console.WriteLine
                (
    @$"|{item.Id,-4}|{item.SaleDate.ToString("yyyy-MM-dd"),-12}|{item.ProductName,-20}|{item.ProductValue,-10}|{item.ProductAmount,-4}|{item.Seller,-20}|{item.Buyer,-20}|{item.WarrantyTime,-4}|"
                );
            }

            Console.WriteLine
            (
    @"|____|____________|____________________|__________|____|____________________|____________________|____|
"
            );
            Console.WriteLine(tacticalSpace);
            Console.Write("Presine cualquier letra para continuar:");
            Console.ReadKey();
        }
    }
}

void FindPurchasesFromAnExactCostumer(List<Sale> list)
{
    Console.WriteLine(tacticalSpace);

    Console.Write("Ingrese el nombre del comprador: ");
    string? buyerName = Console.ReadLine();

    var matchingIds = list.GroupBy(sale => sale.Buyer)
    .Select(group => new
    {
        Id = group.First().Id,
        Buyer = group.First().Buyer,
        CashOfTheSale = group.Sum(group => group.ProductAmount * group.ProductValue)
    }).Where(buyer => buyer.Buyer == buyerName)
    .OrderBy(group => group.Id);

    if (String.IsNullOrWhiteSpace(buyerName))
    {
        Clear();
        Console.WriteLine("Uno de los valores ingresados es erroneo");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }
    else if (matchingIds.Count() == 0)
    {
        Clear();
        Console.WriteLine("La persona ingresada no existe");
        Console.WriteLine(tacticalSpace);
        Console.WriteLine("Presione un boton cualquiera para seguir");
        Console.ReadKey();
    }
    else
    {
        Clear();
        Console.WriteLine(tacticalSpace);
        Console.WriteLine($"Aqui estan las ventas que pertenecen a {buyerName}$");

        Console.WriteLine(
@$"________________________________
|  ID  |     Cash obtained     |
|______________________________|"
        );

        foreach (var item in matchingIds)
        {
            Console.WriteLine
(
@$"|  {item.Id,-4}|  {item.CashOfTheSale,-21}|"
);
        }

        Console.WriteLine(
@$"|______________________________|");

        Console.WriteLine(tacticalSpace);
        Console.Write("Ingrese el ID de la venta para saber todos los detalles de esa venta:");

        string? selectedId = Console.ReadLine();
        int selectedIdG;
        bool couldItBeTransformedToInt = int.TryParse(selectedId, out selectedIdG);

        bool matchingId = matchingIds.Any(id => id.Id == selectedIdG);

        if (string.IsNullOrWhiteSpace(selectedId) || couldItBeTransformedToInt == false || matchingId == false)
        {
            Clear();
            Console.WriteLine("El valor ingresado es errone o no esta en la tabla");
            Console.WriteLine(tacticalSpace);
            Console.WriteLine("Presione un boton cualquiera para seguir");
            Console.ReadKey();
        }
        else
        {
            var SpecificSale = list.Where(sale => sale.Id == selectedIdG);

            Clear();
            Console.WriteLine($"Aqui estan las ventas actuales del id: {selectedIdG}");
            Console.WriteLine
            (
    @"
_______________________________________________________________________________________________________
| ID |    Date    |        Name        |   Name   |Quan|        Seller      |        Buyer       | WT |
|____|____________|____________________|__________|____|____________________|____________________|____|"
            );

            foreach (var item in SpecificSale)
            {
                Console.WriteLine
                (
    @$"|{item.Id,-4}|{item.SaleDate.ToString("yyyy-MM-dd"),-12}|{item.ProductName,-20}|{item.ProductValue,-10}|{item.ProductAmount,-4}|{item.Seller,-20}|{item.Buyer,-20}|{item.WarrantyTime,-4}|"
                );
            }

            Console.WriteLine
            (
    @"|____|____________|____________________|__________|____|____________________|____________________|____|
"
            );
            Console.WriteLine(tacticalSpace);
            Console.Write("Presine cualquier letra para continuar:");
            Console.ReadKey();
        }

    }
}

void TotalAmountOfCashForSellerAndAverage(List<Sale> list)
{
    Console.WriteLine(tacticalSpace);

    var matchingSellers = list.GroupBy(sale => sale.Buyer)
    .Select(group => new
    {
        Id = group.First().Id,
        Seller = group.First().Seller,
        CashOfTheSale = group.Sum(group => group.ProductAmount * group.ProductValue),
        AmountOfSales = group.DistinctBy(sale => sale.Id).Count()
    }).OrderBy(group => group.Id);

    var matchingSales = matchingSellers.GroupBy(sale => sale.Seller)
    .Select(group => new
    {
        Seller = group.First().Seller,
        TotalCash = group.Sum(cash => cash.CashOfTheSale),
        AmountOfSales = group.Sum(amount => amount.AmountOfSales),
    }).OrderBy(group => group.Seller);

    foreach (var item in matchingSales)
    {
        Console.WriteLine(item.Seller);
        Console.WriteLine(item.TotalCash);
        Console.WriteLine(item.AmountOfSales);
    }


    Clear();
    Console.WriteLine($"Aqui estan las ventas actuales de los vendedores");
    Console.WriteLine
    (
@"
_____________________________________________________________________________________________________________
|            Name           |    TotalCash Made    |      AmountOfSales    |       Average cash Made        |
|___________________________|______________________|_______________________|________________________________|"
    );

    foreach (var item in matchingSales)
    {
        Console.WriteLine
        (
@$"|  {item.Seller,-25}|  {item.TotalCash,-20}|  {item.AmountOfSales,-21}|  {item.TotalCash / item.AmountOfSales,-30}|"
        );
    }

    Console.WriteLine
    (
@"|___________________________|______________________|_______________________|________________________________|
"
    );
    Console.WriteLine(tacticalSpace);
    Console.Write("Presine cualquier letra para continuar:");
    Console.ReadKey();
}

void FindMonthWithTheBiggestAmountOfSales(List<Sale> list)
{
    var salesByMonth = Sales
            .GroupBy(sale => new { sale.SaleDate.Year, sale.SaleDate.Month })
            .Select(group => new
            {
                Year = group.Key.Year,
                Month = group.Key.Month,
                SalesCount = group.Count(),
                Sales = group.ToList()
            })
            .OrderByDescending(result => result.SalesCount)
            .FirstOrDefault();

    Console.WriteLine($"Mes con la mayor cantidad de ventas: {salesByMonth.Year}-{salesByMonth.Month}");
    Console.WriteLine(tacticalSpace);
    Console.WriteLine("Ventas en este mes:");
    Console.WriteLine
(
@$"_______________________________________________________________________________________________________
| ID |    Date    |        Name        |   Name   |Quan|        Seller      |        Buyer       | WT |
|____|____________|____________________|__________|____|____________________|____________________|____|"
);

    foreach (var item in salesByMonth.Sales)
    {
        Console.WriteLine(

@$"|{item.Id,-4}|{item.SaleDate.ToString("yyyy-MM-dd"),-12}|{item.ProductName,-20}|{item.ProductValue,-10}|{item.ProductAmount,-4}|{item.Seller,-20}|{item.Buyer,-20}|{item.WarrantyTime,-4}|"
    );

    }
    Console.WriteLine
        (
@"|____|____________|____________________|__________|____|____________________|____________________|____|
"
        );
    Console.WriteLine(tacticalSpace);
    Console.Write("Presine cualquier letra para continuar:");
    Console.ReadKey();

}

void ToShowProducts(List<Sale> list)
{
    Clear();
    Console.WriteLine(tacticalSpace);
    Console.WriteLine("Aqui estan las ventas actuales");
    Console.WriteLine
    (
@"_______________________________________________________________________________________________________
| ID |    Date    |        Name        |   Name   |Quan|        Seller      |        Buyer       | WT |
|____|____________|____________________|__________|____|____________________|____________________|____|"
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
    Console.WriteLine(tacticalSpace);
    Console.Write("Presine cualquier letra para continuar:");
    Console.ReadKey();
}