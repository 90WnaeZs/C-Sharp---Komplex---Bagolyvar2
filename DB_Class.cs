using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bagolyvar2
{
    class DB_Class
    {
        public MySqlConnection conn;

        public void Connection()
        {
            MySqlConnectionStringBuilder conn_str = new MySqlConnectionStringBuilder();
            conn_str.Server = "localhost";
            conn_str.Database = "bagolyvar";
            conn_str.UserID = "root";
            conn_str.Password = "";

            conn = new MySqlConnection(conn_str.ConnectionString);
            conn.Open();
        }

        public void conn_check(MySqlConnection con)
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void könyv_feltöltés(MySqlConnection con,ComboBox cmb_konyv)
        {
            conn_check(con);

            string QUERY_SELECT_könyv = "SELECT Szerzo,Cím FROM konyvek";
            using (MySqlCommand CMD_SELECT_könyv=new MySqlCommand(QUERY_SELECT_könyv,con))
            {
                using (MySqlDataReader READER_SELECT_könyv=CMD_SELECT_könyv.ExecuteReader())
                {
                    while (READER_SELECT_könyv.Read())
                    {
                        cmb_konyv.Items.Add(READER_SELECT_könyv.GetString("Szerzo")+": "+READER_SELECT_könyv.GetString("Cím"));
                    }
                }
            }
            con.Close();
        }

        public void bérlő_feltöltés(MySqlConnection con, ComboBox cmb_konyv)
        {
            conn_check(con);

            string QUERY_SELECT_könyv = "SELECT nev FROM kolcsonzo";
            using (MySqlCommand CMD_SELECT_könyv = new MySqlCommand(QUERY_SELECT_könyv, con))
            {
                using (MySqlDataReader READER_SELECT_könyv = CMD_SELECT_könyv.ExecuteReader())
                {
                    while (READER_SELECT_könyv.Read())
                    {
                        cmb_konyv.Items.Add(READER_SELECT_könyv.GetString("nev"));
                    }
                }
            }
            con.Close();
        }

        
    }
}
