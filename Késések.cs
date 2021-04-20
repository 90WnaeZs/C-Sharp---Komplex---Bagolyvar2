using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bagolyvar2
{
    public partial class Késések : Form
    {
        DB_Class db;
        List<string> késők = new List<string>();
        List<string> késők_nevei = new List<string>();
        public Késések()
        {
            InitializeComponent();
            db = new DB_Class();
            db.Connection();
            késő_bérlő_feltöltés(db.conn,combo_keso,listBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.conn_check(db.conn);
            string osszefuz = "";
            string berloID = "";

            string QUERY_SELECT_kolcsonzes = "SELECT * FROM kolcsonzes";
            string QUERY_SELECT_berloID = "SELECT ID FROM kolcsonzo WHERE nev=@nev";
            string QUERY_SELECT_berlo = "SELECT nev FROM kolcsonzo WHERE ID=@id";
            string QUERY_SELECT_konyv = "SELECT Szerzo,Cím FROM konyvek WHERE Kod=@kod";

            using (MySqlCommand CMD_SELECT_datum = new MySqlCommand(QUERY_SELECT_kolcsonzes, db.conn))
            {
                using (MySqlDataReader READER_SELECT_datum = CMD_SELECT_datum.ExecuteReader())
                {
                    while (READER_SELECT_datum.Read())
                    {
                        késők.Add(READER_SELECT_datum.GetString("konyvID") + ";" + READER_SELECT_datum.GetString("kolcsonzoID") + ";" + READER_SELECT_datum.GetString("kivetelDatum") + ";" + READER_SELECT_datum.GetString("peldany"));
                    }
                }
            }
            foreach (var item in késők)
            {
                osszefuz = "";
                string[] split = item.Split(';');
                DateTime date = DateTime.ParseExact(split[2], "yyyy-MM-dd", null);
                DateTime date2 = DateTime.Today;
                double dif = (date2 - date).TotalDays;

                using (MySqlCommand CMD_SELECT_berloID = new MySqlCommand(QUERY_SELECT_berloID, db.conn))
                {
                    CMD_SELECT_berloID.Parameters.Add("@nev", MySqlDbType.VarChar).Value = combo_keso.Text.Trim();
                    using (MySqlDataReader READER_SELECT_berloID = CMD_SELECT_berloID.ExecuteReader())
                    {
                        READER_SELECT_berloID.Read();
                        berloID = READER_SELECT_berloID.GetString("ID");
                    }
                    if (split[1].Equals(berloID))
                    {
                        if (dif > 400)
                        {

                            using (MySqlCommand CMD_SELECT_berlo = new MySqlCommand(QUERY_SELECT_berlo, db.conn))
                            using (MySqlCommand CMD_SELECT_konyv = new MySqlCommand(QUERY_SELECT_konyv, db.conn))
                            {

                                CMD_SELECT_berlo.Parameters.Add("@id", MySqlDbType.VarChar).Value = split[1];
                                CMD_SELECT_konyv.Parameters.Add("@kod", MySqlDbType.VarChar).Value = split[0];
                                using (MySqlDataReader READER_SELECT_berlo = CMD_SELECT_berlo.ExecuteReader())
                                {
                                    while (READER_SELECT_berlo.Read())
                                    {
                                        osszefuz += READER_SELECT_berlo.GetString("nev");
                                    }
                                }
                                using (MySqlDataReader READER_SELECT_konyv = CMD_SELECT_konyv.ExecuteReader())
                                {
                                    while (READER_SELECT_konyv.Read())
                                    {
                                        osszefuz += " -> " + READER_SELECT_konyv.GetString("Szerzo");
                                    }
                                }
                            }
                            listBox1.Items.Clear();
                            listBox1.Items.Add(osszefuz);
                        }
                    }
                }
            }
            db.conn.Close();
        }
        public void késő_bérlő_feltöltés(MySqlConnection con, ComboBox cmb_berlo, ListBox lb)
        {
            db.conn_check(con);

            string QUERY_SELECT_datum = "SELECT * FROM kolcsonzes";
            string QUERY_SELECT_berlo = "SELECT nev FROM kolcsonzo WHERE ID=@id";
            

            using (MySqlCommand CMD_SELECT_datum = new MySqlCommand(QUERY_SELECT_datum, con))
            {
                using (MySqlDataReader READER_SELECT_datum = CMD_SELECT_datum.ExecuteReader())
                {

                    while (READER_SELECT_datum.Read())
                    {
                        késők.Add(READER_SELECT_datum.GetString("konyvID") + ";" + READER_SELECT_datum.GetString("kolcsonzoID") + ";" + READER_SELECT_datum.GetString("kivetelDatum") + ";" + READER_SELECT_datum.GetString("peldany"));

                    }
                }
            }
            foreach (var item in késők)
            {
                string[]split = item.Split(';');
                DateTime date = DateTime.ParseExact(split[2], "yyyy-MM-dd", null);
                DateTime date2 = DateTime.Today;
                double dif = (date2 - date).TotalDays;

                if (dif > 400)
                {
                    using (MySqlCommand CMD_SELECT_berlo = new MySqlCommand(QUERY_SELECT_berlo, con))
                    {
                        CMD_SELECT_berlo.Parameters.Add("@id", MySqlDbType.VarChar).Value = split[1];
                        using (MySqlDataReader READER_SELECT_berlo = CMD_SELECT_berlo.ExecuteReader())
                        {
                            while (READER_SELECT_berlo.Read())
                            {
                                késők_nevei.Add(READER_SELECT_berlo.GetString("nev"));
                                //for (int i = 0; i < split.Length; i++)
                                //{
                                //    if(!split[i].Equals(READER_SELECT_berlo.GetString("nev")))
                                //    {
                                //        cmb_berlo.Items.Add(READER_SELECT_berlo.GetString("nev"));
                                //    }
                                //}
                            }
                        }
                    }
                }
            }
            késők_nevei=késők_nevei.Distinct().ToList();
            foreach (var item in késők_nevei)
            {
                cmb_berlo.Items.Add(item.ToString());
            }
            con.Close();
        }
    }
}
