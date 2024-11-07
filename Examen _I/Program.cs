using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            // Ingreso de datos del alumno
            Console.Write("Ingrese nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese correo electrónico: ");
            asignatura.Email = Console.ReadLine();

            // Ingreso de datos de la asignatura
            Console.Write("Ingrese nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese horario de la clase: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            // Ingreso de notas
            Console.Write("Ingrese nota del primer parcial: ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30)
            {
                Console.WriteLine("La nota del primer parcial sobrepasa del 30%");
                return;
            }

            Console.Write("Ingrese nota del segundo parcial: ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30)
            {
                Console.WriteLine("La nota del segundo parcial sobrepasa del 30%");
                return;
            }

            Console.Write("Ingrese nota del tercer parcial: ");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40)
            {
                Console.WriteLine("La nota del tercer parcial sobrepasa del 40%");
                return;
            }

            // Impresión de resultados
            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese valores válidos.");
        }
    }
}
