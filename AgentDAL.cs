using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace EagleEye
{
    internal class AgentDAL
    {
        private string connectionString = "" +
            "server=localhost;" +
            "user=root;" +
            "port=3306;" +
            "database=eagleEyeDB;";

        // add agent to DB
        public void AddAgent(Agent agent)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            string query = @"INSERT INTO agents(codeName, realName, location, status, missionsCompleted)
                            VALUE(@codeName, @realName, @location, @status, @missionsCompleted)";

            MySqlCommand command = new MySqlCommand(query, connect);

            command.Parameters.AddWithValue("@codeName", agent.CodeName);
            command.Parameters.AddWithValue(@"realName", agent.RealName);
            command.Parameters.AddWithValue("@location", agent.Location);
            command.Parameters.AddWithValue("@status", agent.Status.ToString());
            command.Parameters.AddWithValue("@missionsCompleted", agent.MissionsCompleted);

            command.ExecuteNonQuery();
        
        
        }


        // get all agents in DB
        public List<Agent> GetAllAgents()
        {
            List<Agent> agents = new List<Agent>();

            MySqlConnection Connect = new MySqlConnection(connectionString);
            Connect.Open();

            string query = "SELECT * FROM agents";

            MySqlCommand command = new MySqlCommand(query, Connect);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Agent agent = new Agent
                {
                    Id = reader.GetInt32("id"),
                    CodeName = reader.GetString("codeName"),
                    RealName = reader.GetString("realName"),
                    Location = reader.GetString("location"),
                    Status = (statusAgent)Enum.Parse(typeof(statusAgent), reader.GetString("status")),
                    MissionsCompleted = reader.GetInt32("missionsCompleted")
                };
                agents.Add(agent);
            }
            reader.Close();
            return agents;

        }

        // update agent in DB
        public void UpdateAgentLocation(int idAgent, string location)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            string query = @"UPDATE agents SET location = @location WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, connect);

            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@id", idAgent);

            command.ExecuteNonQuery();

        }


        // delete agent from DB
        public void deleteAgent(int idAgent)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();

            string query = @"DELETE FROM agents WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, connect);

            command.Parameters.AddWithValue("@id", idAgent);

            command.ExecuteNonQuery();
        }













    }
}
