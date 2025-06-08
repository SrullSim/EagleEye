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
    

    
    
    
    
    }
}
