using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fakturiranje.Model;
using System.Data.OleDb;
using System.Data;

namespace Fakturiranje.ViewModel
{
    public class ArtiklViewModel
    {
        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        public string ConnectionString { get; set; }
        public string Path { get; set; }
        public Artikl Artikl { get; set; }

        public ArtiklViewModel()
        {
            Path = @"C:\ZisTools\OsnovniPodaci.mdb";
            ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Path + ";Persist Security Info=False;";

            Artikl = new Artikl();
        }

        public void InsertArtikl()
        {
            // definiraj konekciju sa bazom
            Connection = new OleDbConnection(ConnectionString);
            string insertCommand = String.Format("INSERT INTO Artikli(FLAG, SIFRA, BARKOD, NAZIV, JM, TB, MPC, VPC, NC, ZALIHE, RG, KALO)" +
            "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", Artikl.Flag, Artikl.Sifra, 
            Artikl.Barkod, Artikl.Naziv, Artikl.JM, Artikl.TB, Artikl.MPC,
            Artikl.VPC, Artikl.NC, Artikl.Zalihe, Artikl.RG, Artikl.Kalo);

            Command = new OleDbCommand(insertCommand, Connection);

            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable DohvatiSveArtikle()
        {
            Connection = new OleDbConnection(ConnectionString);
            string selectCommand = "SELECT * FROM Artikli";
            DataTable datatable = new DataTable();

            try
            {
                Connection.Open();
                Command = new OleDbCommand(selectCommand, Connection);
                datatable.Load(Command.ExecuteReader());
                Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return datatable;
        }

        public Artikl GetArtikl(int artiklID)
        {
            Artikl artikl = new Artikl();

            Connection = new OleDbConnection(ConnectionString);
            string selectCommand = "SELECT * FROM Artikli WHERE ID = " + artiklID;
            DataTable datatable = new DataTable();
            DataRow row = datatable.NewRow();
            
            try
            {
                Connection.Open();
                Command = new OleDbCommand(selectCommand, Connection);
                datatable.Load(Command.ExecuteReader());
                row = datatable.Rows[0];

                // Spremi u model
                artikl.IDArtikl = (int)row["ID"];
                artikl.Flag = row["FLAG"].ToString();
                artikl.Sifra = row["SIFRA"].ToString();
                artikl.Barkod = row["BARKOD"].ToString();
                artikl.Naziv = row["NAZIV"].ToString();
                artikl.JM = row["JM"].ToString();
                artikl.TB = Convert.ToDecimal(row["TB"].ToString());
                artikl.MPC = Convert.ToDecimal(row["MPC"].ToString());
                artikl.VPC = Convert.ToDecimal(row["VPC"].ToString());
                artikl.NC = Convert.ToDecimal(row["NC"].ToString());
                artikl.Zalihe = Convert.ToInt32(row["ZALIHE"].ToString());
                artikl.RG = row["RG"].GetType() == typeof(DBNull) ? 0 : Convert.ToInt32(row["RG"]);
                artikl.Kalo = row["KALO"].GetType() == typeof(DBNull) ? 0 : Convert.ToInt32(row["KALO"]);

                Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return artikl;
        }

        public void DeleteArtikl(int artiklID)
        {
            string commandString = "DELETE FROM Artikli WHERE ID = " + artiklID;
            OleDbCommand command = new OleDbCommand(commandString, Connection);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateArtikl(int artiklID) 
        {
            string commandString = String.Format("UPDATE Artikli SET FLAG = '{0}', SIFRA = '{1}'," +
            "BARKOD = '{2}', NAZIV = '{3}', JM = '{4}', TB = '{5}', MPC = '{6}', VPC = '{7}', NC = '{8}'," +
            "ZALIHE = '{9}', RG = '{10}', KALO = '{11}' WHERE ID = " + artiklID, Artikl.Flag, Artikl.Sifra, Artikl.Barkod,
            Artikl.Naziv, Artikl.JM, Artikl.TB, Artikl.MPC, Artikl.VPC, Artikl.NC, Artikl.Zalihe, Artikl.RG, Artikl.Kalo);
            
            OleDbCommand command = new OleDbCommand(commandString, Connection);

            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
