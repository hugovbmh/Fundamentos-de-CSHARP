using System;
using System.Collections.Generic;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using FundamentosCSHARP.Service;
using FundamentosCSHARP.Errors;

namespace FundamentosCSHARP
{
    static class Program
    {
        static void Main(string[] args)
        {

        }
        
    }
}
//**********************************************
// crear objeto
// Bebida bebida = new Bebida("Coca cola",1000);
// bebida.Beberse(500);
// Console.WriteLine(bebida.Cantidad);

// int numero1 = 213;
// long numero2 = 128;
// float numero3 = 189.1f;// agregar f ,   4 bytes
// double numero4 = 123.2d;// agregar d,   8 bytes
// decimal numero5 = 321.4m;// agregar m,   16 bytes
// char caracter1 = 'A'; // solo 1 caracter
// string caracter2 = "aujniwfujniaw";
// DateTime date = DateTime.Now;
// bool siOno = false;
// int? numero = null; // el ? en el tipo de dato permite aceptar valores null
// var nombre = "Hugo";
// var limite = 50;
// var persona = new { nombre = "Hugo", apellido = "Vilchez", edad=25 };
// Console.WriteLine(persona.edad);
//**********************************************
////arreglo en cshrap
//int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
////bucle for parecido a java y javascript
//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine("iteración: " + i + " - " + numeros[i]);
//}
////bucle foreach parecido a python
//foreach (var numero in numeros)
//{
//    Console.WriteLine(numero);
//}

////Lista es csharp
//Console.WriteLine("***************Lista******************");

//List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
//lista.Add(9);
//lista.Add(0);
//lista.Remove(2);

//foreach (var numero in lista)
//{
//    Console.WriteLine("Elemento: " + numero);
//}
//// Agregar objetos a lista de tipo Cerveza
//List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premium") };
//cervezas.Add(new Cerveza(500));
//Cerveza erdinger = new Cerveza(500, "Cerveza de trigo");
//cervezas.Add(erdinger);

//foreach (var cerveza in cervezas)
//{
//    Console.WriteLine("Cerveza: " + cerveza.Nombre);
//}
//**********************************************
//{
//    var bebidaAlcoholica = new Cerveza(100);
//    MostrarRecomendacion(bebidaAlcoholica);
//}

//static void MostrarRecomendacion(IBebidaAlcoholica bebida)
//{
//    bebida.MaxRecomendado();
//}
//**********************************************

//CervezaBD cervezaBD = new CervezaBD();
/* codigo para agregar cerveza
//Creamos un nuevo objeto de la clase modelo Cerveza
{
    Cerveza cerveza = new Cerveza(15, "Pale ale");
    cerveza.Marca = "Minerva";
    cerveza.Alcohol = 6;
    //insertamos nueva cerveza a la BD
    cervezaBD.Add(cerveza);
}
*/
/* Codigo para editar cerveza
{
    Cerveza cerveza = new Cerveza(5, "Pale ale");
    cerveza.Marca = "Minerva";
    cerveza.Alcohol = 5;
    cervezaBD.Edit(cerveza, 5);

}*/

/*
// Codigo para eliminar cerveza
{
    cervezaBD.Delete(5);
}
*/
/*
//var especifica a la variable el tipo de dato automaticamente de la derecha
//obtener todas las cervezas
var cervezas = cervezaBD.Get();

foreach (var cerveza in cervezas)
{
    Console.WriteLine(cerveza.Nombre);
}
*/
//**********************************************
//Serializar: Convertir un objeto a Json
//Cerveza cerveza = new Cerveza(10, "Cerveza");
//string miJson = JsonSerializer.Serialize(cerveza);
//File.WriteAllText("objeto.txt",miJson);

