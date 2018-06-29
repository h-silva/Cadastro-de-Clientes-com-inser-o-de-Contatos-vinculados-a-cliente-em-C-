using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Trovato.dao
{
    class Conexao
    {
        public static string mensagem = "";
        public static bool verifica = false;

        public static SQLiteConnection Conectar()
        {
            SQLiteConnection mConn = null;

            string stringConexao = @"Data Source=C:\banco\trovata.s3db";

            mConn = new SQLiteConnection(stringConexao);

            try
            {
                mConn.Open();
            }
            catch(SQLiteException ex)
            {
                mensagem = ex.ToString();
            }
            return mConn;
        }
        public static void CRUD(SQLiteCommand comandoSQL)
        {        
            try
            {                
                SQLiteConnection mConn = Conectar();                
                comandoSQL.Connection = mConn;
                comandoSQL.ExecuteNonQuery();
                mConn.Close();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Banco de dados Inválido!!");
            }
            
        }

        public static SQLiteDataReader Select(SQLiteCommand comandoSQL)
        {       

            SQLiteConnection mConn = Conectar();

            comandoSQL.Connection = mConn;

            SQLiteDataReader dr = null;

            try
            {
                if (mConn.State == System.Data.ConnectionState.Open)
                {

                    dr = comandoSQL.ExecuteReader();
                }
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dr;

        }

    }
}
