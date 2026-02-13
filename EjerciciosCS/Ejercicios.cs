using System;
using System.Collections.Generic;

namespace EjerciciosCS
{
    /// <summary>
    /// Ejercicios de C# para practicar Arrays y Listas
    /// </summary>
    public class Ejercicios
    {
        private int[] _arrayGenerado = Array.Empty<int>();
        /// <summary>
        /// 1. EL PROFESOR PEREZOSO (Arrays)
        /// 
        /// PISTAS:
        /// - Crea un array de 'double' llamado 'temperaturas' con 5 elementos
        /// - Asigna valores inventados directamente en el código (ej: 23.5, 24.0, etc.)
        /// - Usa un bucle 'for' para sumar todas las temperaturas
        /// - Divide la suma entre 5 para obtener el promedio
        /// - Retorna el promedio calculado
        /// </summary>
        /// <returns>El promedio de las 5 temperaturas</returns>
        public double CalcularPromedioTemperatura()
        {
            // TODO: Implementar el cálculo del promedio de temperaturas
            // Crear array con 5 temperaturas
            double[] temperaturas = { 23.5, 24.0, 22.8, 25.2, 23.9 };
            // Sumar todas las temperaturas
            double suma = 0.0;
            
            for (int i = 0; i < temperaturas.Length; i++)
            {
            suma = suma + temperaturas[i];
            }
            
            // Calcular el promedio
           double promedio = suma / temperaturas.Length;
        
           return promedio;
        }


        /// <summary>
        /// 2. LISTA DE SUPERMERCADO (Listas)
        /// 
        /// PISTAS:
        /// - Crea una 'List<string>' para almacenar los productos
        /// - Usa Console.WriteLine() para pedir al usuario que ingrese productos
        /// - Usa un bucle 'while (true)' para pedir productos continuamente
        /// - Usa Console.ReadLine() para leer lo que escribe el usuario
        /// - Si el usuario escribe "salir", termina el bucle con 'break'
        /// - Usa 'foreach' para imprimir todos los productos de la lista
        /// </summary>
        /// <returns>Una List<string> con los productos ingresados por el usuario</returns>
        public List<string> CrearListaCompras()
        {
            // TODO: Implementar la lista de compras interactiva
            // Crear la lista de compras
            List<string> listaCompras = new List<string>();

            // Mostrar instrucciones al usuario
            Console.WriteLine("Ingrese productos para su lista de compras.");
            Console.WriteLine("Escriba 'salir' cuando termine.");

            // Bucle infinito para pedir productos
            while (true)
           {
              Console.Write("Producto: ");
              string producto = Console.ReadLine();
        
              // Si escribe "salir", terminar el bucle
            
             if (producto == "salir")
             {
             break;
            }

            // Agregar el producto a la lista
           listaCompras.Add(producto);
        }
    
          // Mostrar todos los productos
          Console.WriteLine("\nSu lista de compras:");
        foreach (string producto in listaCompras)
        {
           Console.WriteLine("- " + producto);
        }

            return listaCompras;
        }



        /// <summary>
        /// 3. EL BUSCADOR (Reto)
        /// 
        /// PISTAS:
        /// - Crea un 'Random' para generar números aleatorios
        /// - Crea un array de 'int' con 10 elementos
        /// - Usa un bucle 'for' para llenar el array con números aleatorios (0-100)
        ///   Puedes usar: random.Next(0, 101)
        /// - Recorre el array con otro bucle 'for' buscando el número de la variable 'numeroBuscado'
        /// - Si encuentras el número, retorna 'true'
        /// - Si terminas el bucle sin encontrarlo, retorna 'false'
        /// 
        /// BONUS: Muestra los números generados en el array
        /// </summary>
        /// <param name="numeroBuscado">El número que el usuario quiere buscar</param>
        /// <returns>true si el número está en el array, false si no</returns>
        public bool BuscarNumeroDinamico(int numeroBuscado)
        {
            // TODO: Implementar la búsqueda de número en array aleatorio
            bool encontrado = false;
            Random random = new Random();
            
            // Crear array de 10 números
            int[] numeros = new int[10];

            // Llenar el array con números aleatorios (0-100)
            for (int i = 0; i < numeros.Length; i++)
            {
             numeros[i] = random.Next(0, 101);
            }

            // BONUS: Mostrar los números generados
           Console.WriteLine("Números generados:");
           for (int i = 0; i < numeros.Length; i++)
          {
            Console.WriteLine(numeros[i]);
          }
    
           // Buscar el número en el array
          for (int i = 0; i < numeros.Length; i++)
          {
              if (numeros[i] == numeroBuscado)
              {
                 encontrado = true;
                 break;
               }
           }     
         return encontrado;
        
        }
        
    }
}
