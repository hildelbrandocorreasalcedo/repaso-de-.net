using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace repaso_de.net
{
    class Program
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
            Console.WriteLine("14. Array - Matriz unidimencional");
            Console.WriteLine("15. Matriz mutidimencional de 2");
            Console.WriteLine("16. Pasar matrices como argumentos en metodos");
            Console.WriteLine("17. Clases y objetos, propiedades Publicas - ejemplo de la clase Motocipleta");
            Console.WriteLine("18. Clases y objetos, propiedades Privadas - ejemplo de la clase Automovil");
            Console.WriteLine("19. Metodo sobrecargado - Ejemplo");
            Console.WriteLine("20. Clase Random - Ejemplo");
            Console.WriteLine("21. Ejemplo practico con clases, objetos, metodos, Random");
            Console.WriteLine("22. Ejemplo de cuenta bancaria - con clases, objetos, metodos");
            Console.WriteLine("23. Tipos de referencias Object y tambien convertiones explicitas e implicitas");
            Console.WriteLine("24. Ejemplo CON Genericos - Ejemplo de Alumnos");
            Console.WriteLine("25. Ejemplo SIN Genericos - Ejemplo de Alumnos");

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

                    //Tupla ejemplo:
                    Console.WriteLine();
                    Console.WriteLine("Ejemplo tupla 1:");
                    (string, byte, long, int) persona1 = ("hildel", 50, 3234343, 24);
                    Console.WriteLine(persona1);

                    // con var tambien es posible:
                    Console.WriteLine();
                    Console.WriteLine("Ejemplo tupla 2:");
                    var persona2 = ("hildel", 50, 3234343, 24);
                    Console.WriteLine(persona2);
                    Console.WriteLine("item1: " + persona2.Item1 + ", item2: " + persona2.Item2);

                    // otra manera para mencionar el nombre de las variables en las tuplas:
                    Console.WriteLine();
                    Console.WriteLine("Ejemplo tupla 3:");
                    var persona3 = (nombre: "hildel", edad: 24, telefono: 3234343, año: 2000);
                    Console.WriteLine(persona3);
                    Console.WriteLine("item1: " + persona3.nombre + ", item2: " + persona3.edad);

                    // mejor manera de mostrar las tuplas:
                    Console.WriteLine();
                    Console.WriteLine("Ejemplo tupla 4:");
                    (string nombre, byte edad, long telefono, int año) persona4 = ("hildel", 24, 32534343, 2000);
                    Console.WriteLine("{0}, {1}, {2}, {3}", persona4.nombre, persona4.edad, persona4.telefono, persona4.año);

                    Console.WriteLine();
                    char salon = 'A';
                    int numeroEstudiantes = 20;
                    string nombreAlumno = "Hildebrando Correa";
                    double nota1 = 2.9, nota2 = 2.9, nota3 = 3;
                    double promedioFinal;
                    promedioFinal = (nota1 + nota2 + nota3) / 3;

                    Console.WriteLine("Numero de estudiantes: " + numeroEstudiantes + " en el salon: " + salon);
                    Console.WriteLine("El nombre del Estudiante: " + nombreAlumno + ", con Cedula: " + cedula + ", " + nombrePersona + ", " + direccion + ", " + calif);
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
                    } else
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

                    if ((calificacionPreparacion >= 9) || (califiacionExamen >= 9.5))
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

                    for (int i = 1; i <= 10; i++)
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
                    for (int i = 1; i <= 10; i += 2)
                    {
                        Console.WriteLine(i);

                    }

                    Console.WriteLine();
                    Console.WriteLine("En decremento: ");
                    for (int i = 10; i >= 1; i--)
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
                    for (int i = 0; i <= 20; i += 2)
                    {
                        contadorr += 1;
                        Console.WriteLine("{0}, Vueltas del ciclo numerico {1}", i, contadorr);
                    }
                    Console.WriteLine("Vueltas del ciclo numerico fue: {0}", contadorr);




                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 4 de acumulador de compras de productos");
                    int acumulador = 0;
                    int precio = 0;
                    int cantidadProductos = 0;

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
                    while (numeroW <= 10)
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
                    while (j <= 10); // mientras


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
                    Console.WriteLine("Array - Matriz unidimencional");
                    // tipo[] nombre = new tipo[tamaño]
                    string[] nombresss = new string[2] { "Sandra", "juan" };

                    double[] calificaciones1 = new double[4] { 14, 23, 3.2, 43 };
                    // otra forma:
                    double[] calificaciones2 = new double[] { 14, 23, 3.2, 43 };
                    Console.WriteLine("calificaciones: " + calificaciones1[1]);
                    // otra forma:
                    double[] calificaciones3 = { 14, 23, 3.2, 43 };

                    //decalaracion de matriz
                    int[] numeros;

                    // Instancia (creacion del objeto) e inicializacion
                    numeros = new int[] { 4, 5, 6, 7 };

                    double[] notas = new double[4];

                    notas[2] = 7.4;

                    Console.WriteLine("Nota 2: " + notas[2]);


                    double calificacionesFinal;
                    calificacionesFinal = notas[2] - 1;
                    Console.WriteLine("calificacionesFinal: " + calificacionesFinal);

                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 1 de array");
                    string[] nombres = new string[3];

                    //valores del array
                    nombres[0] = "sandra";
                    nombres[1] = "santi";
                    nombres[2] = "hilde";


                    for (byte i = 0; i <= 2; i++)
                    {
                        Console.WriteLine("Nombre: " + nombres[i]);
                    }
                    // Para saber la longitud del array
                    Console.WriteLine("La logitud de la array de nombres[3] es de: " + nombres.Length);


                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 2 de array");
                    string[] nombreA = new string[3];

                    for (byte i = 0; i <= 2; i++)
                    {
                        Console.Write("Ingrese el nombre {0}: ", i);
                        nombreA[i] = Console.ReadLine();
                    }

                    //mostrar los valores del array
                    Console.WriteLine("Los nombres ingresado son: ");
                    for (byte i = 0; i <= 2; i++)
                    {
                        Console.WriteLine("Nombre: " + nombreA[i]);
                    }


                    Console.WriteLine();
                    Console.WriteLine("Ejemplo 3 de array");
                    int cantidadNotas;
                    double sumaNotas = 0, promedioNotas = 0;
                    Console.Write("Ingrese la cantidad de notas del estudiante: ");
                    cantidadNotas = Convert.ToInt32(Console.ReadLine());

                    double[] notass = new double[cantidadNotas];

                    for (byte i = 0; i < cantidadNotas; i++)
                    {
                        Console.Write("Ingrese el valor de la nota {0}: ", i);
                        notass[i] = Convert.ToDouble(Console.ReadLine());
                        // Acumulado de notas
                        sumaNotas += notass[i];
                    }
                    Console.WriteLine("la suma es: " + sumaNotas + ", dividor entre " + cantidadNotas);
                    promedioNotas = sumaNotas / cantidadNotas;
                    Console.WriteLine("El promedio del estudiante fue de: {0}", promedioNotas);
                    break;




                case 15:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Matriz mutidimencional de 2");

                    //tipo[,] nombre = new tipo [filas, columnas]
                    // declaracion e intacio de una matriz de 2 dimenciones
                    double[,] ventas = new double[4, 3] { { 100, 33, 32 }, { 22, 33, 44 }, { 44, 33, 43 }, { 33, 55, 66 } };
                    var finzanzas = new double[4, 3] { { 100, 33, 32 }, { 22, 33, 44 }, { 44, 33, 43 }, { 33, 55, 66 } };


                    // declaracion e intacio de una matriz de 3 dimenciones
                    double[,,] ventasAño = new double[2, 2, 2];

                    double[,] compras = new double[4, 3] { { 10, 33, 32 },
                                                           { 22, 33, 44 },
                                                           { 44, 33, 43 },
                                                           { 33, 55, 66 } };
                    Console.WriteLine("matriz [4,3] en la posicion de compras[0,0]: " + compras[0, 0]);
                    Console.WriteLine("matriz [4,3] en la posicion de compras[1,1]: " + compras[1, 1]);
                    Console.WriteLine("matriz [4,3] en la posicion de compras[3,2]: " + compras[3, 2]);
                    int g, h;
                    for (g = 0; g < 4; g++)
                    {
                        Console.WriteLine("Fila {0}", g);

                        for (h = 0; h < 3; h++)
                        {
                            Console.WriteLine(compras[g, h]);
                        }
                    }

                    Console.WriteLine();
                    // Para saber la longitud de una matriz
                    Console.WriteLine("La logitud de la matriz de compras[4,3] es de: " + compras.Length);

                    //mostramos el tamaño de la primera dimencion de la matriz
                    Console.WriteLine("Tamaño de la primera dimencion de la matriz compras: " + compras.GetLength(0));
                    Console.WriteLine("Tamaño de la segunda dimencion de la matriz compras: " + compras.GetLength(1));

                    for (g = 0; g < compras.GetLength(0); g++)
                    {
                        Console.WriteLine("Fila {0}", g);

                        for (h = 0; h < compras.GetLength(1); h++)
                        {
                            Console.WriteLine(compras[g, h]);
                        }
                    }

                    break;




                case 16:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Pasar matrices como argumentos en metodos");

                    int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                    ImprimirMatriz(matriz);

                    double[,] matriz2d = new double[4, 3] { { 100, 33, 32 }, { 22, 33, 44 }, { 44, 33, 43 }, { 33, 55, 66 } };

                    ImprimirMatrizMulti(matriz2d);

                    Console.WriteLine();
                    break;



                case 17:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Clases y objetos, propiedades publicas - ejemplo de la clase Motocicleta");

                    // variable local
                    bool acelerar;

                    // [referencia del objeto] [Variable local] = new [creando el objeto de tipo Motocicleta()]           
                    // Instanciado a la clase Motocicleta
                    Motocicleta motocicleta1 = new Motocicleta();

                    motocicleta1.Acelerar();

                    // accedemos a los campos de la clase
                    motocicleta1.color = "negra";
                    motocicleta1.combustible = "Gasolina";

                    Console.WriteLine("El combustible de la motocipleta es: " + motocicleta1.combustible);

                    acelerar = motocicleta1.Acelerar();

                    if (acelerar)
                    {
                        Console.WriteLine("Acelerarando correctamente");
                    }

                    Motocicleta.Prueba();

                    Console.WriteLine();
                    break;



                case 18:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Clases y objetos, propiedades privadas - ejemplo de la clase Automovil");

                    // [referencia del objeto] [Variable local] = new [creando el objeto de tipo Automovil()]           
                    // Instanciado a la clase Automovil
                    Automovil automovil1 = new Automovil();

                    automovil1.Acelerar();
                    // Mostramos el campo privado
                    Console.WriteLine("El combustible de la automovil es: " + automovil1.Color);

                    //Asignandole un valor a un campo privado y mostrandolo
                    automovil1.Combustible = "Disel";
                    Console.WriteLine("El combustible es: {0}", automovil1.Combustible);

                    Console.WriteLine("Utilizando un metodo ToString() este es el valor: " + automovil1.ToString());

                    Console.WriteLine();
                    break;




                case 19:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Metodo sobrecargado - Ejemplo");

                    string nombreYApellido;
                    Nombres nombresVariableLocal = new Nombres();

                    nombreYApellido = nombresVariableLocal.Concatenar("Hilde", "Correa", "salcedo");
                    Console.WriteLine(nombreYApellido);
                    break;




                case 20:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Clase Random - Ejemplo");

                    Random random = new Random();

                    Console.WriteLine("Te ofrece un numero Random no negativo: " + random.Next());
                    Console.WriteLine("Te ofrece un numero Random en menor que 10 como le pasastes por argumento: " + random.Next(10));
                    Console.WriteLine("Te ofrece un numero Random en el rango de 10 a 20 como le pasastes 2 argumento: " + random.Next(10, 20));

                    Console.WriteLine();
                    break;




                case 21:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejemplo practico con clases, objetos, metodos, Random");

                    string nombreArgumento, apellidoArgumento, nip;

                    Console.WriteLine("Bienvenido a Monsters Inc.\n");
                    Console.WriteLine("Ingrese los siguientes campos que se le soliciten: ");

                    Console.Write("Nombre: ");
                    nombreArgumento = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellidoArgumento = Console.ReadLine();
                    Console.Write("Digite su NIP para asignarlo a su tarjeta bancaria: ");
                    nip = Console.ReadLine();

                    //Intacionaos a la clase empleado
                    Empleado empleado1 = new Empleado(nombreArgumento, apellidoArgumento);

                    empleado1.Nip = nip;

                    Console.WriteLine();

                    //mostrar la informacion de nuestro objeto
                    Console.WriteLine(empleado1.ToString());
                    break;




                case 22:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejemplo de cuenta bancaria - con clases, objetos, metodos");

                    //Variables
                    double montoArgumento, saldoInicialArgumento;
                    int opcion;
                    string nombresArgumento, apellidosArgumento, direccionArgumento, refArgumento;

                    Console.WriteLine("Esta apunto de crear una nueva cuenta, por favor presione cualquier tecla para continuar: ");
                    Console.ReadKey();

                    Console.WriteLine("\nIngrese la informacio que se le solicita a continuacion: ");

                    Console.Write("\nNombres: ");
                    nombresArgumento = Console.ReadLine();

                    Console.Write("Apellido: ");
                    apellidosArgumento = Console.ReadLine();

                    Console.Write("Direcion: ");
                    direccionArgumento = Console.ReadLine();

                    Console.Write("RFC: ");
                    refArgumento = Console.ReadLine();

                    Console.Write("Ingrese su deposito inicial: $");
                    saldoInicialArgumento = Convert.ToDouble(Console.ReadLine());

                    //Instanciamos a la clase
                    CuentaBancaria cliente1 = new CuentaBancaria(nombresArgumento, apellidosArgumento, saldoInicialArgumento, direccionArgumento, refArgumento);

                    Console.WriteLine("Felicidades, su cuenta ha sido creada con exito, presione cualquier tecla para continuar");
                    Console.ReadLine();

                    //Menu
                    do
                    {
                        Console.WriteLine("\n1. Deposito");
                        Console.WriteLine("2. Retiro");
                        Console.WriteLine("3. Consultar Saldo");
                        Console.WriteLine("4. Mostrar Informacion de la cuenta");
                        Console.WriteLine("5. Salir");

                        Console.Write("\nElige una opcion: ");
                        opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese el monto a depositar: $");
                                montoArgumento = Convert.ToDouble(Console.ReadLine());

                                cliente1.Deposito(montoArgumento);
                                break;

                            case 2:
                                Console.Write("Ingrese el monto a retirar: $");
                                montoArgumento = Convert.ToDouble(Console.ReadLine());

                                cliente1.Retiro(montoArgumento);
                                break;

                            case 3:
                                cliente1.ConsultarSaldo();

                                break;

                            case 4:
                                Console.WriteLine(cliente1.ToString());

                                break;
                        }

                    } while (opcion >= 1 && opcion <= 4);


                    Console.WriteLine("");
                    break;




                case 23:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Tipos de referencias Object y tambien convertiones explicitas e implicitas");

                    //Object
                    Object numeroEntero = 18;
                    Object cadena = "Hola";
                    Object flotante = 3.14;

                    Object[] numerosMatriz = new object[2];
                    numerosMatriz[0] = 1;
                    numerosMatriz[1] = "Luis";

                    //conversiones explicitas - son las sencillas como:
                    byte numeroByte = 10;
                    int numeroInt = numeroByte;
                    Console.WriteLine("Conversiones explicita de byte a Int: " + numeroInt);

                    //conversiones implicitas -  con (T)E
                    int numGrade = 500;
                    byte numeroPequeño = (byte)numGrade;
                    Console.WriteLine("Conversiones implicita con (T)E de Int a byte: " + numeroPequeño);

                    //(T)E
                    //conversion Boxing Unboxing [ tipo de valor -> object] es una conversion implicita
                    object numero1 = 5;
                    object numero2 = 20;
                    object resultadoNumerico;

                    //resultado = numero1 + 10;    //No es posible Object convertir a Int

                    //esta manera si en Boxing:
                    int a = 50;
                    object obj = a;

                    //Unboxing [objeto -> tipo de valor] explicita
                    resultadoNumerico = (int)numero1 + 10;
                    Console.WriteLine("resultado de conversion de objeto con suma de Int: " + resultadoNumerico);

                    Console.WriteLine();
                    break;




                case 24:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("Ejemplo SIN Genericos - Ejemplo de Alumnos");
                    Console.WriteLine("se han agragado las calificaciones de manera manual en el sistema: ");

                    //variables locales
                    Alumno valorElemento;

                    //Instanciando la clase
                    GuardaObjetosSinGenerico objeto1 = new GuardaObjetosSinGenerico(3); // con 3 elementos

                    //Intanciamos a la clase "Alumno"
                    Alumno alumno1 = new Alumno(8.5);
                    Alumno alumno2 = new Alumno(10);
                    Alumno alumno3 = new Alumno(6.8);

                    //Agregar objetos a la clase "GuardarObjetos"
                    objeto1.AgregarElementos(alumno1);
                    objeto1.AgregarElementos(alumno2);
                    objeto1.AgregarElementos(alumno3); 

                    //Obtener elementos manualmente:
                    valorElemento = (Alumno)objeto1.ObtenerElementos(0); // el Alumno con su calificacion que buscamos en la posicion
                    Console.WriteLine(valorElemento.Calificacion);

                    Console.WriteLine("Aunque funciona la careacion de objetos con 1 solo objeto, en este caso Alumnos, el problema radica cuando son demaciados objetos");
                break;



                case 25:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("El uso de los Genericos - Ejemplo de Alumnos");
                    Console.WriteLine("se han agragado las calificaciones de manera manual en el sistema: ");

                    //variables locales
                    Alumno valorElementoEjemploGenerico;

                    //Instanciando la clase
                    GuardaObjetosConGenerico<Alumno> objeto = new GuardaObjetosConGenerico<Alumno>(3); // con 3 elementos

                    //Intanciamos a la clase "Alumno"
                    Alumno alumno4 = new Alumno(8.5);
                    Alumno alumno5 = new Alumno(10);
                    Alumno alumno6 = new Alumno(6.8);

                    //Agregar objetos a la clase "GuardarObjetos"
                    objeto.AgregarElementos(alumno4);
                    objeto.AgregarElementos(alumno5);
                    objeto.AgregarElementos(alumno6);

                    //Obtener elementos manualmente:
                    valorElementoEjemploGenerico = (Alumno)objeto.ObtenerElementos(0); // el Alumno con su calificacion que buscamos en la posicion
                    Console.WriteLine(valorElementoEjemploGenerico.Calificacion);

                    Console.WriteLine();
                break;




                case 26:
                    Console.WriteLine();
                    Console.WriteLine("#################");
                    Console.WriteLine("");

                    List<string> Personas = new List<string>(); 

                    Console.WriteLine();
                break;


                default:
                    Console.WriteLine("Número no reconocido");
                break;
            }
            Console.ReadKey();

        }// Fin del metodo MAIN ⬆️










        //metodos estaticos ⬇️
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


        static void ImprimirMatriz(int[] matrizParametros)
        {
            int i;
            for(i = 0; i < matrizParametros.Length; i++)
            {
                Console.WriteLine(matrizParametros[i]);
            }
        }


        static void ImprimirMatrizMulti(double[,] matriz2dParametros)
        {
            int i, j;
            for (i = 0; i < matriz2dParametros.GetLength(0); i++)
            {
                Console.WriteLine("Fila {0}", i);

                for (j = 0; j < matriz2dParametros.GetLength(1); j++)
                {
                    Console.WriteLine(matriz2dParametros[i, j]);
                }
            }
        }
    }












    //Clases ⬇️

    public class Motocicleta
    {
        //Campos publicos
        public string color, modelo, combustible;
        public byte año, numPuertas;
        public int ccMotor;

        //Metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            Prueba();
            return acelerar;
        }

        // metodo estatico
        public static void Prueba()
        {
            Console.WriteLine("Este es un metodo estatico");
        }

        public bool Frenar()
        {
            bool acelerar = true;
            Console.WriteLine("Frenar");
            return acelerar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de Velocidades");
        }
    }




    public class Automovil
    {
        //Campos publicos
        private string color = "rojo", modelo = "HFH-456", combustible, año = "2000", numPuertas = "4";
        private int ccMotor = 1500;

        // ejemplo para campos inicializadas con el constructor
        private string asientos, colorTablero;
        private bool camaraTrasera;


        //Constructor
        public Automovil(){
            asientos = "piel";
            colorTablero = "Cafe";
            camaraTrasera = false;
        }



        // propiedades
        //[acceso] [Tipo] [Nomre]
        public string Color
        {
            //descriptor de acceso "get" es obtener
            get { return color; }
        }

        public string Combustible
        {
            //descripto de acceso "get" es obtener
            get => combustible;   //get { return combustible; }   es lo mismo

            //descriptor de acceso "set" es colocar
            set => combustible = value;   //set { combustible = value; }   es lo mismo
        }



        //Metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            return acelerar;
        }


        public bool Frenar()
        {
            bool acelerar = true;
            Console.WriteLine("Frenar");
            return acelerar;
        }

        public void Velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de Velocidades");
        }



        // Invalidado el metodo ToString
        public override string ToString()
        {
            //string mensaje;
            //mensaje = "el color es: " + color;
            //return mensaje;

            //return "el color es: " + color;

            string mensaje;

            mensaje = "\n\nValores de un automovil: " + "\nModelo: " + modelo + "\nColor: " + color + "\naño: " + año + "\nPuertas: " + numPuertas + "\nTipo de combustible: " + combustible + "\nMotor: " + ccMotor + "\nasientos: " + asientos + "\ncolor del Tablero: " + colorTablero + "\ncamaraTrasera: " + camaraTrasera;
            return mensaje;
        }
    }



    class Nombres
    {
        //metodo sobrecargar
        public string Concatenar(string nombresParametro, string apellidoParametro)
        {
            string nombreApellido;

            nombreApellido = "Nombre: " + nombresParametro + " - Apellido: " + apellidoParametro;

            return nombreApellido;
        }

        public string Concatenar(string nombresParametro, string apellidoParametro, string apellido2Parametro)
        {
            string nombreApellido;

            nombreApellido = "Nombre: " + nombresParametro + " - Apellido 1: " + apellidoParametro + " - Apellido 2: " + apellido2Parametro;

            return nombreApellido;
        }
    }




    class Empleado
    {
        private string nombre, apellido, id, locker, nip, banco;

        //constructor
        public Empleado(string nombreParametro, string apellidoParametro)
        {
            nombre = nombreParametro;
            apellido = apellidoParametro;

            //llamando a los metodos para generar los numeros aleatorios
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();
        }

        //Instanciamos a Random
        Random random = new Random();

        //propiedades
        public string Nip
        {
            set => nip = value;
        }

        //Metodos
        private string GenerarID()
        {
            //Variables
            int i, numero;
            string id = "";

            for(i=0; i <10; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {
            //Variables
            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);

                locker += numero.ToString();
            }
            return locker;
        }


        private string AsignarBanco()
        {
            //variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;

                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "Empleado: " + nombre + " " + apellido + "\nNumero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco; 

            return mensaje;
        }
    }





    class CuentaBancaria
    {
        //campos
        private string nombre, apellido, direccion, rfc;
        private double saldo;

        //Constructor
        public CuentaBancaria(string nombreParametro, string apellidoParametro, double saldoParametro, string direccionParametro ,string rfcParametro) 
        { 
            nombre = nombreParametro;
            apellido = apellidoParametro;
            saldo = saldoParametro;
            direccion = direccionParametro;
            rfc = rfcParametro;
        }

        public double Deposito(double montoPa)
        {
            saldo += montoPa;
            return saldo;
        }

        public double Retiro(double montoPa)
        {
            if (saldo >= montoPa)
            {
                saldo -= montoPa;
            }
            else
            {
                Console.WriteLine("¡Saldo es insuficiente!");
            }
            return saldo;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Su saldo es: ${0}", saldo);
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = "\nTitular: " + nombre + " " + apellido + "\nRFC: " + rfc + "\nDirección: " + direccion + "\nSaldo: " + saldo;

            return mensaje;
        }
    }



   

    //Clase No usa generico
    class GuardaObjetosSinGenerico
    {
        //Campos
        private int i = 0;
        private object[] matrizElementos;

        //Constructor
        public GuardaObjetosSinGenerico(int elementoParamatro)
        {
            matrizElementos = new object[elementoParamatro];
        }

        public void AgregarElementos(object elementoParamatro)
        {
            matrizElementos[i] = elementoParamatro;
            i++;
        }

        public object ObtenerElementos(int elementoParamatro)
        {
            return matrizElementos[elementoParamatro];
        }
    }





    class Alumno
    {
        //campos
        double calificacion;

        //constructor
        public Alumno(double calificacionParametro)
        {
            calificacion = calificacionParametro;
        }

        //propiedades
        public double Calificacion
        {
            get => calificacion;
        }
    }






    // Clase CON genericos
    class GuardaObjetosConGenerico<T>
    {
        //Campos
        private int i = 0;
        private T[] matrizElementos;

        //Constructor
        public GuardaObjetosConGenerico(int elementoParamatro)
        {
            matrizElementos = new T[elementoParamatro];
        }

        public void AgregarElementos(T elementoParamatro)
        {
            matrizElementos[i] = elementoParamatro;
            i++;
        }

        public T ObtenerElementos(int elementoParamatro)
        {
            return matrizElementos[elementoParamatro];
        }
    }
}
