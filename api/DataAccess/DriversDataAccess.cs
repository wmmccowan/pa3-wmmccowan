using api.Models;
using MySql.Data.MySqlClient;
namespace api.DataAccess
{
    public class DriversDataAccess
    {
        public List<Drivers> GetAll()
        {
            List<Drivers> drivers = new List<Drivers>();
            ConnectionString connectionString = new ConnectionString();
            string cs = connectionString.cs;

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            string stm = "SELECT * from drivers";
            MySqlCommand cmd = new MySqlCommand(stm, con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Console.WriteLine(rdr.GetInt32(0) + " " + rdr.GetString(1) + " " + rdr.GetInt32(2) + " " + rdr.GetDateTime(3) + " " + rdr.GetBoolean(4));
                Drivers newDriver = new Drivers(){ID = rdr.GetInt32(0), Name = rdr.GetString(1), Rating = rdr.GetInt32(2), DateHired = rdr.GetDateTime(3), Deleted = rdr.GetBoolean(4)};
                drivers.Add(newDriver);
            }

            con.Close();
            return drivers;
        }
    }
}