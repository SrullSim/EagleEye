using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleEye
{

    public enum statusAgent
    { 
        Active,
        Injured,
        Missing,
        Retired
    }
    internal class Agent
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string RealName { get; set; }
        public string Location { get; set; }
        public  statusAgent Status  { get; set; }
        public int MissionsCompleted { get; set; }
    

    public Agent(int id, string codeName, string realName, string location, statusAgent status, int missionsCompleted)
        {
            this.Id = id;
            this.CodeName = codeName;
            this.RealName = realName;
            this.Location = location;
            this.Status = status;
            this.MissionsCompleted = missionsCompleted;
        }
        public Agent() 
        {
            this.Id = 0;
            this.CodeName = string.Empty;
            this.RealName = string.Empty;
            this.Location = string.Empty;
            this.Status = statusAgent.Active;
            this.MissionsCompleted = 0;
        }



    }
}
