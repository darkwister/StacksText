using System.Collections;
using Stacks.classes;

namespace Stacks;
class Program
{
    public static void Main(string[] args)
    {

        byte opc;
        string cadenaEj2;
        char caracterEj2;
        Pila pilaEj1 = new();
        Pila pilaEj2 = new();

        Console.WriteLine("Elija una de las siguientes opciones: ");
        Console.WriteLine("1. Ejemplo I - Parte I");
        Console.WriteLine("2. Ejemplo I - Parte II");
        Console.WriteLine("3. Ejemplo II");
        Console.WriteLine("4. Ejercicio I");
        Console.WriteLine("5. Ejercicio II");
        Console.WriteLine("6. Salir");
        Console.WriteLine("Ingrese una opcion: ");
        opc = Convert.ToByte(Console.ReadLine());
        switch (opc){
            case 1:
                Console.WriteLine("\t\t---Parte I---");
                pilaEj1.Push('p');
                pilaEj1.Push('b');
                pilaEj1.Push('z');
                pilaEj1.Push('s');
                pilaEj1.Mostrar();
                Console.ReadLine();
                pilaEj1.Pop();
                pilaEj1.Mostrar();
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("\t\t---Parte II---");
                Console.WriteLine("Ingrese una frase: ");
                cadenaEj2 = Console.ReadLine()!;
                for (int i = 0; i < cadenaEj2.Length; i++)
                {
                    caracterEj2 = Convert.ToChar(cadenaEj2.Substring(i, 1));
                    pilaEj2.Push(caracterEj2);
                }
                pilaEj2.Mostrar();
                Console.ReadLine();
                break;
            case 3:
                Stack pila = new();
                byte opcionEj2;
                do{
                    Console.Clear();
                    Console.WriteLine("\t\t---Ejemplo II---");
                    Console.WriteLine("1. Agregar elemento");
                    Console.WriteLine("2. Eliminar elemento");
                    Console.WriteLine("3. Vaciar pila");
                    Console.WriteLine("4. Mostrar pila");
                    Console.WriteLine("5. Salir");
                    opcionEj2 = Convert.ToByte(Console.ReadLine());
                    switch(opcionEj2){
                        case 1:
                        Console.WriteLine("Ingrese un elemento: ");
                        try{
                            int value = Convert.ToInt32(Console.ReadLine()!);
                            if (value >= 99 || value <= 0){
                                Console.WriteLine("El valor debe estar entre 1 y 99");
                            }
                            else{
                                pila.Push(value);
                                ImprimirPila(pila);
                            }
                        }
                        catch{
                            Console.WriteLine("Solo numeros del 1 al 99");
                        }
                        break;
                        case 2:
                            if (pila.Count > 0){
                                int valor = (int)pila.Pop();
                                Console.WriteLine("Elemento eliminado: {0}",valor);
                            }
                            else{
                                ImprimirPila(pila);
                            }
                        break;
                        case 3:
                            pila.Clear();
                            ImprimirPila(pila);
                        break;
                        case 4:
                            ImprimirPila(pila);
                        break;
                        case 5:
                        break;
                        default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                }
                while (opcionEj2 != 5);
                Console.WriteLine("Adios");
                break;
            case 4: 
                Stack empleados = new();
                byte opcionEjercicio1;
                do{
                    Console.Clear();
                    Console.WriteLine("\t\t---Ejercicio I---");
                    Console.WriteLine("1. Agregar empleado");
                    Console.WriteLine("2. Eliminar empleado");
                    Console.WriteLine("3. Mostrar empleados");
                    Console.WriteLine("4. Salir");
                    opcionEjercicio1 = Convert.ToByte(Console.ReadLine());
                    switch(opcionEjercicio1){
                        case 1:
                            Console.WriteLine("Ingrese un empleado: ");
                            Console.WriteLine("Carnet: ");
                            string CarnetEmpleado = Console.ReadLine()!;
                            Console.WriteLine("Nombre: ");
                            string NombreEmpleado = Console.ReadLine()!;
                            Console.WriteLine("Sueldo: ");
                            string SueldoEmpleado = Console.ReadLine()!;
                            DateTime Fecha = DateTime.Today;
                            Empleados empleado = new()
                            {
                                Nombre = NombreEmpleado,
                                Carnet = CarnetEmpleado,
                                Salario = SueldoEmpleado,
                                Fecha = Fecha
                            };
                            empleados.Push(empleado);
                            break;
                        case 2:
                            empleados.Pop();
                            break;
                        case 3:
                            ImprimirEmpleados(empleados);
                            break;
                        case 4:
                        break;
                        default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                }
                while (opcionEjercicio1 != 4);
                Console.WriteLine("Adios a los empleados");
                break;
            case 5:
            byte opcionEjercicio2;
            do{
                Console.Clear();
                Console.WriteLine("\t\t---Ejercicio II---");
                Console.WriteLine("Elija una de las siguientes opciones: ");
                Console.WriteLine("1. Verificar expresión matemática");
                Console.WriteLine("2. Verificar si una palabra es palíndromo");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Ingrese una opción: ");
                opcionEjercicio2 = Convert.ToByte(Console.ReadLine());
                
                    switch (opcionEjercicio2)
                    {
                        case 1:
                            Console.WriteLine("Ingrese una expresión matemática: ");
                            string expresion = Console.ReadLine()!;
                            if (ExpresionMatematica.EstaBalanceada(expresion))
                                {
                                Console.WriteLine("Los paréntesis están balanceados.");
                                Console.ReadKey();
                                }
                            else
                                {
                                Console.WriteLine("Los paréntesis NO están balanceados.");
                                Console.ReadKey();
                                }
                            break;
                        
                        case 2:
                            Console.WriteLine("Ingrese una palabra: ");
                            string palabra = Console.ReadLine()!;
                            if (Palindromo.EsPalindromo(palabra)){
                                Console.WriteLine("La palabra es un palíndromo.");
                                Console.Read();
                                }
                            else
                                {
                                Console.WriteLine("La palabra NO es un palíndromo.");
                                Console.Read();
                                }
                            break;

                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                }
                while (opcionEjercicio2 != 3);
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Opcion incorrecta");
                break;
        }
    }
    public static void ImprimirPila(Stack pila){
        if (pila.Count > 0){
            Console.WriteLine("");
            foreach (int dato in pila)
            {
                Console.WriteLine("|      |");
                if (dato < 10){
                    Console.WriteLine("| 0{0}   |",dato);
                }
                else{
                    Console.WriteLine("| {0}   |",dato);
                }
                Console.WriteLine("|______|");
            }
            Console.WriteLine("\n Presione cualquier tecla para seguir");
            Console.ReadKey();
        }
        else{
            Console.WriteLine("La pila esta vacia");
        }
    }
    public static void ImprimirEmpleados(Stack pila){
        if (pila.Count > 0){
            Console.WriteLine("");
            foreach (Empleados dato in pila)
            {
                Console.WriteLine("| {0} - {1}  |",dato.Nombre, dato.Carnet);
            }
            Console.WriteLine("\n Presione cualquier tecla para seguir");
            Console.ReadKey();
        }
        else{
            Console.WriteLine("La pila esta vacia");
        }
    }
}