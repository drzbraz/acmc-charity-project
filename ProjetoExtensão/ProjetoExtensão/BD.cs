using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetoExtensão
{
    class BD
    {
        public BD()
        {

        }

        public MySqlDataAdapter adapter;
        private MySqlCommand command = new MySqlCommand();
        private static string config = @"server=localhost;user id=root;persistsecurityinfo=True;database=acmc;PWD=123456";
        public MySqlConnection conexão = new MySqlConnection(config);
        /*
         *public bool NovoMedico(Médico novoMedico)
          {
              String cpf = novoMedico.getCPF();
              String nome = novoMedico.getNome();
              DateTime data = novoMedico.getData();
              String rg = novoMedico.getRG();
              String estadoCivil = novoMedico.getEstadoCivil();
              String cel = novoMedico.getCelular();
              String mail = novoMedico.getMail();


              TrataString MeuNum = new TrataString();
              conexão.Open();
              command.Connection = conexão;
              command.CommandType = CommandType.Text;
              try
              {
                  command.CommandText = "insert into Medicos values ('" + MeuNum.ConverteStringDados(cpf) + "','" + nome + "'," +
                      "'" + data.ToString("yyyy/MM/dd") + "', '" + MeuNum.ConverteStringDados(rg) + "'," +
                      "'" + estadoCivil + "','" + MeuNum.ConverteStringDados(cel) + "'," +
                      "'" + mail + "')";

                  command.ExecuteNonQuery();
              }
              catch (MySql.Data.MySqlClient.MySqlException)
              {
                  return false;
              }
              return true;
              command.Connection.Close();
          } */
        public bool NovaConsulta(Consulta novaConsulta)
        {
            String cpf_paciente = novaConsulta.CPF_paciente;
            String cpf_medico = novaConsulta.CPF_medico;
            String data = novaConsulta.DataConsulta;


            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            try
            {
                conexão.Open();
            }
            catch (System.InvalidOperationException)
            {
                try
                {
                    command.CommandText = "insert into Consultas (paciente_cpf, medico_cpf, data_consulta) values ('" + cpf_paciente + "','" + cpf_medico + "'," +
                        "'" + data + "')";

                    command.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    return false;
                }
            }
            command.Connection.Close();
            return true;


        }

        public String pesquisaMedico(String conteudo)
        {
            string resultado = "";
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            try
            {
                conexão.Open();
                command.CommandText = "SELECT CPF,Nome from Medicos Where Nome LIKE ('%" + conteudo + "%')";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = "CPF: " + dr.GetString(0) + " NOME: " + dr.GetString(1);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }
            }
            catch (System.InvalidOperationException)
            {
                command.CommandText = "SELECT CPF,Nome from Medicos Where Nome LIKE ('%" + conteudo + "%')";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = "CPF: " + dr.GetString(0) + " NOME: " + dr.GetString(1);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }
            }
            command.Connection.Close();
            return resultado;
        }
        public String pesquisaPaciente(String conteudo)
        {

            string resultado = "";
            try
            {
                conexão.Open();
            }
            catch (System.InvalidOperationException)
            {
                command.Connection = conexão;

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT CPF,Nome from Pacientes Where Nome LIKE ('%" + conteudo + "%')";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = "CPF: " + dr.GetString(0) + " NOME: " + dr.GetString(1);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }
                command.Connection.Close();
                conexão.Close();


            }
            return resultado;
        }

        public int quantidadeConsultas(String CPF)
        {
            int resultado = 0;
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();

                command.CommandText = "SELECT QntConsultas from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = int.Parse(dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = 0;
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = 0;
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT qntConsultas from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = int.Parse(dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = 0;
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = 0;
                }

                command.Connection.Close();
                conexão.Close();
            }
            return resultado;

        }

        public string atualizaConsultas(String CPF, int qtd)
        {
            try
            {
                conexão.Open();
                command.CommandText = "UPDATE Pacientes SET qntConsultas = " + qtd + " where CPF = '" + CPF + "'";
                command.ExecuteNonQuery();

                return "ok";
            }
            catch (Exception x)
            {
                return x.Message;
            }


        }


        public string NomeMãePac(String CPF)
        {
            string resultado = "";
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();
                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT NomeMae from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = dr.GetString(0);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT NomeMae from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = (dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            return resultado;

        }



        public string DataNascimentoPac(String CPF)
        {
            string resultado = "";
            DateTime Data = DateTime.Now;
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();
                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT DataNasc from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    Data = Convert.ToDateTime(dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT DataNasc from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = (dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            resultado = Convert.ToString(Data.ToString("dd/MM/yyyy"));
            return resultado;

        }


        public string NomePac(String CPF)
        {
            string resultado = "";
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();
                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT Nome from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = dr.GetString(0);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT Nome from Pacientes Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = (dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            return resultado;

        }

        public string NomeMed(String CPF)
        {
            string resultado = "";
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();
                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT Nome from Medicos Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = dr.GetString(0);
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT Nome from Medicos Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = (dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            return resultado;

        }


        public string DataNascimentoMed(String CPF)
        {
            string resultado = "";
            DateTime Data = DateTime.Now;
            command.Connection = conexão;
            command.CommandType = CommandType.Text;

            try
            {
                conexão.Open();
                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT DataNasc from Medicos Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    Data = Convert.ToDateTime(dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {


                //command.CommandText = "SELECT CPF,Nome from Medicos Where CPF LIKE ('%"+conteudo+"%')";
                command.CommandText = "SELECT DataNasc from Medicos Where CPF = " + "'" + CPF + "'";
                MySqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                try
                {
                    resultado = (dr.GetString(0));
                }
                catch (MySqlException)
                {
                    resultado = "";
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    resultado = "";
                }

                command.Connection.Close();
                conexão.Close();
            }
            resultado = Convert.ToString(Data.ToString("dd/MM/yyyy"));
            return resultado;

        }


        public Pessoa buscarPessoaPorCpf(String CPF, String table)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            Pessoa pac = new Pessoa();
            try
            {
                conexão.Open();

                command.CommandText = "SELECT CPF,Nome,DataNasc from " + table + " Where CPF LIKE ('%" + CPF + "%')";
                MySqlDataReader dr = command.ExecuteReader();

                try
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        pac.CPF = dr.GetString(0);
                        pac.Nome = dr.GetString(1);
                        pac.DataNasc = Convert.ToDateTime(dr.GetString(2));
                    }
                    else
                    {
                        pac.CPF = "nulo";
                        pac.Nome = "nulo";
                    }

                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    pac.CPF = "nulo";
                    pac.Nome = "nulo";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {
                pac.CPF = "nulo";
                pac.Nome = "nulo";
            }
            return pac;

        }

        public Pessoa buscarPessoaPorNome(String nome, String table)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            Pessoa pac = new Pessoa();
            try
            {
                conexão.Open();

                command.CommandText = "SELECT CPF,Nome,DataNasc from " + table + " Where Nome LIKE ('%" + nome + "%')";
                MySqlDataReader dr = command.ExecuteReader();

                try
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        pac.CPF = dr.GetString(0);
                        pac.Nome = dr.GetString(1);
                        pac.DataNasc = Convert.ToDateTime(dr.GetString(2));
                    }
                    else
                    {
                        pac.CPF = "nulo";
                        pac.Nome = "nulo";
                    }

                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    pac.CPF = "nulo";
                    pac.Nome = "nulo";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {
                pac.CPF = "nulo";
                pac.Nome = "nulo";
            }
            return pac;

        }

        public string insereConsulta(Consulta con, int numCon)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            conexão.Open();

            try
            {
                command.CommandText = "INSERT INTO consultas (paciente_cpf,medico_cpf,data_consulta,diag_med) values('" + con.CPF_paciente + "','" + con.CPF_medico + "','" + con.DataConsulta + "', '"+con.DiagMed+"')";

                command.ExecuteNonQuery();
                command.Connection.Close();

                return "ok";
            }
            catch (Exception x)
            {
                return x.Message;
            }


        }
        public Consulta buscarConsultaPorCpf(String CPF, String table)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            Consulta con = new Consulta();
            List<String> listaDeRetorno = new List<String>();//Crie uma lista de Cliente
            try
            {
                conexão.Open();

                command.CommandText = "SELECT paciente_cpf, medico_cpf, data_consulta from " + table + " Where medico_cpf LIKE ('%" + CPF + "%')";
                MySqlDataReader dr = command.ExecuteReader();

                try
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.CPF_paciente = dr.GetString(0);
                        con.CPF_medico = dr.GetString(1);
                        con.DataConsulta = dr["data_consulta"].ToString();
                        listaDeRetorno.Add(con.DataConsulta);


                    }
                    else
                    {
                        con.CPF_paciente = "nulo";
                        con.CPF_medico = "nulo";
                    }

                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    con.CPF_paciente = "nulo";
                    con.CPF_medico = "nulo";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {
                con.CPF_paciente = "nulo";
                con.CPF_medico = "nulo";
            }

            return con;

        }

        public List<String> buscarConsultaPorCpfList(String CPF, String table)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            Consulta con = new Consulta();
            List<String> listaDeRetorno = new List<String>();//Crie uma lista de Cliente
            try
            {
                conexão.Open();

                command.CommandText = "SELECT paciente_cpf, medico_cpf, data_consulta from " + table + " Where medico_cpf LIKE ('%" + CPF + "%')";
                MySqlDataReader dr = command.ExecuteReader();

                try
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.CPF_paciente = dr.GetString(0);
                        con.CPF_medico = dr.GetString(1);



                        while (dr.Read())
                        {
                            con.DataConsulta = dr["data_consulta"].ToString();
                            listaDeRetorno.Add(con.DataConsulta);
                        }

                    }
                    else
                    {
                        con.CPF_paciente = "nulo";
                        con.CPF_medico = "nulo";
                    }

                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    con.CPF_paciente = "nulo";
                    con.CPF_medico = "nulo";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {
                con.CPF_paciente = "nulo";
                con.CPF_medico = "nulo";
            }



            return listaDeRetorno;

        }

        public List<String> buscarConsultaPorDataList(String Data, String table)
        {
            command.Connection = conexão;
            command.CommandType = CommandType.Text;
            Consulta con = new Consulta();
            List<String> listaDeRetorno = new List<String>();//Crie uma lista de Cliente
            try
            {
                conexão.Open();

                command.CommandText = "SELECT paciente_cpf, medico_cpf, data_consulta from " + table + " Where data_consulta LIKE ('%" + Data + "%')";
                MySqlDataReader dr = command.ExecuteReader();

                try
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.CPF_paciente = dr.GetString(0);
                        con.CPF_medico = dr.GetString(1);



                        while (dr.Read())
                        {
                            con.DataConsulta = dr["data_consulta"].ToString();
                            listaDeRetorno.Add(con.DataConsulta);
                        }

                    }
                    else
                    {
                        con.CPF_paciente = "nulo";
                        con.CPF_medico = "nulo";
                    }

                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    con.CPF_paciente = "nulo";
                    con.CPF_medico = "nulo";
                }

                command.Connection.Close();
                conexão.Close();
            }
            catch (System.InvalidOperationException)
            {
                con.CPF_paciente = "nulo";
                con.CPF_medico = "nulo";
            }



            return listaDeRetorno;

        }






    }
}
