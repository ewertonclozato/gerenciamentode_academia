using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    class Banco
    {
        /// Funções Genericas
        //passa como paranmetro o SQL da consulta no banco de dados
        public static DataTable dql(string sql)//Data Query Languege (select)
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                cmd.CommandText = sql;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                dataAdapter.Fill(dataTable);
                conexaoBanco().Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }

        public static void dml(string q,string msgOk = null,string msgErro = null) //Data Manipulation Languege (insert, delete, update)
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                cmd.CommandText = q;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                conexaoBanco().Close();
                if (msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
            }
        }
        /// FIM FUNÇÕES GENERICAS

        //criando variavel de conexao com o banco de dados
        private static SQLiteConnection conexao;

        //criando metedo para chamar a conexao com o banco de dados
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        //criar metodo para chamar todos os usuarios (retorna um objeto do tipo DataTable, com as informações dos usuarios do sistema)
        public static DataTable obterTodosUsuarios()
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    dataAdapter.Fill(dataTable);
                    conexaoBanco().Close();
                    return dataTable;
                }
            }
            catch(Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }

        ///Funções do FORM F_NovoUsuario
        public static void novoUsuario(Usuario usuario)
        {
            if (existeUserName(usuario))
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            else
            {
                try
                {
                    var cmd = conexaoBanco().CreateCommand();

                    //definindo a Query para o INSERT no banco de dados
                    cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome,@username,@senha,@status,@nivel)";
                    cmd.Parameters.AddWithValue("@nome", usuario.nome);
                    cmd.Parameters.AddWithValue("@username", usuario.username);
                    cmd.Parameters.AddWithValue("@senha", usuario.senha);
                    cmd.Parameters.AddWithValue("@status", usuario.status);
                    cmd.Parameters.AddWithValue("@nivel", usuario.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário Cadastrado com sucesso");
                    conexaoBanco().Clone();
                }
                catch
                {
                    conexaoBanco().Clone();
                }
            }
        }
        ///Fim Funções do FORM F_NovoUsuario

        ///Funções Gerais
        public static bool existeUserName(Usuario usuario)
        {
            bool res;

            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
            //CreateCommand() (é o comando dentro do bando de dados selecionado)
            var cmd = conexaoBanco().CreateCommand();

            //escrevendo no cmd do banco de dados o SQL que ele quer buscar
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='" + usuario.username + "'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
            dataAdapter.Fill(dataTable);
            conexaoBanco().Close();

            if (dataTable.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        ///Fim Funções Gerais
        /// 
        /// 
        /// 
        ///Funções FORM Gestao Usuários
        public static DataTable obterDadosUsuarios()
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                    //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                    cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário',T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    dataAdapter.Fill(dataTable);
                    conexaoBanco().Close();
                    return dataTable;
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable obterDadosUsuario(string id)
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                dataAdapter.Fill(dataTable);
                conexaoBanco().Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }

        public static void ataluzarUsuarios(Usuario u)
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='" + u.nome + "',T_USERNAME='" + u.username + "',T_SENHAUSUARIO='" + u.senha + "',T_STATUSUSUARIO='" + u.status + "',N_NIVELUSUARIO=" + u.nivel + " WHERE N_IDUSUARIO=" + u.id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                conexaoBanco().Close();
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                MessageBox.Show("Erro: " + ex);
            }
        }

        public static void deletarUsuario(string id)
        {
            //criando comando SQL para consulta pelo DataAdapter
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                //engloba todo conteudo dentro desse comando da conexao, como se tivesse criando um contender
                //CreateCommand() (é o comando dentro do bando de dados selecionado)
                var cmd = conexaoBanco().CreateCommand();
                //escrevendo no cmd do banco de dados o SQL que ele quer buscar
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                cmd.ExecuteNonQuery();
                conexaoBanco().Close();
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                MessageBox.Show("Erro: " + ex);
            }
        }
        ///FIM Funções FORM Gestao Usuários

    }


}
