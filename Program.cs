namespace EagleEye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgentDAL dal = new AgentDAL();
            try
            {
                dal.AddAgent(new Agent
                { 
                    Id = 1, 
                    CodeName = "ppp", 
                    RealName = "huj", 
                    Location = "lopi", 
                    Status =statusAgent.Active,
                    MissionsCompleted = 7
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }

            //List<Agent> agents = dal.GetAllAgents();

            dal.UpdateAgentLocation(5, "Tokyo");

            //dal.deleteAgent(2);
        }







    }
}