//Deserializar: Convertir un Json a un objeto
//string miJson = File.ReadAllText("objeto.txt");
//Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);
//**********************************************
//***** Solicitudes a Servicios Web por HTTP GET 
//string url = "https://jsonplaceholder.typicode.com/posts";
//HttpClient client = new HttpClient();
//// el await es esperar a que termine todo el codigo anterior
//// para luego seguir con los siguientes codigo
//var httpResponse = await client.GetAsync(url);

//if(httpResponse.IsSuccessStatusCode)
//{
//    var content = await httpResponse.Content.ReadAsStringAsync();
//    var posts = JsonSerializer.Deserialize<List<Post>>(content);
//}

//***** Solicitudes a Servicios Web por HTTP POST
//string url = "https://jsonplaceholder.typicode.com/posts";
//var client = new HttpClient();

//Post post = new Post()
//{
//    userId = 50,
//    body = "Hola como estan",
//    title = "titulo de saludo"
//};

//var data = JsonSerializer.Serialize<Post>(post);
//HttpContent content =
//    new StringContent(data, System.Text.Encoding.UTF8, "application/json");
//var httpResponse = await client.PostAsync(url, content);

//if (httpResponse.IsSuccessStatusCode)
//{
//    var result = await httpResponse.Content.ReadAsStringAsync();

//    var postResult = JsonSerializer.Deserialize<Post>(result);
//}

//***** Solicitudes a Servicios Web por HTTP PUT
//string url = "https://jsonplaceholder.typicode.com/posts/99";
//var client = new HttpClient();

//Post post = new Post()
//{
//    userId = 50,
//    body = "Hola como estan",
//    title = "titulo de saludo"
//};

//var data = JsonSerializer.Serialize<Post>(post);
//HttpContent content =
//    new StringContent(data, System.Text.Encoding.UTF8, "application/json");
//var httpResponse = await client.PutAsync(url, content);

//if (httpResponse.IsSuccessStatusCode)
//{
//    var result = await httpResponse.Content.ReadAsStringAsync();

//    var postResult = JsonSerializer.Deserialize<Post>(result);
//}

//***** Solicitudes a Servicios Web por HTTP DELETE
//string url = "https://jsonplaceholder.typicode.com/posts/99";
//var client = new HttpClient();

////Post post = new Post()
////{
////    userId = 50,
////    body = "Hola como estan",
////    title = "titulo de saludo"
////};

////var data = JsonSerializer.Serialize<Post>(post);
////HttpContent content =
////    new StringContent(data, System.Text.Encoding.UTF8, "application/json");
//var httpResponse = await client.DeleteAsync(url);

//if (httpResponse.IsSuccessStatusCode)
//{
//    var result = await httpResponse.Content.ReadAsStringAsync();

//    //var postResult = JsonSerializer.Deserialize<Post>(result);
//}
//**********************************************
//Usando Generics <> con la clase SendRequest.cs
//var cerveza = new Cerveza()
//{ Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticús"};

//var post = new Post() { body = "soy un body", title = "hola", userId = 50 };

//Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
//var CervezaRespuesta = await service.Send(cerveza);
//********************************************** LINQ
//Uso de Linq (lenguaje de consulta de colecciones en c#)
//List<int> numeros = new List<int>() { 66,1, 4, 5, 6, 7, 2, 3 };

//promediar numeros
//var total = numeros.Average(d => d);
//Console.WriteLine(total);

//sumar numeros
//var total = numeros.Sum(d => d);
//Console.WriteLine(total);

//ordenar numeros
//var numerosOrdenados = numeros.OrderBy(d => d);
//foreach (var numero in numerosOrdenados)
//{
//    Console.WriteLine(numero);
//}

//encontrar numero
//funcion lambda
//var numero7 = numeros.Where(d => d == 79).FirstOrDefault();
//Console.WriteLine(numero7);

