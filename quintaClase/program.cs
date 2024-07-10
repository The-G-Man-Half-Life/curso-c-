//aggregate

var numbersSum = new List<int>() {1,2,3};
int sum = numbersSum.Aggregate(1,(accumulator, current) => accumulator * current);
// Console.WriteLine(sum);

var holamundo = new List<string>() {"Hola", " ", "Mundo"};
string holaCompleto = holamundo.Aggregate((accumulate,current)=>accumulate+current);
// Console.WriteLine(holaCompleto);

var compararNumeros = new List<int>() {10,-20,30,50,-60};
int maxNumber = compararNumeros.Aggregate((accumulate,current)=>accumulate<current?  accumulate:current);
// Console.WriteLine(maxNumber);

// select Many
var nummber = new List<List<object>>(){
    new List<object>{1,2,3,4,5,6,7},
    new List<object>{"papa","pepa","antaño"},
    new List<object>{12,"papa","aguacate"}
};

// var number = nummber.SelectMany(item=>item).ToList();

// foreach (var item in number)
// {
//     Console.WriteLine(item);
// }

//metodo reverse

var listaNumerica = new List<int>() {1,2,3,4,5,6,7,9};
listaNumerica.Reverse();
// foreach (var item in listaNumerica)
// {
//     Console.WriteLine(item);
// }

// metodo max
var listaInexistente = new List<int>() {12,13,14,15,16,31};
var superNumber = listaInexistente.Max(n=>n);
// Console.WriteLine(superNumber);

//metodo skip
var listaSkip = new List<int>() {
    1,23,24,5,6,7,8,9
};
var skippedNumber = listaSkip.Skip(2);

// foreach (var item in skippedNumber)
// {
//     Console.WriteLine(item);
// }

//metodo average

var listaAverage = new List<int>() {
    1,2,3,4,5,6,7,8,9,10
};
var average = listaAverage.Average();
// Console.WriteLine(average);

//metodo select
var listaSelect = new List<int>() {
    1,2,3,4,5,6,7,8,9,10
    };
var listaSelectDividida = listaSelect.Select(number =>number/2).ToList();

foreach (var item in listaSelectDividida)
{
    Console.WriteLine(item);
}

//