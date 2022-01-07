using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryBackup.Model;

namespace ClassLibraryBackup.Data
{
    public class DataAccess
    {

        private string strConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Instituto_Radiologia;Data Source=DESKTOP-B9L1G5M";

        //public void InsertarDatos(CPaciente cPaciente)
        //{
        //    {
        //        using (var conn = new SqlConnection())
        //        {

        //            conn.Open();
        //            string query = @"
        //                          INSERT INTO Mercaderia ([Descripcion],[Existencia],[Comentario],[Status],[NoEliminable]) 
        //                          VALUES (@Descripcion,@Existencia,@Comentario,@Status,@NoEliminable)";

        //            using (var command = new SqlCommand(query, conn))
        //            {
        //                //Lo realice de manera directa en vez de crear un objeto con su nombre...
        //                command.Parameters.Add(new SqlParameter("@Descripcion", mercaderia.Descripcion));
        //                command.Parameters.Add(new SqlParameter("@Existencia", (mercaderia.Existencia > 0) ? mercaderia.Existencia : 0));
        //                command.Parameters.Add(new SqlParameter("@Comentario", mercaderia.Comentario));
        //                command.Parameters.Add(new SqlParameter("@Status", mercaderia.Status));
        //                command.Parameters.Add(new SqlParameter("@NoEliminable", mercaderia.NoEliminable));

        //                command.ExecuteNonQuery();
        //            }

        //            conn.Close();

        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        //Recordar manejar la execepcion
        //        throw e;
        //    }
        //}



        #region SELECT Pacientes

        public List<CPacienteDAL> GetCentralPacientes(string filtro = null, string valorFiltro = null)
        {

            List<CPacienteDAL> listaPacientes = new List<CPacienteDAL>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    string queryGetPacientes = @"SELECT *
                                                FROM viewGridViewPasientes";

                    using (var command = new SqlCommand())
                    {
                        if (!string.IsNullOrEmpty(valorFiltro))
                        {
                            queryGetPacientes = @"SELECT *
                                                  FROM viewGridViewPasientes
                                                  WHERE [@filtro] LIKE @valorFiltro";

                            command.CommandText = queryGetPacientes;
                            command.Parameters.Add(new SqlParameter("@filtro", $"%{filtro}%"));
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{valorFiltro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CPacienteDAL pacienteRetorno = new CPacienteDAL();

                            pacienteRetorno.Cedula = reader["cedula"].ToString();
                            pacienteRetorno.Nombre = reader["nombre"].ToString();
                            pacienteRetorno.Papellido = reader["prim_apellido"].ToString();
                            pacienteRetorno.Mapellido = reader["seg_apellido"].ToString();
                            pacienteRetorno.Email = reader["email"].ToString();
                            pacienteRetorno.Telefono = reader["telefono"].ToString();
                            pacienteRetorno.Seguro = reader["seguros"].ToString();

                            listaPacientes.Add(pacienteRetorno);
                        }

                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();

                }
            }

            //Retorno de la lista.
            return listaPacientes;

        }



        public List<CPaciente> GetPacientes(string filtro,string valorFiltro)
        {

            List<CPaciente> listaPacientes = new List<CPaciente>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    string queryGetPacientes = @"SELECT cedula,nombre,prim_apellido,seg_apellido,email,telefono,id_sexo,id_pais,SectorID,id_seguro,imagen_perfil
                                                 FROM Tbl_Pacientes";

                    using (var command = new SqlCommand())
                    {
                        if (!string.IsNullOrEmpty(valorFiltro))
                        {
                            queryGetPacientes = @"SELECT cedula,nombre,prim_apellido,seg_apellido,email,telefono,id_sexo,id_pais,SectorID,id_seguro,imagen_perfil
                                                 FROM Tbl_Pacientes
                                                 WHERE [@filtro] LIKE @valorFiltro";

                            command.CommandText = queryGetPacientes;
                            command.Parameters.Add(new SqlParameter("@filtro", $"%{filtro}%"));
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{valorFiltro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CPaciente pacienteRetorno = new CPaciente();

                            pacienteRetorno.Cedula = reader["cedula"].ToString();
                            pacienteRetorno.Nombre = reader["nombre"].ToString();
                            pacienteRetorno.Papellido = reader["prim_apellido"].ToString();
                            pacienteRetorno.Mapellido = reader["seg_apellido"].ToString();
                            pacienteRetorno.Email = reader["email"].ToString();
                            pacienteRetorno.Telefono = reader["telefono"].ToString();
                            pacienteRetorno.Sexo = Convert.ToInt32(reader["id_sexo"]);
                            pacienteRetorno.Pais = Convert.ToInt32(reader["id_pais"]);
                            pacienteRetorno.IdSeguro = (reader["id_seguro"] != DBNull.Value) ? Convert.ToInt32(reader["id_seguro"]): 11;
                            pacienteRetorno.fotoPaciente = null;//reader["imagen_perfil"];
                            //Faltan elementos...

                            listaPacientes.Add(pacienteRetorno);
                        }




                    }


                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                   
                }
            }
            
            //Retorno de la lista.
            return listaPacientes;

        }
        
        
        
        
        
        #endregion

        public List<CPais> GetPaises(string filtro = null)
        {

            List<CPais> listaPaises = new List<CPais>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    string queryGetPacientes = @"Select id_pais,nombre_pais,nacionalidad
                                                    From Tbl_Pais";

                    using (var command = new SqlCommand())
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetPacientes = @"Select id_pais,nombre_pais,nacionalidad
                                                  From Tbl_Pais
                                                  Where id_pais =  @valorFiltro";

                            command.CommandText = queryGetPacientes;
                            command.Parameters.Add(new SqlParameter("@filtro", $"%{filtro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CPais paises = new CPais();

                            paises.Idpais = Convert.ToInt32(reader["id_pais"]);
                            paises.NomPais = reader["nombre_pais"].ToString();
                            paises.Nacionalidad = reader["nacionalidad"].ToString();

                            listaPaises.Add(paises);

                        }

                    }


                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();

                }
            }

            //Retorno de la lista.
            return listaPaises;

        }




    }
}
