using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiantes[] listaEstudiantes = new Estudiantes [5];
            Curso[] curso = new Curso[5];
            
            int cont =0;

            while(cont < 5){
                Console.WriteLine("INGRESE NOMBRE: ");
                string nombre=Console.ReadLine();
                Console.WriteLine("INGRESE EDAD:");
                int edad=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INGRESE CARNET:");
                string carnet =Console.ReadLine();
                Console.WriteLine("INDIQUE SI ESTA SOLVENTE:");
                Boolean solvente= Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("NOMBRE DE CURSO:");
                string nom_Curso=Console.ReadLine();
                Console.WriteLine("INGRESE NOTA_PARCIAL1:");
                int nota_Parcial1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INGRESE NOTA_PARCIAL2:");
                int nota_Parcial2=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INGRESE NOTA FINAL:");
                int nota_Final=Convert.ToInt32(Console.ReadLine());
                
                Estudiantes estudiante = new Estudiantes (nombre, edad, carnet, solvente);
                listaEstudiantes[cont] = estudiante;
                Curso Cursos = new Curso(nom_Curso,nota_Parcial1,nota_Parcial2,nota_Final);
                curso[cont] = Cursos;
                cont ++;
            }
            Console.WriteLine("LISTA****");
            for (int i = 0; i < 5; i++)
            {
                Estudiantes estudiante= listaEstudiantes[i];
                Curso Cursos= curso[i];
                Console.WriteLine("NOMBRE DEL ESTUDIANTE: "+estudiante.nombre+" CARNET: "+estudiante.carnet+" EDAD: "+estudiante.edad+" SOLVENTE: "+estudiante.solvente);
                Console.WriteLine("NOMBRE DEL CURSO: "+Cursos.nom_Curso+" NOTA PARCIAL1: "+Cursos.nota_Parcial1+" NOTA PARCIAL2: "+Cursos.nota_Parcial2+" NOTA FINAL: "+Cursos.nota_Final+"\n");
                
            }
        }
    }
}
