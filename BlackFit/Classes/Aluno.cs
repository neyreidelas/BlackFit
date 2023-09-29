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

        public Aluno(int idAluno,int IdPlano, string nome, string email, string telefone, string senha, bool ativo) 
        {
            
            int idPlano = IdPlano;
            string Telefone = telefone;
        }
        #endregion

        #region Métodos
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
            string query = string.Format($"UPDATE Aluno SET Ativo = 0 WHERE Id);
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
