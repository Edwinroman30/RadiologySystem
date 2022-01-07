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

        #region SELECTs

        #region SELECT Pacientes

        public List<CPacienteDAL> GetCentralPacientes(string filtro = null, string valorFiltro = null)
        {

            List<CPacienteDAL> listaPacientes = new List<CPacienteDAL>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetPacientes = @"SELECT *
                                                FROM viewGridViewPacientes";

                    using (var command = new SqlCommand(queryGetPacientes,conn))
                    {
                        if (!string.IsNullOrEmpty(valorFiltro))
                        {
                            //Esa concatenacion no es la mejor forma, pero puede resultar

                            queryGetPacientes = @"SELECT *
                                                  FROM viewGridViewPacientes
                                                  WHERE "+filtro+" LIKE @valorFiltro";

                            command.CommandText = queryGetPacientes;
                            //command.Parameters.Add(new SqlParameter("@filtro",filtro));
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



        public List<CPaciente> GetPacientes(string cedula = null)
        {

            List<CPaciente> listaPacientes = new List<CPaciente>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();
                    string queryGetPacientes;

                    if (String.IsNullOrEmpty(cedula) || String.IsNullOrWhiteSpace(cedula))
                    {
                        queryGetPacientes = @"SELECT cedula,nombre,prim_apellido,seg_apellido,email,telefono,id_sangre,id_sexo,id_pais,SectorID,id_seguro,imagen_perfil
                                              FROM Tbl_Pacientes";
                    }
                    else
                    {

                    queryGetPacientes = @"SELECT cedula,nombre,prim_apellido,seg_apellido,email,telefono,id_sangre,id_sexo,id_pais,SectorID,id_seguro,imagen_perfil
                                                 FROM Tbl_Pacientes
                                                 WHERE cedula = @cedula";

                    }

                    using (var command = new SqlCommand(queryGetPacientes,conn))
                    {
                      
                       command.CommandText = queryGetPacientes;

                       if (!String.IsNullOrEmpty(cedula))
                            command.Parameters.Add(new SqlParameter("@cedula", cedula));


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
                            pacienteRetorno.IdSangre = Convert.ToInt32(reader["id_sangre"]);
                            pacienteRetorno.Sexo = Convert.ToInt32(reader["id_sexo"]);
                            pacienteRetorno.Pais = Convert.ToInt32(reader["id_pais"]);
                            pacienteRetorno.Sector = Convert.ToInt32(reader["SectorID"]);
                            pacienteRetorno.IdSeguro = (reader["id_seguro"] != DBNull.Value) ? Convert.ToInt32(reader["id_seguro"]) : 11;
                            pacienteRetorno.fotoPaciente = (reader["imagen_perfil"] == DBNull.Value) ? null : null;
                            //Faltan elementos... (PEro no son necesarios en este apartado.)

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

        #region Paises
        public List<CPais> GetPaises(string filtro = null)
        {

            List<CPais> listaPaises = new List<CPais>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetPaises = @"Select id_pais,nombre_pais,nacionalidad
                                                    From Tbl_Pais";

                    using (var command = new SqlCommand(queryGetPaises,conn))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetPaises = @"Select id_pais,nombre_pais,nacionalidad
                                                  From Tbl_Pais
                                                  Where id_pais =  @valorFiltro";

                            command.CommandText = queryGetPaises;
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
        #endregion

        #region Seguros

        public List<CSeguro> GetSeguros(string filtro = null)
        {

            List<CSeguro> listaSeguros = new List<CSeguro>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetSeguros = @"Select id_seguro, concepto
                                                    From Tbl_Seguros";

                    using (var command = new SqlCommand(queryGetSeguros, conn))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetSeguros = @"Select id_pais,nombre_pais,nacionalidad
                                                  From Tbl_Pais
                                                  Where id_pais =  @valorFiltro";

                            command.CommandText = queryGetSeguros;
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{filtro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CSeguro seguros = new CSeguro();

                            seguros.idenSeguro = Convert.ToInt32(reader["id_seguro"]);
                            seguros.NomSeguro = reader["concepto"].ToString();
                            
                            listaSeguros.Add(seguros);

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
            return listaSeguros;

        }



        #endregion

        #region SEXO

        public List<CSexo> GetSexo(string filtro = null)
        {

            List<CSexo> listaSexos = new List<CSexo>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetSexo = @"Select id_sexo,descripcion
                                                from Tbl_Sexo";

                    using (var command = new SqlCommand(queryGetSexo, conn))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetSexo = @"Select id_sexo,descripcion
                                                  from Tbl_Sexo   
                                                  Where id_sexo =  @valorFiltro";

                            command.CommandText = queryGetSexo;
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{filtro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CSexo sexo = new CSexo();

                            sexo.IdSexo = Convert.ToInt32(reader["id_sexo"]);
                            sexo.TipoSexo = reader["descripcion"].ToString();

                            listaSexos.Add(sexo);

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
            return listaSexos;

        }
        #endregion

        #region Sangre

        public List<CSangre> GetSangre(string filtro = null)
        {

            List<CSangre> listaSangres = new List<CSangre>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetSangre = @"Select  id_sangre,descripcion
                                                  From Tbl_Tipo_sangre";

                    using (var command = new SqlCommand(queryGetSangre, conn))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetSangre = @"Select  id_sangre,descripcion
                                                  From Tbl_Tipo_sangre
                                                  Where id_sangre =  @valorFiltro";

                            command.CommandText = queryGetSangre;
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{filtro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CSangre sangre = new CSangre();

                            sangre.idTipoSangre = Convert.ToInt32(reader["id_sangre"]);
                            sangre.Tiposangre = reader["descripcion"].ToString();

                            listaSangres.Add(sangre);

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
            return listaSangres;

        }
        #endregion

        #region Sectores

        public List<CSector> GetSectores(string filtro = null)
        {

            List<CSector> listaSectores = new List<CSector>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                    string queryGetSectores = @"Select SectorID, localidad
                                                 from Tbl_Sectores";

                    using (var command = new SqlCommand(queryGetSectores, conn))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            queryGetSectores = @"Select SectorID, localidad
                                                  from Tbl_Sectores
                                                  Where SectorID =  @valorFiltro";

                            command.CommandText = queryGetSectores;
                            command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{filtro}%"));
                        }


                        //That return a SqlDataReader();
                        var reader = command.ExecuteReader();

                        //Just we need to iterate it.
                        while (reader.Read())
                        {
                            CSector sector = new CSector();

                            sector.IdSector = Convert.ToInt32(reader["SectorID"]);
                            sector.Localidad = reader["localidad"].ToString();

                            listaSectores.Add(sector);

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
            return listaSectores;

        }
        #endregion

        public List<CFacturacion> GetAllFacturaciones(string filtro = null)
        {

            List<CFacturacion> listaFacturacion = new List<CFacturacion>();

            using (var conn = new SqlConnection(this.strConexion))
            {
                try
                {
                    conn.Open();

                string queryGetSeguros = @"SELECT *
                                            from vwListFacturacion";

                using (var command = new SqlCommand(queryGetSeguros, conn))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        queryGetSeguros = @"SELECT *
                                                 FROM vwListFacturacion
                                                 WHERE [id_paciente] = @valorFiltro";

                        command.CommandText = queryGetSeguros;
                        command.Parameters.Add(new SqlParameter("@valorFiltro", $"%{filtro}%"));
                    }


                    //That return a SqlDataReader();
                    var reader = command.ExecuteReader();

                    //Just we need to iterate it.
                    while (reader.Read())
                    {
                        CFacturacion facturacion = new CFacturacion();

                        facturacion.IdenFactura = Convert.ToInt32(reader["Iden. Factura"]);
                        facturacion.TipoEstudio = Convert.ToString(reader["Concepto Estudio"]);
                        facturacion.Doctor = Convert.ToInt32(reader["Iden. Empleado"]);
                        facturacion.CedulaPaciente = Convert.ToString(reader["Iden. Pacientes"]);
                        facturacion.Observacion = Convert.ToString(reader["Observaciones"]);
                        facturacion.fechafactura = Convert.ToDateTime(reader["Fecha de Factura"]);

                        listaFacturacion.Add(facturacion);

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
            return listaFacturacion;

        }

        #endregion




    }
}
