using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//lo que está en gris clarito lo indica xq no se usa en el programa
namespace Hola_Mundo_cs
{
    class Programita
    {
        //no podemos utilizar var a nivel de clase, solo dentro de funciones
        //el main es static con lo cual no se puede acceder a la variable desde dentro del static
        
        static void Main(string[] args)
        {
            var edad = 22;//reconoce la variable solo como una de 32 bits

            var nombre = "Luis";

            var fecha = DateTime.Now;

            var texto = String.Format("Hola {0} tienes {1} años. Hoy es {2:d}", nombre, edad, fecha); 
            //String.Format es un método para crear cadenas inyectando datos, cuando le pongo los : lo que me hace es formatear el contenido que le inyecto

            var arr1 = new int[4];//primera forma, diciéndole cómo va a ser el array
            arr1[0] = 44;
            arr1[1] = 22;
            arr1[2] = 15;
            arr1[3] = 82;

            int [] arr2 = {4, 7, 3, 9}; //segunda forma dándole el tipo, las dos representan lo mismo, un array de 4 enteros, en uno le doy los datos en otro no
            //aquí los arrays no son de tamaño variable, aquí son de tamaño fijo y siempre empiezan con el 0, no se puede definir el índice mínimo de un array
            //tampoco hay arrays asociativos con clave de texto

            for (int i = 0; i < arr1.Length; i++)//primera forma en la que recorro el array imprimiendo los valores del array
            {
                Console.WriteLine("La posición {0} vale {1}",i,arr1[i]);
            }

            foreach (var i in arr2)
            {
                Console.WriteLine("Vale {0}", i); //esta es la segunda forma de recorrelo, con el for each, lo que estoy haciendo es básicamente lo mismo de las dos maneras   
            }



            Console.WriteLine("Hola Mundo, soy un programa");

            Console.WriteLine(texto);

            Console.ReadLine();//con esto el mensaje espera a desaparecer hasta que el usuario pulsa enter
        }
    }
}
