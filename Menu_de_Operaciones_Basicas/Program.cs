using System;

namespace Menu_de_Operaciones_Basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n"
            +"       _____________________________________\n"
            +"      |        OPERACIONES BASICAS          |\n");
            try
            {
                int opcionMenu;
                do{
                    Console.WriteLine("Selecciona, la operacion que deseas realizar\n"
                    +"1.Suma\n"
                    +"2.Resta\n"
                    +"3.Multiplicacion\n"
                    +"4.Division\n"
                    +"5.Modulo\n"
                    +"6. Salir del Programa\n");
                    opcionMenu=Convert.ToInt32(System.Console.ReadLine());
                    switch (opcionMenu){

                        case 1:
                            Console.Write("Ingresa los datos a operar\n"
                            +"Dato 1=  ");
                            double date1=Convert.ToDouble(System.Console.ReadLine());
                            Console.Write("Dato 2=  ");
                            double date2=Convert.ToDouble(System.Console.ReadLine());
                            Console.WriteLine("\nLa suma de "+date1+" + "+date2+" es: "+ (date1+date2)+"\n");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        break; 

                        case 2:
                            Console.Write("Ingresa los datos a operar\n"
                            +"Dato 1=  ");
                            double a=Convert.ToDouble(System.Console.ReadLine());
                            Console.Write("Dato 2=  ");
                            double b=Convert.ToDouble(System.Console.ReadLine());
                            Console.WriteLine("\nLa resta de "+a+" - "+b+" es: "+ (a-b)+"\n");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        break;  

                        case 3:
                            Console.Write("Ingresa los datos a operar\n"
                            +"Dato 1=  ");
                            double a1=Convert.ToDouble(System.Console.ReadLine());
                            Console.Write("Dato 2=  ");
                            double b1=Convert.ToDouble(System.Console.ReadLine());
                            Console.WriteLine("\nLa multiplicacion de "+a1+" * "+b1+" es: "+ (a1*b1)+"\n");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        break; 

                        case 4:
                            Console.Write("Ingresa los datos a operar\n"
                            +"Dato 1=  ");
                            double a2=Convert.ToDouble(System.Console.ReadLine());
                            Console.Write("Dato 2=  ");
                            double b2=Convert.ToDouble(System.Console.ReadLine());
                            if(b2==0){
                                Console.WriteLine("\nERROR\n");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }else{
                                Console.WriteLine("\nLa division de "+a2+" / "+b2+" es: "+ (a2/b2)+"\n");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        break; 

                        case 5:
                            Console.Write("Ingresa los datos a operar\n"
                            +"Dato 1=  ");
                            double a3=Convert.ToDouble(System.Console.ReadLine());
                            Console.Write("Dato 2=  ");
                            double b3=Convert.ToDouble(System.Console.ReadLine());
                            Console.WriteLine("\nEl modulo de "+a3+" y "+b3+" es: "+ (a3%b3)+"\n");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        break;  

                        case 6:
                            Console.WriteLine("Ejecucion del programa finalizada.");
                        break; 
                        default:
                            Console.WriteLine("\nLa opcion ingresada no es valida\n");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                        break;
                    }
                }while(opcionMenu!=6);
                
            }
            catch (System.Exception)
            {  
                Console.WriteLine("El valor ingresado es erroneo");
            }
        }
    }
}
