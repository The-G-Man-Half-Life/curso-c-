// //variables
// /*
// cadenas de caracteres(string-char)
// numericos(int,double,float,byte,long,decimal)
// booleanos(true,false)
// */

// using System.ComponentModel;

// char no = 'H';
// Console.WriteLine(no.GetType().Name);


// var furtas = new string[]{
//     "banano",
//     "pera",
//     "sandia"
// };



// Console.WriteLine(furtas.GetType().Name);
// Console.WriteLine(furtas[1].GetType().Name);

// // Lista de frutas

// var frutasList = new List<string>(){
//     "manzana",
//     "naranja",
//     "uva",

// };

//lista con numeros del 1 al 10 en desorden
using System.Runtime.CompilerServices;
using System.Transactions;

var numeros = new List<byte>{10,9,8,7,6,5,4,3,2,1}; 

//array con numeros en desorden del 1 al 10 
var numerosArray = new byte[] {10,9,8,7,6,5,4,3,2,1};

//recorre la lista 
// foreach(var item in numeros)
// {
//     Console.WriteLine(item);
// }

//recorrer el array
// foreach(var item in numerosArray)
// {
//     if(item%2 == 0)
//     {
//         Console.WriteLine(item);
//     }
// }

//lista vacia en donde se van a guardar solo los numeros pares
// var numerosPares = new List<byte>();

//añadir elementos a mi lista
// foreach(var item in numerosArray)
// {
//     if (item%2 == 0)
//     {
//         numerosPares.Add(item);
//     }
// }
// foreach (var item in numerosPares)
// {
//     Console.WriteLine(item);
// }

//numeros pares usando LINQ
var numerosParesArray = numerosArray.Where(item=> item%2 == 0).ToList();
// foreach(var item in numerosParesArray)
// {
//     Console.WriteLine(item);
// }

// duplicar los numeros
var numerosDuplicados = numerosArray.Select(item=> item*2).ToArray();
Console.WriteLine(numerosDuplicados.GetType().Name);
// foreach(var item in numerosDuplicados)
// {
//     Console.WriteLine(item);
// }

// ubicar numeros de manera ascendente y descendente
var numerosParesArrayAsc = numerosArray.Where(item=>item%2 == 0).OrderBy(item=>item).ToList();
// foreach (var item in numerosParesArrayAsc)
// {
//     Console.WriteLine(item);
// }

var randomNumbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};

var squaredRandomNumbers = randomNumbers.Aggregate(0,(accumulator, current) => current + (current * current));

var nummber = new List<List<object>>() {
    new List<string>(){
        "mama","papa","patricio estrella"
    },
    new List<int>() {
        1,2,3,4,5,6,7
    }
};

nummber.Add(
    new List<int>(){
        1,2,3,4,5,6,7
    }
);

Console.WriteLine(nummber[1][1]);