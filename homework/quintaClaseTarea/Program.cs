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

//29
var lista29 = new List<int>() {
    1,2,3,4,5,6,7,8,9,10
};

var lastOddNumber = lista29.LastOrDefault(item=>item%2!=0);
//30
var lista30 = new List<string>() {
    "pablo","aguacate","mondongo","hiperextrovertido"
};

var anyWord10Letter = lista30.Any(item=>item.Length>10);
//31
var lista31 = new List<int>() {
    12,18,19,20
};
var allOver18 = lista31.All(edad=>edad>=18);

//32
var lista32 = new List<string>() {
    "nueva york","los ángeles","tokio","osaka","londres","manchester","parís","marsella","roma","milán","madrid","barcelona","berlín","hamburgo","pekín","shanghái","moscú","san petersburgo","sídney","melbourne"
};

var madridExists = lista32.Any(ciudad=>ciudad=="madrid");

//33
var lista33 = new List<int>() {
    1,2,3,4,5,6,7,8,89,50
};

var amountOfNUmbersOver50 = lista33.Count(item=>item>=50);
//34
var lista34 = new List<int>() {
    -100,-99,-98,-97,-96,-95,-94,-93,-92,-91,-90,-89,-88,-87,-86,-85,-84,-83,-82,-81,-80,-79,-78,-77,-76,-75,-74,-73,-72,-71,-70,-69,-68,-67,-66,-65,-64,-63,-62,-61,-60,-59,-58,-57,-56,-55,-54,-53,-52,-51,-50,-49,-48,-47,-46,-45,-44,-43,-42,-41,-40,-39,-38,-37,-36,-35,-34,-33,-32,-31,-30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,-13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,0,1
}; 
var sumaNumerosPositivos = lista34.Where(numero=>numero>-1).Sum();

//35
var lista35 = new List<double>() {
    2.3,23.5,2367,1.2,6.7,8.9
};

var promedioDeCalificaciones = lista35.Average();
//36
var lista36 = new List<double>() {
    20.3, 18.5, 22.1, 16.8, 19.7, 23.5, 17.2, 21.6, 15.9, 24.8, 14.7, 25.2, 13.4, 26.7, 12.1, 27.9, 11.5, 28.3, 10.2, 29.1, 9.8, 30.4, 8.3, 31.6, 7.9, 32.8, 6.5, 33.2, 5.7, 34.7, 4.8, 35.9, 3.6, 36.5, 2.4, 37.2, 1.8, 38.6, 0.7, 39.4, -0.5, 40.1, -1.3, 41.2, -2.7, 42.5, -3.6, 43.9, -4.8, 44.3, -5.4, 45.6, -6.9, 46.8, -7.2, 47.3, -8.5, 48.1, -9.7, 49.4, -10.1, 50.6, -11.3, 51.8, -12.4, 52.7, -13.7, 53.9, -14.2, 54.8, -15.6, 55.3, -16.4, 56.7, -17.8, 57.9, -18.3, 58.5, -19.6, 59.2, -20.1, 60.4, -21.3, 61.6, -22.4, 62.8, -23.6, 63.4, -24.2, 64.9, -25.8, 65.7, -26.5, 66.2, -27.9, 67.4, -28.3, 68.3, -29.7, 69.1, -30.5, 70.6, -31.2, 71.8, -32.4, 72.3, -33.7, 73.5, -34.1, 74.7, -35.3, 75.9, -36.4, 76.4, -37.8, 77.6, -38.2, 78.5, -39.6, 79.2, -40.8, 80.4, -41.3, 81.6, -42.6, 82.8, -43.2, 83.4, -44.7, 84.9, -45.5, 85.7, -46.9, 86.2, -47
};

