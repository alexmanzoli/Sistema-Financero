using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_financero_beta
{
    class Class_banco
    {
        //Cadastro de caminho do banco
        private const string strCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\Term01\Documents\GitHub\Sistema-Financero\Sistema financero beta\SISTEMA.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True";
        private string vSql = "";
        SqlConnection ObjCon = null;

        //Verificação de conexao conectar
        private bool Conectar()
        {
            ObjCon = new SqlConnection(strCon);
            try
            {
                ObjCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        //verificação de conexao desconectar
        private bool desconectar()
        {
           if (ObjCon.State != ConnectionState.Closed)
           {
           ObjCon.Close();
           ObjCon.Dispose();
               return true;
           }
           else
           {
           ObjCon.Dispose();
               return false;
           }
            }

        //Clsse de inserir dados no banco 
        public bool Insert()
        {
            if (this.Conectar())
            {
            }
            {
              try
                }
            
                catch()
                    {
                    
                    }
                finally
                {
                this.desconectar();
                }

        //Clsse de Update dados no banco 
        public bool Update()
        { 
        
        }

        //Clsse de deletar dados no banco 
        public bool Delete()
        { 
        }

        //Clsse de Lista Grid dados no banco 
        public DataTable ListaGrid()
        { 
        
        }

        //Clsse de Pesquisa dados no banco 
        public DataTable Pesquisar()
        {

        }

        }
    }
