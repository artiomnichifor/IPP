using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class LowPriorityGroup : Group
    {
        public LowPriorityGroup(string name, string target) : base(name, target)
        {
        }

        public override void HandleRequest(Requestor req)
        {
            if (req.Priority > 20)
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
