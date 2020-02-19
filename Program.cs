using System;

namespace Proyecto1_Control_de_Flujo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //VARIABLES

            Console.WriteLine("Inicio del Script");             //Console.WriteLine sirve para escribir una linea de código
            Console.Write("\r\n");                              //Sirve para hacer saltos de Linea
            Console.WriteLine("Tutorial de Variables");

            int numero = 10;                                    //Int "nombre variable" sirve para crear variables numericas sin decimales
            int resultado = numero * 5;
            Console.WriteLine(resultado);

            int suma = 8 + 20;
            Console.WriteLine(suma);

            string cadena = "Prueba variable";                  //String "nombre variable" sirve para crear variables con texto
            Console.WriteLine(cadena);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //TIPOS PREDEFINIDOS

            Console.WriteLine("Tutorial de Tipos Predefinidos");

            int entero = 200;   // tamaño 32 bits
            short s = 100;  // tamaño 16 bits
            byte b = 10;    // tamaño 8 bits
            long largo = 600; // tamaño 64 bits

            Console.WriteLine("int: {0}, short: {1}", entero ,s); //int:{0}, shot:{1} el valor dentro de los corchetes sirve para ordenar como se muestran las variables

            float f = 120.5f;   //Un decimal
            double d = 3.1415;  //Varios decimales
            decimal dec = 129.99m;  //Utilizado en operaciones financieras

            Console.WriteLine("float: {0}, dec: {1}", f, dec);

            char c = 'E';   //Utilizado en carácteres
            bool booleano = true;   //Representa valores verdaderos o falsos

            Console.Write("char: {0}", c);
            Console.WriteLine("bool: {0}", booleano);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //OPERADORES

            Console.WriteLine("Operadores");
            int a = 30;
            int g = 11;

            Console.WriteLine(a + g);
            Console.WriteLine(a - g);
            Console.WriteLine(a * g);
            Console.WriteLine(a / g);
            Console.WriteLine(a % g);

            Console.Write("\r\n");

            Console.WriteLine("Ejemplo Booleano");
            bool par = a % 2 == 1;  //Esta variable sirve para saber si es PAR o IMPAR, en caso de poner == 0 seria true, si pones == 1, sale falso, al no ser par.

            Console.WriteLine(par);

            //-------------------------------------------------------------------------------------------------------------------------------------

            //Operadores unarios
            a++;  //Esto equivale a la operacion a = a + 1;
            a--;  //Esto equivale a la operacion a = a - 1;

            //OPERADORES DE COMPARACION

            Console.Write("\r\n");

            Console.WriteLine("Ejemplos de comparacion");
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //IF - ELSE- SWITCH
            Console.WriteLine("If, Else y Switch");
            Console.Write("\r\n");

            //Ejemplo de If
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("La variable es mayor que 5");
            }

            Console.Write("\r\n");

            //Ejemplo de If y Else
            string user = "usuario";
            string pass = "hola1234";
            if (user == "usuario" && pass == "hola1234")  //En vez de usar && puede ponerse || que sirve para que se cumpla una de las 2 condiciones.
            {
                Console.WriteLine("Puedes acceder");
            }
            else
            {
                Console.WriteLine("Vuelve a intentarlo");
            }

            Console.Write("\r\n");

            //Ejemplo de If - Else - If
            int x = 8;
            int y = 8;
            if (x > y)
            {
                Console.WriteLine("{0} > {1}", x, y);
            }
            else if (x < y)
            {
                Console.WriteLine("{0} < {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} == {1}", x, y);
            }

            Console.Write("\r\n");

            //Ejemplo de Switch
            string codigo = "A1";
            switch (codigo)                                         //switch sirve para evaluar distintos casos, busca el valor de la variable
            {
                case "A1":
                    Console.WriteLine("Producto1");
                    break;

                case "A2":
                    Console.WriteLine("Producto2");
                    break;

                case "A3":
                    Console.WriteLine("Producto3");
                    break;

                default:                                            //default es como respuesta auxiliar en caso de no encontrar la variable
                    Console.WriteLine("Producto no encontrado");
                    break;
            }

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //FOR - WHILE - DO WHILE
            Console.WriteLine("For, While y Do While");

            //Ejemplo del For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            Console.Write("\r\n");

            //Ejemplo del While
            int n = 0;          //Declarar la variable de While
            while (n < 5)
            {
                Console.WriteLine("Valor del contador i: {0}", n);
                n++;
            }

            Console.Write("\r\n");

            //Ejemplo Do While
            int t = 6;
            do
            {
                Console.WriteLine("Valor del contador t: {0}", t);
                t++;
            }
            while (t < 5);

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //USO DEL BREAK Y CONTINUE
            Console.WriteLine("Uso del Break");
            Console.Write("\r\n");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Termina con el ciclo cuando llega la número 5.
                }
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            Console.WriteLine("Uso de continue");
            int nu = 0;
            while (nu < 10)
            {
                if (nu % 2 == 0) // Permite continuar al dividir n entre 2 si el resultado es par.
                {
                    nu++;
                    continue;  //Se salta las lineas que continuan el en ciclo del While y vuelve a valorar la condicion de la variable n.
                }
                Console.WriteLine("Valor del contador n: {0}", nu);
                nu++;  // Permite aumentar el valor del contador de 2 en 2, inciando al variable en impar, sacando solo los valores impares    
            }

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------

            //LECTURA DE DATOS DEL USUARIO

            Console.WriteLine("Suma de dos números");
            Console.WriteLine("Ingrese el número uno");

            string dato = Console.ReadLine();  //Los datos del usuario se leen como cadena, debe convertirse a numero (int.Parse).

            int n1 = int.Parse(dato);          //int.Parse sirve para convertir un dato de tipo "string" en uno de tipo "int"

            Console.Write("\r\n");

            Console.WriteLine("Ingrese el número dos");

            dato = Console.ReadLine();
            int n2 = int.Parse(dato);

            Console.Write("\r\n");

            int sumando = n1 + n2;
            Console.WriteLine("La suma de n1 + n2 es = {0}", sumando);     
        }
    }
}
