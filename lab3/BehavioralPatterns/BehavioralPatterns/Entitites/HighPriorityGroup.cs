using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class HighPriorityGroup : Group
    {
        public HighPriorityGroup(string name, string target) : base(name, target)
        {
        }
        public override void HandleRequest(Requestor req)
        {
            if (req.Priority > 0 && req.Priority < 10)
            {
                requestors.Add(req);
                req.Group = this;
            }
            else if (successor != null)
            {
                successor.HandleRequest(req);
            }
        }

    }
}
