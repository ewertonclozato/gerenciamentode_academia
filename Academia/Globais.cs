using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class Globais
    {
        //variaveis publica para usar em todo programa
        public static string versao = "Academaia versão 1.10";
        public static bool logado = false;
        public static int nivel = 0;

        //retorno do caminho do executavel da aplicação
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public static string nomeBanco = "bd_academia.db";
        public static string caminhoBanco = caminho + @"\bd\";
        public static string caminhoFotos = caminho + @"\fotos\";

        public void sequencia(string tabela)
        {
            string vquerySequencia = "delete from sqlite_sequence where name='" + tabela + "'";
            Banco.dml(vquerySequencia);
        }
    }

    /*
     
     tb_usuarios
     N_IDUSUARIO
     T_NOMEUSUARIO
     T_USERNAME
     T_SENHAUSUARIO
     T_STATUSUSUARIO
     N_NIVELUSUARIO

     */
}
