using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string Titulo;
        public int Año;
        public string Pais;
        public string Director;
        public List<Actor> actores = new List<Actor>();

        public Pelicula()
        {
        }

        //Constructores
        public Pelicula (string titulo, int año, string pais, string director)
    {
        Titulo = titulo;
        Año = año;
        Pais = pais;
        Director = director;
    }
        //Métodos
     
        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año} {Pais} {Director})");
        }


    }

    public class Actor
    {
        //Propiedades
        private string Nombre;
        private int Año;
        //Constructores
        public Actor(string nombre, int año)
        {
            Nombre = nombre;
            Año = año;
        }

        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> peliculas = new List<Pelicula>();
            Pelicula p1 = new Pelicula();
            p1.Titulo = "El padrino";
            p1.Año = 1972;
            p1.Pais = "EEUU";
            p1.Director = "Francis Ford Coppola";
            p1.actores.Add(new Actor("Marlon Brando", 1924));
            p1.actores.Add(new Actor("Al Pacino", 1940));
            p1.actores.Add(new Actor("James Caan", 1940));
            peliculas.Add(p1);

            Pelicula p2 = new Pelicula();
            p2.Titulo = "El padrino 2";
            p2.Año = 1974;
            p2.Pais = "EEUU";
            p2.Director = "Francis Ford Coppola";
            p2.actores.Add(new Actor("Al Pacino", 1940));
            p2.actores.Add(new Actor("Robert Duvall", 1931));
            p2.actores.Add(new Actor("Diane Keaton", 1946));
            peliculas.Add(p2);

            Pelicula p3 = new Pelicula();
            p3.Titulo = "El padrino 3";
            p3.Año = 1990;
            p3.Pais = "EEUU";
            p3.Director = "Francis Ford Coppola";
            p3.actores.Add(new Actor("Al Pacino", 1940));
            p3.actores.Add(new Actor("Andy García", 1956));
            p3.actores.Add(new Actor("Mariel Hemingway", 1961));
            peliculas.Add(p3);

            foreach (Pelicula p in peliculas)
            {
                p.Imprime();
                foreach (Actor a in p.actores)
                {
                    a.Imprime();
                }
            }
        }
    }
}
