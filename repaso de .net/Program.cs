using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            Console.WriteLine("7. Condionales if");
            Console.WriteLine("8. Operadores logicos boleanos");
            Console.WriteLine("9. Ciclos o bucles for");
            Console.WriteLine("10. Ciclos o bucles while - do while");
            Console.WriteLine("11. Ejecucion de intrucciones anidadas son 2 for - Tabla de multiplicar");
            Console.WriteLine("12. tipos de llamadas de metodos");
            Console.WriteLine("13. Pasar por referencia (ref)");

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
                    const int cedula = 123528393;
                    var nombrePersona = "Hildebrando";
                    var direccion = "Calle 20 #44";
                    var calif = 4.5;
                    Console.WriteLine("Hola mundo");
                    Console.WriteLine("Hola mundo " + nombreEstudiante);

                    char salon = 'A';
                    int numeroEstudiantes = 20;
                    string nombreAlumno = "Hildebrando Correa";
                    double nota1 = 2.9, nota2 = 2.9, nota3 = 3;
                    double promedioFinal;
                    promedioFinal = (nota1 + nota2 + nota3) / 3;

                    Console.WriteLine("Numero de estudiantes: " + numeroEstudiantes + " en el salon: " + salon);
                    Console.WriteLine("El nombre del Estudiante: " + nombreAlumno + ", con Cedula: " + cedula + ", "+ nombrePersona + ", " + direccion + ", "+ calif);
                    Console.WriteLine("Promedio Final: " + promedioFinal);


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

                    perimetro = 2 * (basee + altura);
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
                    Console.WriteLine("Tipo de datos de desición como bool\n " +
                        "los operadores de igualdad son (==) y el (!=)");
                    Console.WriteLine("el valor de  6 == 6 es: {0}", 6 == 6);
                    Console.WriteLine("el valor de  5 == 6 es: {0}", 5 == 6);
                    Console.WriteLine("el valor de  6 != 6 es: {0}", 6 != 6);
                    Console.WriteLine("el valor de  5 != 6 es: {0}", 5 != 6);

                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Operaciones de comparaciones");
                    Console.WriteLine("el valor de  6 > 7 es: {0}", 6 > 7);
                    Console.WriteLine("el valor de  5 < 9 es: {0}", 5 < 9);
                    Console.WriteLine("el valor de  6 <= 6 es: {0}", 6 <= 6);
                    Console.WriteLine("el valor de  5 >= 6 es: {0}", 5 >= 6);
                    Console.WriteLine("el valor de  (8 + 5) > 6 es: {0}", (8 + 5) > 6);

                    break;


                case 7:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Condionales if: ejercicio 1");
                    double num;
                    Console.Write("Digite un numero: ");
                    num = Convert.ToDouble(Console.ReadLine());

                    if (num > 0)
                    {
                        Console.WriteLine("El numero es positivo: " + num);
                    } else if ((num < 0))
                    {
                        Console.WriteLine("El numero es negativo: " + num);
                    } else
                    {
                        Console.WriteLine("El numero es igual a 0 = " + num);
                    }


                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejercio 2: ¿para saber si eres mayor de edad o no?");
                    byte edad;
                    Console.Write("Digite la edad: ");
                    edad = Convert.ToByte(Console.ReadLine());

                    if (edad >= 18)
                    {
                        Console.WriteLine("Eres mayor de edad: " + edad);
                    }
                    else
                    {
                        Console.WriteLine("Eres menor de edad: " + edad);
                    }


                    break;



                case 8:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Operadores logicos boleanos");

                    bool bateria = true;
                    Console.WriteLine("Ejemplo 1 con la negacion de !");
                    Console.Write("¿hay bateria en tu celular? (true/false): ");
                    bateria = Convert.ToBoolean(Console.ReadLine());

                    if (!(bateria == true))
                    {
                        Console.WriteLine("debe conectar el celular para cargarlo");
                    }
                    else
                    {
                        Console.WriteLine("No es necesario conectar el celular");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 2 con el operador de &&");
                    byte edadd;
                    bool licecia;

                    Console.Write("Digite la edad: ");
                    edadd = Convert.ToByte(Console.ReadLine());

                    Console.Write("¿Tienes licencia? (true/false): ");
                    licecia = Convert.ToBoolean(Console.ReadLine());

                    if ((edadd >= 18) && (licecia == true))
                    {
                        Console.WriteLine("cumple con los requisitos, puede conducir");
                    }else
                    {
                        Console.WriteLine("No cumple con los requisitos, NO debe conducir");
                    }


                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 3 con el operador de ||");
                    float califiacionExamen, calificacionPreparacion;

                    Console.WriteLine("¿Cuanto fue tu calificacion de preparacion? entre 0 a 10:");
                    calificacionPreparacion = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("¿Cuanto fue tu calificacion de preparacion? entre 0 a 10:");
                    califiacionExamen = Convert.ToSingle(Console.ReadLine());

                    if ((calificacionPreparacion >= 9) || (califiacionExamen >=9.5))
                    {
                        Console.WriteLine("Gano el curso");
                    }
                    else
                    {
                        Console.WriteLine("No puede pasar el Curso");
                    }


                    Console.WriteLine("");


                    break;



                case 9:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("cliclos y bucles");
                    Console.WriteLine("ciclo for - ejemplo 1");

                    for (int i=1; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    int x = 2;
                    Console.WriteLine(x);
                    //asignacion compuesta
                    x += 5; // es lo mimso a: x = x + 5;
                    Console.WriteLine(x);

                    // Cambio en el iterador, con asignacion compuestas
                    Console.WriteLine();
                    Console.WriteLine("Cambio en el iterador, con asignacion compuestas");
                    for(int i = 1; i <=10; i += 2)
                    {
                        Console.WriteLine(i);

                    }

                    Console.WriteLine();
                    Console.WriteLine("En decremento: ");
                    for(int i=10; i >=1; i--)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine();
                    Console.WriteLine("En decremento, un console en el iterador: ");
                    for (int i = 10; i >= 1; i--, Console.WriteLine("Valor de salida: {0}", i))
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Ejemplo de contador");
                    int contador = 0;
                    for (int i = 1; i <= 10; i++)
                    {
                        contador++; // otras opciones son:
                        //contador = contador + 1; 
                        //contador +=1;     asignacion compuesta
                        Console.WriteLine("Vueltas del ciclo numerico {0}", contador);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 2 de contador: incremento de 2 en 2 el iterador");
                    int contadorr = 0;
                    for (int i = 0; i <= 20; i+=2)
                    {
                        contadorr +=1;
                        Console.WriteLine("{0}, Vueltas del ciclo numerico {1}", i, contadorr);
                    }
                    Console.WriteLine("Vueltas del ciclo numerico fue: {0}", contadorr);




                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 4 de acumulador de compras de productos");
                    int acumulador = 0;
                    int precio = 0;
                    int cantidadProductos =0;

                    Console.Write("Ingrese la cantidad de productos: ");
                    cantidadProductos = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= cantidadProductos; i++)
                    {
                        Console.Write("Ingrese el valor del producto {0} es de: ", i);
                        precio = Convert.ToInt32(Console.ReadLine());

                        acumulador = acumulador + precio;
                    }
                    Console.WriteLine("El total a pagar es: {0}", acumulador);




                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 5 de Factorial de un numero");
                    ulong numeroUsuario, factorial = 1;
                   
                    Console.Write("Ingrese el numero para calcular el factorial: ");
                    numeroUsuario = Convert.ToUInt64(Console.ReadLine());

                    for (ulong i = numeroUsuario; i >= 1; i--)
                    {
                        factorial = factorial * i; // factorial *= i;
                    }
                    Console.WriteLine("El factorial es {0}, es: {1}", numeroUsuario, factorial);
                break;



                case 10:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ciclos o bucles while");

                    byte numeroW = 1;
                    while (numeroW <=10)
                    {
                        Console.WriteLine(numeroW);

                        numeroW++;
                    }


                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 2 de registro de contraseñas - con While");

                    string contraseña1, contraseña2 = "";

                    Console.Write("Escribe tu contraseña: ");
                    contraseña1 = Console.ReadLine();

                    while (contraseña1 != contraseña2)
                    {
                        Console.Write("Confirmar contraseña: ");
                        contraseña2 = Console.ReadLine();
                    }
                    Console.WriteLine("Contraseña guardada!!");


                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 3 - do while");

                    int j = 1;
                    do // hacer
                    {
                        Console.WriteLine(j);
                        j++;
                    }
                    while(j <=10); // mientras


                    Console.WriteLine();
                break;



                case 11:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejecucion de intrucciones anidadas son 2 for - Tabla de multiplicar");

                    int resultadoMultipliacion;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("Tabla de multiplicar del {0}", i);
                        for (int k = 1; k <= 10; k++)
                        {
                            resultadoMultipliacion = i * k;
                            Console.WriteLine("{0} * {1} = {2}", i, k, resultadoMultipliacion);
                        }
                    }
                break;




                case 12:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Llamada de metodos");

                    // suma
                    Sumar();


                    //  resta - metodo con retorna el valor (return)
                    Console.WriteLine();
                    Console.WriteLine("Invocacio de un metodo que devuelve un tipo");

                    decimal resultadoResta; //Variable que recibe el valor del "return"

                    resultadoResta = Restar(); // Asignacion del valor del metodo a la variable
                    Console.WriteLine("El resultado de la resta es: " + resultadoResta);


                    //  multiplicacion - metodo con parametros
                    decimal num1Argumento, num2Argumento;

                    Console.WriteLine();
                    Console.WriteLine("Operacion de Multiplicar");
                    num1Argumento = IngreseNumero("Ingrese el primer numero: ");
                    num2Argumento = IngreseNumero("Ingrese el segundo numero: ");

                    Multiplicar(num1Argumento, num2Argumento); // enviando valores por argumentos al metodo



                    // division - metodo con parametros y tambien retorna (return)
                    Console.WriteLine();
                    Console.WriteLine("Operacion de Dividir");

                    decimal resultadoDividir;

                    num1Argumento = IngreseNumero("Ingrese el primer numero: ");
                    num2Argumento = IngreseNumero("Ingrese el segundo numero: ");

                    resultadoDividir = Dividir(num1Argumento, num2Argumento);

                    Console.WriteLine("El resultado de la division {0} / {1} = {2}", num1Argumento, num2Argumento, resultadoDividir);

                break;




                case 13:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Pasar por referencia (ref)");
                    byte numArgumento = 10;
                    Console.WriteLine(numArgumento);

                    //Invicamos al metodo y le mandamos el argumento
                    Prueba(ref numArgumento);

                    // despues de que el metodo cambios el valor, volvemos a mostrar
                    Console.WriteLine(numArgumento);
                break;




                case 14:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("");
                    Console.WriteLine();
                    break;



                default:
                    Console.WriteLine("Número no reconocido");
                break;
            }
            Console.ReadKey();
        }


        
        
        //  Modificador - tipo - identificador - parametros
        static void Sumar()
        {
            decimal num1, num2, resultado;
            Console.WriteLine();
            Console.WriteLine("Operacion de suma");
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " + resultado);
        }


        static decimal Restar()
        {
            decimal num1, num2, resultado;
            Console.WriteLine("Operacion de resta");
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 - num2;

            // devolvemos un tipo al autor de llamado
            return resultado;
        }



        // metodo que contiene parametros
        static void Multiplicar(decimal num1Parametros, decimal num2Pametros) // recibiendo valores por parametros
        {
            decimal resultado;

            resultado = num1Parametros * num2Pametros;

            Console.WriteLine("{0} * {1} = {2}", num1Parametros, num2Pametros, resultado);
        }



        //  metodo que contiene parametros y tambien retorna (return)
        static decimal Dividir(decimal num1Parametros, decimal num2Pametros) // recibiendo valores por parametros
        {
            decimal resultado;

            if (num2Pametros != 0)
            {
                resultado = num1Parametros / num2Pametros;

            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
                resultado = 0;
            }
            return resultado;
        }



        // Optimizacion de peticion de valores
        static decimal IngreseNumero(string peticion)
        {
            decimal numero;

            Console.Write(peticion);

            // Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            // devolvemos el valor de tipo decimal
            return numero;
        }



        static void Prueba(ref byte numeroParametro)
        {
            numeroParametro = 20;
        }
    }
}