//Linq es una lista de objetos
//List<Cerveza> cervezas = new List<Cerveza>()
//{ 
//    new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
//    new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
//    new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
//    new Cerveza(){ Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}
//};
//var cervezasOrdenadas = from d in cervezas
//                        where d.Nombre=="Pale Ale" && d.Marca == "Minerva"
//                        orderby d.Nombre
//                        select d;
//foreach (var cerveza in cervezasOrdenadas)
//{
//    Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
//}


//********************************************** LINQ
//LINQ para manipular y obtener objetos complejos con subconsultas
//List<Bar> bares = new List<Bar>()
//{
//    new Bar("El bar")
//    {
//        cervezas = new List<Cerveza>()
//        {
//            new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
//            new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
//            new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"}

//        }
//    },
//    new Bar("El bar 2")
//    {
//        cervezas = new List<Cerveza>()
//        {
//            new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
//            new Cerveza(){ Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}
//        }
//    },
//    new Bar("El bar nuevo")
//};

//var bar = (from d in bares
//           where d.cervezas.Where(c => c.Nombre == "Stout").Count() > 0
//           select new BarData(d.Nombre)
//           {
//               bebidas = (from c in d.cervezas
//                          select new Bebida(c.Nombre,c.Cantidad)
//                          ).ToList()
//           }
//           ).ToList();

////var bar = (from d in bares
////          where d.cervezas.Where(c => c.Nombre == "Stout").Count()>0
////          select d).ToList();
///
//**********************************************
//Control de situaciones inesperadas con Excepciones
//try
//{
//    var searcherBeer = new SearcherBeer();
//    var cantidad = searcherBeer.GetCantidad("afadfasf");
//    Console.WriteLine("Todo bien");
//}
//catch (BeerNotFoundException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine("Ha caido en una operación invalida");
//}
////excepcion global
//catch(Exception ex)
//{
//    Console.WriteLine("Una excepción no esperada");
//}
////siempre se ejecutará finally
//finally
//{
//    Console.WriteLine("Esto siempre se ejecuta");
//}
//**********************************************
//    //Delegados, Func y Action
//    //Func<recibe,regresa> recibe y regresa algo
//    //Action<recibe,recibe,etc> solo recibe, NO regresa algo
//    Action<string,string> mostrar = Show;
//    HacerAlgo(mostrar);

//}
//public static void HacerAlgo(Action<string, string> funcionFinal)
//{
//    Console.WriteLine("hago algo");
//    funcionFinal("se envió desde otra función","otra");
//    Console.WriteLine("hago algo más");
//}
//public static void Show(string cad, string cad2)
//{
//    Console.WriteLine(cad+cad2);
//}
//public static int Show(string cad)
//{
//    return cad.Count();
//}

//**********************************************Predicate
//Predicate
//var numbers = 
//    new List<int> { 1, 56, 2, 3, 3, 45, 6 };
//var predicate = new Predicate<int>(x => x % 2 == 0);
//Predicate<int> negativePredicate = x => !predicate(x);
//var dividers2 = numbers.FindAll(negativePredicate);

//dividers2.ForEach(d => { Console.WriteLine(d); });
//**********************************************Predicate
    //{
    //    public class Beer
    //    {
    //        public string Name { get; set; }
    //        public int Alcohol { get; set; }
    //    }
    //    static void Main(string[] args)
    //    {

//        var beers = new List<Beer>()
//        {
//            new Beer(){Name = "Ipa", Alcohol = 7},
//            new Beer(){Name = "Pale ale", Alcohol = 8},
//            new Beer(){Name = "Stout", Alcohol = 9},
//            new Beer(){Name = "Tripel", Alcohol = 15},
//        };
//        beers.ShowBeerThatIGetDrunk( x => x.Alcohol >= 8);
//    }
//    //Predicate recibe algo y regresa un booleano
//    //Predicate sirven para hacer metodos que puedan recibir condiciones booleanas
//    static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
//    {
//        var evilBeer = beers.FindAll(condition);
//        evilBeer.ForEach(d => Console.WriteLine(d.Name));
//    }