var minTemperatura = lista36.Min();
//37
var lista37 = new List<double>() {
    -100.0,-99.5,-99.0,-98.5,-98.0,-97.5,-97.0,-96.5,-96.0,-95.5,-95.0,-94.5,-94.0,-93.5,-93.0,-92.5,-92.0,-91.5,-91.0,-90.5,-90.0,-89.5,-89.0,-88.5,-88.0,-87.5,-87.0,-86.5,-86.0,-85.5,-85.0,-84.5,-84.0,-83.5,-83.0,-82.5,-82.0,-81.5,-81.0,-80.5,-80.0,-79.5,-79.0,-78.5,-78.0,-77.5,-77.0,-76.5,-76.0,-75.5,-75.0,-74.5,-74.0,-73.5,-73.0,-72.5,-72.0,-71.5,-71.0,-70.5,-70.0,-69.5,-69.0,-68.5,-68.0,-67.5,-67.0,-66.5,-66.0,-65.5,-65.0,-64.5,-64.0,-63.5,-63.0,-62.5,-62.0,-61.5,-61.0,-60.5,-60.0,-59.5,-59.0,-58.5,-58.0,-57.5,-57.0,-56.5,-56.0,-55.5,-55.0,-54.5,-54.0,-53.5,-53.0,-52.5,-52.0,-51.5,-51.0,-50.5,-50.0,-49.5,-49.0,-48.5,-48.0,-47.5,-47.0,-46.5,-46.0,-45.5,-45.0,-44.5,-44.0,-43.5,-43.0,-42.5,-42.0,-41.5,-41.0,-40.5,-40.0,-39.5,-39.0,-38.5,-38.0,-37.5,-37.0,-36.5,-36.0,-35.5,-35.0,-34.5,-34.0,-33.5,-33.0,-32.5,-32.0,-31.5,-31.0,-30.5,-30.0,-29.5,-29.0,-28.5,-28.0,-27.5,-27.0,-26.5,-26.0,-25.5,-25.0,-24.5,-24.0,-23.5,-23.0,-22.5,-22.0,-21.5,-21.0,-20.5,-20.0,-19.5,-19.0,-18.5,-18.0,-17.5,-17.0,-16.5,-16.0,-15.5,-15.0,-14.5,-14.0,-13.5,-13.0,-12.5,-12.0,-11.5,-11.0,-10.5,-10.0,-9.5,-9.0,-8.5,-8.0,-7.5,-7.0,-6.5,-6.0,-5.5,-5.0,-4.5,-4.0,-3.5,-3.0,-2.5,-2.0,-1.5,-1.0,-0.5,0.0,0.5,1.0,1.5,2.0,2.5,3.0,3.5,4.0,4.5,5.0,5.5,6.0,6.5,7.0,7.5,8.0,8.5,9.0,9.5,10.0,10.5,11.0,11.5,12.0,12.5,13.0,13.5,14.0,14.5,15.0,15.5,16.0,16.5,17.0,17.5,18.0,18.5,19.0,19.5,20.0,20.5,21.0,21.5,22.0,22.5,23.0,23.5,24.0,24.5,25.0,25.5,26.0,26.5,27.0,27.5,28.0,28.5,29.0,29.5,30.0,30.5,31.0,31.5,32.0,32.5,33.0,33.5,34.0,34.5,35.0,35.5,36.0,36.5,37.0,37.5,38.0,38.5,39.0,39.5,40.0,40.5,41.0,41.5,42.0,42.5,43.0,43.5,44.0,44.5,45.0,45.5,46.0,46.5,47.0,47.5,48.0,48.5,49.0,49.5,50.0,50.5,51.0,51.5,52.0,52.5,53.0,53.5,54.0,54.5,55.0,55.5,56.0,56.5,57.0,57.5,58.0,58.5,59.0,59.5,60.0,60.5,61.0,61.5,62.0,62.5,63.0,63.5,64.0,64.5,65.0,65.5,66.0,66.5,67.0,67.5,68.0,68.5,69.0,69.5,70.0,70.5,71.0,71.5,72.0,72.5,73.0,73.5,74.0,74.5,75.0,75.5,76.0,76.5,77.0,77.5,78.0,78.5,79.0,79.5,80.0,80.5,81.0,81.5,82.0,82.5,83.0,83.5,84.0,84.5,85.0,85.5,86.0,86.5,87.0,87.5,88.0,88.5,89.0,89.5,90.0,90.5,91.0,91.5,92.0,92.5,93.0,93.5,94.0,94.5,95.0,95.5,96.0,96.5,97.0,97.5,98.0,98.5,99.0,99.5,100.0

};
var maxAltura = lista37.Max();

