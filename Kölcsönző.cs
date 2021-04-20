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
    public partial class Kölcsönző : Form
    {
        DB_Class db;
        public Kölcsönző()
        {
            InitializeComponent();
            db = new DB_Class();
            db.Connection();
            db.könyv_feltöltés(db.conn, combo_konyv);
            db.bérlő_feltöltés(db.conn, combo_berlo);
        }

        private void btn_Tárol_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);

            listBox1.Items.Add(combo_berlo.Text+" -> "+ combo_konyv.Text+" ("+ num_peldany.Value+" db)");
        }

        private void btn_Rögzítés_Click(object sender, EventArgs e)
        {
            db.conn_check(db.conn);

            int berloID = 0;
            string konyvKod = "";
            string berlo = "";
            string szerzo = "";
            string konyv = "";
            string peldany = "";

            string QUERY_SELECT_berloID = "SELECT ID FROM kolcsonzo WHERE nev=@nev";
            string QUERY_SELECT_konyvID = "SELECT Kod FROM konyvek WHERE Szerzo=@szerzo AND Cím=@cim";
            string QUERY_INSERT_kolcsonzes = "INSERT INTO kolcsonzes(konyvID,kolcsonzoID,kivetelDatum,peldany) VALUES(@konyvID,@kolcsID,@date,@peldany)";
            //INSERT INTO `kolcsonzes`(`konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`) VALUES ([value-1],[value-2],[value-3],[value-4])

            using (MySqlCommand CMD_SELECT_berloID = new MySqlCommand(QUERY_SELECT_berloID, db.conn))
            using (MySqlCommand CMD_SELECT_konyvID = new MySqlCommand(QUERY_SELECT_konyvID, db.conn))
            using (MySqlCommand CMD_INSERT_kolcsonzes = new MySqlCommand(QUERY_INSERT_kolcsonzes, db.conn))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string currentItem = listBox1.Items[i].ToString();

                    string[] t_berlo = currentItem.Split(new string[] { " -> "},StringSplitOptions.None);
                    berlo = t_berlo[0].Trim();

                    string[] t_szerzo = t_berlo[1].Split(':');
                    szerzo = t_szerzo[0].Trim();

                    string[] t_konyv = t_szerzo[1].Split(new string[] {" ("},StringSplitOptions.None);
                    konyv = t_konyv[0].Trim();

                    string[] t_peldany = t_konyv[1].Split(new string[] {" db)"},StringSplitOptions.None);
                    peldany = t_peldany[0].Trim();
                    peldany = peldany.Replace(" db)","");

                    CMD_SELECT_berloID.Parameters.Add("@nev",MySqlDbType.VarChar).Value = berlo;
                    using (MySqlDataReader READER_SELECT_berloID=CMD_SELECT_berloID.ExecuteReader())
                    {
                        READER_SELECT_berloID.Read();
                        berloID = Convert.ToInt32(READER_SELECT_berloID.GetString("ID"));
                        READER_SELECT_berloID.Close();
                    }

                    CMD_SELECT_konyvID.Parameters.Add("@szerzo", MySqlDbType.VarChar).Value = szerzo;
                    CMD_SELECT_konyvID.Parameters.Add("@cim", MySqlDbType.VarChar).Value = konyv;
                    using (MySqlDataReader READER_SELECT_konyvID = CMD_SELECT_konyvID.ExecuteReader())
                    {
                        READER_SELECT_konyvID.Read();
                        konyvKod =READER_SELECT_konyvID.GetString("Kod");
                    }

                    CMD_INSERT_kolcsonzes.Parameters.Add("@konyvID", MySqlDbType.VarChar).Value = konyvKod;
                    CMD_INSERT_kolcsonzes.Parameters.Add("@kolcsID", MySqlDbType.Int32).Value = berloID;
                    CMD_INSERT_kolcsonzes.Parameters.Add("@date", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    CMD_INSERT_kolcsonzes.Parameters.Add("@peldany", MySqlDbType.Int32).Value = Convert.ToInt32(peldany);
                    //@konyvID,@kolcsID,@date,@peldany
                    if(CMD_INSERT_kolcsonzes.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Sikeres kölcsönzés!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen kölcsönzés!");
                    }
                    //MessageBox.Show("Bérlő: "+berlo+" Szerző: "+szerzo+" Könyv: "+konyv+" Példány: "+peldany);
                }

            }
        }
    }
}
