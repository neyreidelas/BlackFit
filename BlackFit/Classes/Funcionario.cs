using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFit.Classes
{
    public class Funcionario
    {
        #region Propriedades
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }
        public DateTime DtNascimento { get; set; }
        public bool Ativo { get; set; }

        #endregion

        #region Construtores
        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, string email, string senha, int nivelAcesso, DateTime dtNascimento, bool ativo)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelAcesso = nivelAcesso;
            DtNascimento = dtNascimento;
            Ativo = ativo;
        }
        #endregion

        #region Métodos

        #region Antigo RealizarLogin Sem BANCO
        //public static Usuario RealizarLogin(string email, string senha, List<Usuario> usuarios)
        //{
        //    Usuario usuario = usuarios.Find(a => a.Email == email);

        //    //Bloco - try..catch
        //    try
        //    {
        //        if (usuario == null)
        //        {
        //            //E-mail é inexistente
        //            throw new Exception("E-mail inexistente!");
        //        }
        //        else
        //        {
        //            if (usuario.Senha == senha)
        //            {
        //                if (usuario.Ativo)
        //                {
        //                    //Deu tudo certo
        //                    return usuario;
        //                }
        //                else
        //                {
        //                    //Usuário bloqueado
        //                    throw new Exception("Usuário bloqueado");
        //                }
        //            }
        //            else
        //            {
        //                //Senha incorreta
        //                throw new Exception("Senha incorreta!");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion

        public static Funcionario RealizarLogin(string email, string senha)
        {
            string query = string.Format($"SELECT * FROM Funcionario WHERE Email = '{email}'");
            Conexao cn = new Conexao(query);

            Funcionario usuario = new Funcionario();

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
                        usuario.IdFuncionario = Convert.ToInt32(cn.dr[0]);
                        usuario.Nome = cn.dr[1].ToString();
                        usuario.Email = cn.dr[2].ToString();
                        usuario.Senha = cn.dr[3].ToString();
                        usuario.NivelAcesso = Convert.ToInt32(cn.dr[4]);
                        usuario.DtNascimento = Convert.ToDateTime(cn.dr[5]);
                        usuario.Ativo = Convert.ToBoolean(cn.dr[6]);
                    }

                    if (usuario.Senha == Crypto.Sha256(senha))
                    {
                        if (usuario.Ativo)
                        {
                            //Deu tudo certo
                            return usuario;
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


        //Este método irá alterar a senha de um usuário que está logado.
        public void AlterarSenha(string senhaAtual, string novaSenha, string confNovaSenha)
        {
            string query = string.Format("UPDATE {0} SET Senha = '{1}' WHERE Id = {2}", this is Funcionario ? "Funcionario" : "Aluno", Crypto.Sha256(novaSenha));
            Conexao cn = new Conexao(query);

            try
            {
                if (Senha == Crypto.Sha256(senhaAtual))
                {
                    if (novaSenha == confNovaSenha)
                    {
                        cn.AbrirConexao();
                        cn.comando.ExecuteNonQuery();
                        Senha = Crypto.Sha256(novaSenha);
                    }
                    else
                    {
                        throw new Exception("Nova senha não confere!");
                    }
                }
                else
                {
                    throw new Exception("Senha atual não confere!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Funcionario> BuscarUsuarios()
        {
            string query = string.Format("SELECT * FROM Aluno");
            Conexao cn = new Conexao(query);

            List<Funcionario> usuarios = new List<Funcionario>();

            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    usuarios.Add(new Funcionario()
                    {
                        IdFuncionario = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        Email = cn.dr[2].ToString(),
                        Senha = cn.dr[3].ToString(),
                        NivelAcesso = Convert.ToInt32(cn.dr[4]),
                        DtNascimento = Convert.ToDateTime(cn.dr[5]),
                        Ativo = Convert.ToBoolean(cn.dr[6]),
                        
                    });
                }
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
