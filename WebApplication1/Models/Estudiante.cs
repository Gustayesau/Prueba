using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public int Promedio { get; set; }
        public DateTime fecha { get; set; }

        public List<Estudiante> Lista()
        {
            //Estudiante nuevo = new Estudiante()
            //{
              
            //    Carnet = 1,
            //    Nombre = "Gustavo",
            //    Materia = "Matematica",
            //    Promedio = 10,
            //    fecha = DateTime.Now
            //};
            //Estudiante nuevo2 = new Estudiante()
            //{
               
            //    Carnet = 1,
            //    Nombre = "Gustavo",
            //    Materia = "Matematica",
            //    Promedio = 10,
            //    fecha = DateTime.Now
            //};
            //Estudiante nuevo3 = new Estudiante()
            //{
             
            //    Carnet = 1,
            //    Nombre = "Gustavo",
            //    Materia = "Matematica",
            //    Promedio = 10,
            //    fecha = DateTime.Now
            //};
            //Estudiante nuevo4 = new Estudiante()
            //{
                
            //    Carnet = 1,
            //    Nombre = "Gustavo",
            //    Materia = "Matematica",
            //    Promedio = 10,
            //    fecha = DateTime.Now
            //};
            var estudiante = new Estudiante()
            {            
                Carnet = 1,
                Nombre = "Gustavo",
                Materia = "Matematica",
                Promedio = 10,
                fecha = DateTime.Now
            };
            var estudiante2 = new Estudiante()
            {
                Carnet = 2,
                Nombre = "Juan",
                Materia = "Lenguaje",
                Promedio = 9,
                fecha = DateTime.Now
            };
            var estudiante3 = new Estudiante()
            {
                Carnet = 3,
                Nombre = "Julio",
                Materia = "Ciencia",
                Promedio = 8,
                fecha = DateTime.Now
            };

            return new List<Estudiante>() {estudiante,estudiante2,estudiante3};
            
        }
       
    }

}