using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    ///< Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un primer número entero. 
    ///Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". 
    ///Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos.>  
     
    class Program
    {
         int n1, n2, aux, cant = 2; ///<n1 = 1° numero a ingresar, n2= 2°número a ingresar, 
                                    ///aux = guarda los numeros para que sean analizados por el programa
                                    ///cant = cantidad de numeros a ingresar>
         string linea;
        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Producto();         ///<funcion que multiplica los numeros ingresados>
            Console.ReadKey();
        }
        private void Cargar(){

            bool error = false;    ///<por si se llegase a producir un error> 

            Console.WriteLine("Escriba dos números enteros para multiplicarlos entre sí");
            for (int i = 1; i <= cant; i++)
            {
                error = false;              
                Console.Write("{0}°: ", i);
                try             ///<1° Try_catch_finally>
                {
                    linea = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Ingrese solo valores númericos");
                }
                finally
                {
                    error = true;
                    aux = 0;
                }
                if(i==1 && !error){
                    n1=int.Parse(linea);
                    aux = n1;
                }else if(!error){
                    n2=int.Parse(linea);
                    aux=n2;
                }
                while (aux == 0) ///<en caso de los valores ingresados sean erroneos>
                {                    
                    Console.WriteLine();
                    if(!error)Console.WriteLine("El producto de 0 por cualquier número es 0");
                    error = false;
                    Console.WriteLine("Reingrese nuevamente el numero: ");
                    Console.Write("{0}°: ", i);

                    try   ///<2° Try_catch_finally>
                    {
                        linea = Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine ("Ingrese solo valores numericos");
                        aux = 0;
                        error = true;
                    }

                    if (i == 1 && !error)
                    {
                        n1 = int.Parse(linea);
                        aux = n1;
                    }
                    else if(!error)
                    {
                        n2 = int.Parse(linea);
                        aux = n2;
                    }
                }
            }
        }
        private void Producto()
        {
           int result=n1*n2;
           Console.WriteLine();
           Console.Write("El producto entre {1} y {2} = {0} ", result, n1, n2);
        }
    }
}

