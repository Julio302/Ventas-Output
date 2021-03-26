using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Departamento
    {
        /*ADO SP*/
        public static void DepartamentoAdd()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa Nombre departamento");
            departamento.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoAdd(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento insertado con SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoDelete()
        {
            Console.WriteLine("Ingresa IdDepartamento a eliminar");
            int IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Departamento.DepartamentoDelete(IdDepartamento);

            if (result.Correct)
            {
                Console.WriteLine("Se elimino el departamento con SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoUpdate()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa IdDepartamento a modificar");
            departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa nuevo Nombre departamento");
            departamento.Nombre = Console.ReadLine();
            
            Console.WriteLine("Ingresa nuevo IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoUpdate(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento modificado con SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoGetAll()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla de departamentos usando SP");
            result = BL.Departamento.DepartamentoGetAll();

            if (result.Correct)
            {
                foreach (ML.Departamento departamento in result.Objects)
                {
                    Console.WriteLine("IdDepartamento: " + departamento.IdDepartamento + " Nombre " + departamento.Nombre + " IdArea " + departamento.IdArea);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    
        /*Entity*/
        public static void DepartamentoAddEF()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa Nombre departamento");
            departamento.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoAddEF(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento insertado con Entity");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }

        }

        public static void DepartamentoDeleteEF()
        {
            Console.WriteLine("Ingresa IdDepartamento a eliminar");
            int IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Departamento.DepartamentoDeleteEF(IdDepartamento);

            if (result.Correct)
            {
                Console.WriteLine("Se elimino el departamento con ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoUpdateEF()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa IdDepartamento a modificar");
            departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa nuevo Nombre departamento");
            departamento.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa nuevo IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoUpdateEF(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento modificado con ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoGetAllEF()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla de departamentos usando ENTITY");
            result = BL.Departamento.DepartamentoGetAllEF();

            if (result.Correct)
            {
                foreach (ML.Departamento departamento in result.Objects)
                {
                    Console.WriteLine("IdDepartamento: " + departamento.IdDepartamento + " Nombre " + departamento.Nombre + " IdArea " + departamento.IdArea);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
   
    
        //Linq

        public static void DepartamentoAddLinq()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa Nombre departamento");
            departamento.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoAddLinq(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento insertado con Linq");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoDeleteLinq()
        {
            Console.WriteLine("Ingresa IdDepartamento a eliminar");
            int IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Departamento.DepartamentoDeleteLinq(IdDepartamento);

            if (result.Correct)
            {
                Console.WriteLine("Se elimino el departamento con LINQ");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoUpdateLinq()
        {
            ML.Departamento departamento = new ML.Departamento();
            Console.WriteLine("Ingresa IdDepartamento a modificar");
            departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa nuevo Nombre departamento");
            departamento.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa nuevo IdArea");
            departamento.IdArea = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.Departamento.DepartamentoUpdateLinq(departamento);

            if (result.Correct)
            {
                Console.WriteLine("Departamento modificado con LINQ");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void DepartamentoGetAllLinq()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla de departamentos usando LINQ");
            result = BL.Departamento.DepartamentoGetAllLinq();

            if (result.Correct)
            {
                foreach (ML.Departamento departamento in result.Objects)
                {
                    Console.WriteLine("IdDepartamento: " + departamento.IdDepartamento + " Nombre " + departamento.Nombre + " IdArea " + departamento.IdArea);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    }
}
