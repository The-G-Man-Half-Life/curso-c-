//1
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

var lista1 = new List<int>() {
    1,2,3,4,5,6,7,50,52
};

var lista1S = lista1.Where(numero =>numero>10);
//2
var lista2 = new List<int>() {
    1,2,3,4,5,6,7,8,9,0
};

var lista2S = lista2.Select(numero => numero*numero);
//3
var lista3 = new List<string> () {
    "mateo","pepe","antonio","andres"
};

var lista3S = lista3.Order();
//4
var lista4 = new List<int> () {
    1000,2000,232323,5600
};

var lista4S = lista4.OrderByDescending(item=>item);
//5
var lista5 = new List<int>() {
    1,2,3,4,5,6,7,8
};

var primerNumeroPar = lista5.First(number=>number%2==0);
//6
var lista6 = new List<string> () {
    "majo","pedro","combita","arracachapepe"
};

var ultimoNombre = lista6.Last();
//7
var lista7 = new List<int>() {
    -1,-2,-3,-4,-5,100,200,300
};

var primerNumeroNegativo = lista7.FirstOrDefault(number=>number<0);
//8
var lista8 = new List<int>() {
    100,200,300,1
};

var ultimoNumeroMayorA50 = lista8.LastOrDefault(number=>number>50);
//9
var lista9 = new List<bool>() {
    false,true,false,false
};

var hayVerdadero = lista9.Any(value=>value==true);
//10
var lista10 = new List<int>() {
    10,20,0,230,30
};
var noHayCeros = lista10.All(number=>number!=0);

//11
var lista11 = new List<string>() {
    "hola soy javascript","hola soy linq","hola soy c#"
};

var verificacionLinq = lista11.Any(sentence=>sentence.Contains("linq"));
//12
var lista12 = new List<int>() {
    1,2,3,4,5,6,7,8,9,10,12,14
};
var cuentaNumerosPares = lista12.Where(number=>number%2==0).ToList();
var totalNumerosPares = cuentaNumerosPares.Count;
//13
var lista13 = new List<int>() {
    1000,2000,3000,50000
};
var sumaTotal = lista13.Sum();
//14
var lista14 = new List<int>() {
    1,2,3,4,5,6,7,8,9,10
};
var promedio = lista14.Average();
//15
var lista15 = new List<double>() {
    12.23,12,43.43,15.65,12,18
};
var temperaturaMinima = lista15.Min();
//16
var lista16 = new List<double>() {
    12.98,14.23,15.12,13.94
};
var maxTemperatura = lista16.Max();
//17
var lista17 = new List<int>() {
    1,2,3,4,5,6,7,8,9,10
};

var lista17S = lista17.Select(item=>item).Take(5).ToList();
//18
var lista18 = new List<string>() {
    "pepe","amongus","dumar","patricio"
};

var lista18S = lista18.Skip(3).ToList();
//19
var lista19 = new List<int>() {
    1,1,2,3,4,5,65,6,6,7,7,8,8,9,9
};
var lista19S = lista19.Distinct().ToList();

//20
string palabra = "Hola mundo";

var palabraEnLista =palabra.Split(" ");
//21
var lista21 = new List<int> () {
    1,2,3,4,5,6,7,8,9,10
};

int[] lista21S = lista21.ToArray();
//22
var lista22 = new List<int>() {
    -1,-2,-3,-4,-5,-6,-7,-8,-9,1,2,4,56,1,23
};

var lista22S = lista22.Where(item=>item>0).Order().ToList();
//23
var lista23 = new List<string>() {
    "ana maria", "daquiri"," phd","juggernaut","quick revive"
};
var lista23S = lista23.Select(item=>item.Length).ToList();

//24
var lista24 = new List<double>() {
    12345.2332,12232434,113243.2323,232323245,12,1,2,3,4,5,6,12344345.67
};
var lista24S = lista24.Order().Take(3).ToList();
//25
var lista25 = new List<string>() {
    "mama","david","santiago","pepe"
};

var lista25S = lista25.Where(item=>item.Length>5).ToList();
//26
var list26 = new List<int> () {
    100,200,3000,400
};

var list26S = list26.FirstOrDefault(item=>item>100);
//27

//28
var lista28 = new List<string> () {
    "pepe","rey","criteria","anaking"
};

string primerNombreConA = lista28.First(nombre=>nombre[0]=='a');
Console.WriteLine(primerNombreConA);
//29

//30

//31

//32

//33

//34

//35

//36

//37

//38

//39

//40