using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServicioEntregaPaquetes.Modelo;
using ServicioEntregaPaquetes.Datos;

namespace ServicioEntregaPaquetes.Datos
{
    public class PackagesRepositories
    {
        private static List<Package> data = new List<Package>();
        private static List<Person> people = new List<Person>();

        Person sender = new Person(001, "Geovanni padilla", "Nuevo bosque mz16 lt10 2etapa","Cartagena", "Bolívar", 13001);

        Person recipients = new Person(002, "Edwin puertas", "UTB","Cartagena", "Bolívar", 13001);

        public PackagesRepositories()
        {
            

        }

        public IEnumerable<Package> getPackages()
        {


            return data;
        }

        public void addPerson(Person personas)
        {
            people.Add(personas);
        }

        public void addPackage(Package personas)
        {
            data.Add(personas);
        }

        public IEnumerable<Person> getPeople()
        {

            return people;
        }
    }
}