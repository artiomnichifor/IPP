using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    class BillingStatisticsSystem
    {
        private ITarget clientSource;

        public BillingStatisticsSystem(ITarget clientSource)
        {
            this.clientSource = clientSource;
        }

        public void ShowClientsNameList()
        {
            
        }

        public void ShowAverageBallance()
        {

        }

        public void ShowAveerageNumberOfPurchases()
        {

        }
    }
}
