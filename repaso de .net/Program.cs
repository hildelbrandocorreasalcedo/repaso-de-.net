using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso_de.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Tipos de variables");
            Console.WriteLine("2. Pedir al usuario el nombre");
            Console.WriteLine("3. Tema de conversiones");
            Console.WriteLine("4. Ejercicio sobre encontrar el perimetro y area de un rectangulo");
            Console.WriteLine("5. Ejercicio sobre encontrar el perimetro de cualquier poligono");
            Console.WriteLine("6. Tipo de datos de desicion como bool");

            Console.WriteLine();    

            int numero;
            Console.Write("Digite un numero de las opciones: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("El número es 1: Tipos de variables");
                    // Tipos de variables
                    string nombreEstudiante;
                    nombreEstudiante = "juan";
                    Console.WriteLine("Hola mundo");
                    Console.WriteLine("Hola mundo " + nombreEstudiante);

                    char salon = 'A';
                    int numeroEstudiantes = 20;
                    string nombreAlumno = "Hildebrando Correa";
                    double nota1 = 2.9, nota2 = 2.9, nota3 = 3;
                    double promedioFinal;
                    promedioFinal = (nota1 + nota2 + nota3) / 3;

                    Console.WriteLine("Numero de estudiantes: " + numeroEstudiantes + " en el salon: " + salon);
                    Console.WriteLine("El nombre del Estudiante: " + nombreAlumno);
                    Console.WriteLine("Promedio Final: " + promedioFinal);

                    bool v = true, f = false;

                    // Condicionales
                    Console.WriteLine("dime si gano la asignatura o no?");
                    if (promedioFinal > 3.0)
                    {
                        Console.WriteLine("Gano la asignatura");
                    }
                    else
                    {
                        Console.WriteLine("Perdio la asignatura");
                    }

                    decimal promedioExamen1 = 8.5m;
                    float promedioExamen2 = 9.5f;
                    double promedioExamen3 = 4.3;

                    /*Comentarios largos
                     para escribir bastante informacion*/

                    string saludarEstuante = "Hola Hildel";
                    Console.WriteLine();
                    Console.WriteLine(saludarEstuante);

                    Console.WriteLine("Valores de los promedios de los examenes son {0} {1} {2}", promedioExamen1, promedioExamen2, promedioExamen3);

                    double notaSemestral = 3.0;
                    Console.WriteLine("Nota semestral: {0}", notaSemestral);

                    // los sufijos de las variables
                    Console.WriteLine();
                    Console.WriteLine("################################");
                    Console.WriteLine("los sufijos de las variables:");
                    Console.WriteLine("Operacion variables con float: " + 16.8f / 4.1f);
                    Console.WriteLine("Operacion variables con double: " + 16.8 / 4.1);
                    Console.WriteLine("Operacion variables con decimal: " + 16.8m / 4.1m);
                    double resultado = 3.0 / (3 + 5) * 2;
                    Console.WriteLine("Operacion 3.0 / (3 + 5) * 2 = " + resultado);

                    // sacar el recibio
                    Console.WriteLine("operadores de recibio de 5.9 % 3.1 = " + 5.9 % 3.1);
                break;



                case 2:
                    Console.WriteLine("El número es 2: Pedir al usuario");
                    // preguntamos el nombre del usuario
                    Console.WriteLine();
                    Console.WriteLine("################################");
                    string nombre;
                    Console.WriteLine("Temas de leer variables");
                    Console.Write("digite su nombre: ");
                    nombre = Console.ReadLine();

                    Console.WriteLine("el nombre es: " + nombre);
                    Console.WriteLine("el nombre es {0}", nombre);
                break;



                case 3:
                    // Tema de conversiones
                    Console.WriteLine();
                    Console.WriteLine("################################");
                    Console.WriteLine("Tema de conversiones - ejercicio 1");
                    string entrada;
                    int num1 = 5, num2, resultado2;

                    // preguntamos y asignaos el valor
                    Console.Write("Dame un numero para sumarlo con el 5 : ");
                    entrada = Console.ReadLine();

                    // convertimos la cadena a tipo int por medio del Covert, es mas funcional y si hay problema arrojara el valor de 0 (cero)
                    num2 = Convert.ToInt32(entrada);
                    // otra manera de conversion pero si hay un problema arroja error
                    //num2 = Int32.Parse(entrada);

                    resultado2 = num1 + num2;
                    Console.WriteLine("El resultado de los dos numeros sumados es: " + resultado2);


                    // segun ejemplo de otra manera de las conversiones
                    Console.WriteLine();
                    Console.WriteLine("Ejercicio 2 de conversion");
                    int num3 = 10, num4;
                    Console.Write("Dame un numero para sumarlo con el 10: ");
                    num4 = Convert.ToInt32(Console.ReadLine());
                    //num4 = Int32.Parse(Console.ReadLine());

                    resultado2 = num3 + num4;

                    // mostramos el resultado
                    Console.WriteLine("El resultado de la suma es: {0}", resultado2);
                break;



                case 4:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejercicio sobre encontrar el perimetro y area de un rectangulo");
                    double basee, altura, perimetro, area;
                    Console.Write("Digite la base: ");
                    basee = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    perimetro = 2 * (basee + altura );
                    area = basee * altura;

                    Console.WriteLine("el resultado del perimetro: " + perimetro + " Cm");
                    Console.WriteLine("el resultado del area: " + area + " Cm");
                break;


                case 5:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejercicio sobre encontrar el perimetro de cualquier poligono");
                    double lados, tamanio;
                    Console.Write("Digite el numero de lados: ");
                    lados = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite el tamaño del lado: ");
                    tamanio = Convert.ToDouble(Console.ReadLine());

                    perimetro = lados * tamanio;

                    Console.WriteLine("el resultado del perimetro del polifono de {0} lados es de {1} cm", lados, perimetro);

                break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Tipo de datos de desicion como bool");

                break;


                default:
                    Console.WriteLine("Número no reconocido");
                break;
            }

            Console.ReadKey();
        }
    }
}