//38
var lista38 = new List<string>() {
    "pan","leche","huevos","arroz","fideos","aceite","sal","azúcar","café","té","harina","manteca","queso","jamon","pollo","carne","pescado","verduras","frutas","papas","cebollas","ajo","tomates","zanahorias","calabacines","lechuga","pepino","berenjena","apio","batatas","calabaza","brócoli","espinacas","coliflor","kiwi","naranjas","manzanas","peras","plátanos","uvas","sandías","melones","duraznos","ciruelas","mangos","limones","limas","pimientos","chiles","champiñones","aceitunas","alcaparras","nueces","almendras","avellanas","castañas","cacahuetes","aceite de oliva","vinagre","mostaza","mayonesa","ketchup","salsa de soja","salsa inglesa","salsa de tomate","miel","mermelada","pan integral","pan blanco","galletas","cereales","yogur","queso crema","crema de leche","manteca","chocolate","helado","azúcar impalpable","sal fina","sal gruesa","pimienta negra","pimienta blanca","comino","perejil","cilantro","tomillo","romero","orégano","curry","páprika","nuez moscada","jengibre","canela","vainilla"
};
var primeros10Elementos = lista38.Take(10).ToList();
//39
var lista39 = new List<string>() {
    "pan","leche","huevos","arroz","fideos","aceite","sal","azúcar","café","té","harina","manteca","queso","jamon","pollo","carne","pescado","verduras","frutas","papas","cebollas","ajo","tomates","zanahorias","calabacines","lechuga","pepino","berenjena","apio","batatas","calabaza","brócoli","espinacas","coliflor","kiwi","naranjas","manzanas","peras","plátanos","uvas","sandías","melones","duraznos","ciruelas","mangos","limones","limas","pimientos","chiles","champiñones","aceitunas","alcaparras","nueces","almendras","avellanas","castañas","cacahuetes","aceite de oliva","vinagre","mostaza","mayonesa","ketchup","salsa de soja","salsa inglesa","salsa de tomate","miel","mermelada","pan integral","pan blanco","galletas","cereales","yogur","queso crema","crema de leche","manteca","chocolate","helado","azúcar impalpable","sal fina","sal gruesa","pimienta negra","pimienta blanca","comino","perejil","cilantro","tomillo","romero","orégano","curry","páprika","nuez moscada","jengibre","canela","vainilla"
};
var listaProductosNuevos = lista39.Skip(5).ToList();
//40
var lista40 = new List<string>() {
    "pan","leche","huevos","arroz","fideos","aceite","sal","azúcar","café","té","harina","manteca","queso","jamon","pollo","carne","pescado","verduras","frutas","papas","cebollas","ajo","tomates","zanahorias","calabacines","lechuga","pepino","berenjena","apio","batatas","calabaza","brócoli","espinacas","coliflor","kiwi","naranjas","manzanas","peras","plátanos","uvas","sandías","melones","duraznos","ciruelas","mangos","limones","limas","pimientos","chiles","champiñones","aceitunas","alcaparras","nueces","almendras","avellanas","castañas","cacahuetes","aceite de oliva","vinagre","mostaza","mayonesa","ketchup","salsa de soja","salsa inglesa","salsa de tomate","miel","mermelada","pan integral","pan blanco","galletas","cereales","yogur","queso crema","crema de leche","manteca","chocolate","helado","azúcar impalpable","sal fina","sal gruesa","pimienta negra","pimienta blanca","comino","perejil","cilantro","tomillo","romero","orégano","curry","páprika","nuez moscada","jengibre","canela","vainilla"
};

var listaProductosNuevosOrdenados = lista40.Distinct().Order().ToList();
