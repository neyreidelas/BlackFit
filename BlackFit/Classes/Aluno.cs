using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BlackFit.Classes
{
    public class Aluno
    {
        #region Propriedades

        public int IdAluno { get; set; }
        public int IdPlano { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public  string Telefone { get; set; }
        public string Senha { get; set; }
        public bool Ativo {get; set; }
 
        #endregion

        #region Construtores
        public Aluno()
        {
        }

        public Aluno(int idAluno,int idPlano, string nome, string email, string telefone, string senha, bool ativo) 
        {
            IdAluno = idAluno;
            IdPlano = idPlano;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Ativo = ativo;
        }
        #endregion

        #region Métodos

        public static Aluno RealizarLogin(string email, string senha)
        {

            string query = string.Format($"SELECT * FROM Aluno WHERE Email = '{email}'");
            Conexao cn = new Conexao(query);

            Aluno aluno = new Aluno();

            //Bloco - try..catch
            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader(); // P/ Select! ExecuteReader()!!!!!

                if (cn.dr.HasRows)
                {
                    //Achou os dados do usuário de acordo com o E-mail pesquisado
                    while (cn.dr.Read())
                    {
                        aluno.IdAluno = Convert.ToInt32(cn.dr[0]);
                        aluno.IdPlano = Convert.ToInt32(cn.dr[1]);
                        aluno.Nome = Convert.ToString(cn.dr[2]);
                        aluno.Email = cn.dr[3].ToString();
                        aluno.Telefone = Convert.ToString(cn.dr[3]);
                        aluno.Senha = cn.dr[4].ToString();
                        aluno.Ativo = Convert.ToBoolean(cn.dr[5]);

                    }

                    if (aluno.Senha == Crypto.Sha256(senha))
                    {
                        if (aluno.Ativo)
                        {
                            //Deu tudo certo
                            return aluno;
                        }
                        else
                        {
                            //Usuário bloqueado
                            throw new Exception("Usuário bloqueado");
                        }
                    }
                    else
                    {
                        //Senha incorreta
                        throw new Exception("Senha incorreta!");
                    }

                }
                else
                {
                    //Não teve retorno de linhas
                    throw new Exception("E-mail inexistente!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    

        public void Cadastrar(List<Aluno> alunos)
        {
            string query = string.Format($"Insert Into Aluno VALUES ({IdPlano}, '{Nome}', '{Email}', '{Telefone}','{Crypto.Sha256("123")},1)"); 
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                IdAluno = Convert.ToInt32(cn.comando.ExecuteScalar());
                alunos.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public void Alterar()
        {
            string query = string.Format($"Update Aluno set nome = {Nome}, {Email}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public void Excluir()
        {
            string query = string.Format($"UPDATE Aluno SET Ativo = 0 WHERE Id{1}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public static List<Aluno> Buscar(List<Aluno> alunos, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por Nome

                    return alunos.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();

                //break; quando não for return, é obrigatório o uso do break.
                case 1:
                    //Busca por Email

                    return alunos.Where(a => a.Email.Contains(texto)).ToList();

                //break; quando não for return, é obrigatório o uso do break.
                case 2:
                    //Busca por matrícula (Id)

                    return alunos.Where(a => a.IdAluno == Convert.ToInt32(texto)).ToList();

                //break; quando não for return, é obrigatório o uso do break.
                default:
                    //Retornar a lista sem filtro

                    return alunos;

                    //break; quando não for return, é obrigatório o uso do break.
            }
        }

        #endregion
    }
}
