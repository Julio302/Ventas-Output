using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class Departamento
    {
        public static ML.Result DepartamentoAdd(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddDepartamento";

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Departamento.Nombre;
                cmd.Parameters.Add("@IdArea", SqlDbType.Int).Value = Departamento.IdArea;

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Error No se pudo insertar el Departamento";
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Errror en " + e;
            }
            return result;
        }

        public static ML.Result DepartamentoDelete(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = context;
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDepartamento";

                cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = IdDepartamento;

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Error no se pudo eliminar el departamento";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result DepartamentoUpdate(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDepartamento";

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Departamento.Nombre;
                cmd.Parameters.Add("@IdArea", SqlDbType.Int).Value = Departamento.IdArea;
                cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = Departamento.IdDepartamento;

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected >= 1) {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No se pudo modificar el departamento";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result DepartamentoGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllDepartamento";

                cmd.Connection.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count >= 0)
                {
                    result.Objects = new List<object>();
                    foreach(DataRow row in ds.Tables[0].Rows)                    
                    {
                        ML.Departamento departamento = new ML.Departamento();
                        departamento.IdDepartamento = int.Parse(row[0].ToString());
                        departamento.Nombre = row[1].ToString();
                        departamento.IdArea = int.Parse(row[2].ToString());

                        result.Objects.Add(departamento);
                    }
                    result.Correct = true;
                }else{
                    result.Correct = false;
                    result.ErrorMessage = "No hay registros";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }


        /*ENTITY*/
        public static ML.Result DepartamentoAddEF(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities()){
                    var query = context.AddDepartamento(Departamento.Nombre, Departamento.IdArea);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo agregar el departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result DepartamentoDeleteEF(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = context.DeleteDepartamento(IdDepartamento);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo eliminar el departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }

        public static ML.Result DepartamentoUpdateEF(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = context.UpdateDepartamento(Departamento.Nombre, Departamento.IdArea, Departamento.IdDepartamento);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo modificar el departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }

        public static ML.Result DepartamentoGetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var listaDepartamento = context.GetAllDepartamento().ToList();

                    if (listaDepartamento != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in listaDepartamento)
                        {
                            ML.Departamento departamento = new ML.Departamento();
                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.IdArea = (int) item.IdArea;

                            result.Objects.Add(departamento);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay registros";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    
    
        //Linq
        public static ML.Result DepartamentoAddLinq(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    DL_EF.Departamento departamentoDL = new DL_EF.Departamento();
                    departamentoDL.IdDepartamento = Departamento.IdDepartamento;
                    departamentoDL.Nombre = Departamento.Nombre;
                    departamentoDL.IdArea = Departamento.IdArea;

                    context.Departamentoes.Add(departamentoDL);
                    int rowsAffected = context.SaveChanges();

                    if (rowsAffected >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo agregar el departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }

        public static ML.Result DepartamentoDeleteLinq(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = (from d in context.Departamentoes
                                 where d.IdDepartamento == IdDepartamento
                                 select d).First();

                    context.Departamentoes.Remove(query);
                    int rowsAffected = context.SaveChanges();

                    if (rowsAffected >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo eliminar el Departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result DepartamentoUpdateLinq(ML.Departamento Departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = (from d in context.Departamentoes
                                     where d.IdDepartamento == Departamento.IdDepartamento
                                     select d).SingleOrDefault();

                    if (query != null)
                    {
                        query.IdDepartamento = Departamento.IdDepartamento;
                        query.Nombre = Departamento.Nombre;
                        query.IdArea = Departamento.IdArea;

                        context.SaveChanges();
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo modificar el Departamento";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }

        public static ML.Result DepartamentoGetAllLinq()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {

                    var query = (from d in context.Departamentoes
                                 select new {
                                     IdDepartamento = d.IdDepartamento,
                                     Nombre = d.Nombre,
                                     IdArea = d.IdArea
                                 }).ToList();
                    
                    if (query != null)
                    {
                        //lista de objetos
                        result.Objects = new List<object>();
                        foreach(var item in query){
                            ML.Departamento departamento = new ML.Departamento();
                            departamento.IdDepartamento = item.IdDepartamento;
                            departamento.Nombre = item.Nombre;
                            departamento.IdArea = (int) item.IdArea;

                            result.Objects.Add(departamento);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No existen registros";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    }
}
