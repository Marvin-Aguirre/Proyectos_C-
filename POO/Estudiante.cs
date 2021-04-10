using System;

namespace POO
{
    class Estudiantes
    {
       public string nombre;
       public int edad;
       public string carnet;
       public Boolean solvente;
       public Estudiantes (string nombre, int edad, string carnet, Boolean solvente){
           this.nombre=nombre;
           this.edad=edad;
           this.carnet=carnet;
           this.solvente=solvente;
       }
    }
    class Curso{
        public string nom_Curso;
        public int nota_Parcial1;
        public int nota_Parcial2;
        public int nota_Final;
        public Curso (string nom_Curso, int nota_Parcial1, int nota_Parcial2, int nota_Final){
            this.nom_Curso=nom_Curso;
            this.nota_Parcial1=nota_Parcial1;
            this.nota_Parcial2=nota_Parcial2;
            this.nota_Final=nota_Final;
        }
    }
}