using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fakturiranje.Model;
using System.Data;

namespace Fakturiranje.ViewModel
{
    public class KupacViewModel //: IViewModel
    {
        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        public string ConnectionString { get; set; }
        public string Path { get; set; }
        public Kupac Kupac { get; set; }

        public KupacViewModel()
        {
            Path = @"C:\ZisTools\OsnovniPodaci.mdb";
            ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Path + ";Persist Security Info=False;";

            Kupac = new Kupac();
        }

        public DataTable DohvatiSveKupce()
        {
            Connection = new OleDbConnection(ConnectionString);
            string selectCommand = "SELECT * FROM Kupci";
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

        public Kupac GetKupac(int kupacID)
        {
            Kupac kupac = new Kupac();

            Connection = new OleDbConnection(ConnectionString);
            string selectCommand = "SELECT * FROM Kupci WHERE ID = " + kupacID;
            DataTable datatable = new DataTable();
            DataRow row = datatable.NewRow();

            try
            {
                Connection.Open();
                Command = new OleDbCommand(selectCommand, Connection);
                datatable.Load(Command.ExecuteReader());
                row = datatable.Rows[0];

                // Spremi u model
                kupac.IDKupac = (int)row["ID"];
                kupac.Flag = row["FLAG"].GetType() == typeof(DBNull) ? "0" : row["FLAG"].ToString();
                kupac.Sifra = row["SIFRA"].ToString();
                kupac.Naziv = row["NAZIV"].ToString();
                kupac.OIB = row["OIB"].ToString();
                kupac.Mjesto = row["MJESTO"].ToString();
                kupac.Adresa = row["ADRESA"].ToString();
                kupac.Telefon = row["TELEFON"].ToString();
                kupac.Telefax = row["TELEFAX"].ToString();
                kupac.Mobitel = row["MOBITEL"].ToString();
                kupac.Mail = row["MAIL"].ToString();
                kupac.Kontakt = row["KONTAKT"].ToString();
                kupac.Rabat = row["RABAT"].GetType() == typeof(DBNull) ? 0 : Convert.ToInt32(row["RABAT"]);

                Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return kupac;
        }

        public void InsertKupac()
        {
            // definiraj konekciju sa bazom
            Connection = new OleDbConnection(ConnectionString);
            string insertCommand = String.Format("INSERT INTO Kupci(Flag, Sifra, Naziv, OIB, Mjesto, Adresa, Telefon, Telefax," +
            "Mobitel, Mail, Kontakt, Rabat) VALUES('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}', '{8}', '{9}', '{10}', '{11}')",
                Kupac.Flag, Kupac.Sifra, Kupac.Naziv, Kupac.OIB, Kupac.Mjesto, Kupac.Adresa, Kupac.Telefon, Kupac.Telefax, Kupac.Mobitel, 
                Kupac.Mail, Kupac.Kontakt, Kupac.Rabat);

            Command = new OleDbCommand(insertCommand, Connection);

            try
            {
                //otvori konekciju i izvrši insert komandu
                Connection.Open();

                Command.ExecuteNonQuery();

                Connection.Close();
            }
            catch (Exception)
            {
                // Ulovi iznimke
                throw;
            }
        }

        public void DeleteKupac(int kupacID)
        {
            string commandString = "DELETE FROM Kupci WHERE ID = " + kupacID;
            OleDbCommand command = new OleDbCommand(commandString, Connection);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void UpdateKupac(int kupacID)
        {
            string commandString = String.Format("UPDATE Kupci SET Flag = @Flag, Sifra = @Sifra, " + 
                "Naziv = @Naziv, OIB = @OIB, Mjesto = @Mjesto, Adresa = @Adresa, Telefon = @Telefon, Telefax = @Telefax, " + 
                "Mobitel = @Mobitel, Mail = @Mail, Kontakt = @Kontakt, Rabat = @Rabat WHERE ID = " + kupacID);
            
            OleDbCommand command = new OleDbCommand(commandString, Connection);

            command.Parameters.AddRange(new OleDbParameter[]
            {
                new OleDbParameter("@Flag", Kupac.Flag),
                new OleDbParameter("@Sifra", Kupac.Sifra),
                new OleDbParameter("@Naziv", Kupac.Naziv),
                new OleDbParameter("@OIB", Kupac.OIB),
                new OleDbParameter("@Mjesto", Kupac.Mjesto),
                new OleDbParameter("@Adresa", Kupac.Adresa),
                new OleDbParameter("@Telefon", Kupac.Telefon),
                new OleDbParameter("@Telefax", Kupac.Telefax),
                new OleDbParameter("@Mobitel", Kupac.Mobitel),
                new OleDbParameter("@Mail", Kupac.Mail),
                new OleDbParameter("@Kontakt", Kupac.Kontakt),
                new OleDbParameter("@Rabat", Kupac.Rabat)
            });

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
