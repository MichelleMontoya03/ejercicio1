using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor ingrese la siguiente informacion");


            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine("por favor digite su cedula");
                string cedula = Console.ReadLine();

                Console.WriteLine("por favor digite su nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine("por favor digite que tipo de empleado es : \n"
                    +
                    "1.operario \n" +
                    "2.tecnico \n" +
                    "3.profesional \n");
                string tipoDeEmpleado = Console.ReadLine();

                Console.WriteLine("favor digite cuanto gana por hora");
                int PrecioPorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("favor digite cuantas horas trabajo");
                double CantidadDeHoras = int.Parse(Console.ReadLine());
                double aumento = 0;

                double SalarioOrdinario = (CantidadDeHoras * PrecioPorHora);



                if (tipoDeEmpleado == "1")
                {
                    aumento = (SalarioOrdinario * 0.15);



                }
                if (tipoDeEmpleado == "2")
                {
                    aumento = (SalarioOrdinario * 0.10);



                }
                if (tipoDeEmpleado == "3")
                {
                    aumento = (SalarioOrdinario * 0.05);




                }

                double SalarioBruto = (aumento + SalarioOrdinario);
                double Deduccionccss = (SalarioBruto * 0.917);
                double salarioneto = (SalarioBruto - Deduccionccss);

                Console.WriteLine(
                "tipo de empleado " + tipoDeEmpleado +
                "\nsu salario por hora es : " + PrecioPorHora +
                "\ncantidad de horas laboradas : " + CantidadDeHoras +
                "\nsu salario ordinario es : " + SalarioOrdinario +
                "\nsu aumento es de : " + aumento +
                "\nsu salario bruto es : " + SalarioBruto +
                "\ndeduccion de la ccss : " + Deduccionccss +
                "\nsu salario neto es :" + salarioneto
                    );
                Console.WriteLine("\nFavor indicar si desea registrar mas informacion" +
                    "\nMarque S para continuar" +
                    "\nMarque N para finalizar");
                string respuesta = Console.ReadLine();

                if (respuesta == "S")
                {
                    i = 0;
                }

                else
                {
                    Console.WriteLine("la cantidad de empleados tipo operarios es :" + CantidadOperarios);
                    Console.WriteLine("salario neto acumulado de operarios es :" + CantidadOperarios);
                    Console.WriteLine("el promedio de salario neto tipo operarios es :" + CantidadOperarios);
                    Console.WriteLine("la cantidad de empleados tipo tecnicos es :" + CantidadOperarios);
                }



                Console.ReadKey();
            }
    }
}
