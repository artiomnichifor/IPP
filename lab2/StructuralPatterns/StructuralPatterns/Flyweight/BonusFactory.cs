using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    class BonusFactory
    {
        Dictionary<string, IBonus> bonuses = new Dictionary<string, IBonus>();

        public int TotalObjectsCreated
        {
            get { return bonuses.Count; }
        }

        public IBonus GetBonus(string BonusName)
        {
            IBonus bonus = null;
            if (bonuses.ContainsKey(BonusName))
            {
                bonus = bonuses[BonusName];
            }
            else
            {
                switch (BonusName)
                {
                    case "PrimeUserBonus":
                        bonus = new PrimeUserBonus();
                        bonuses.Add("PrimeUserBonus", bonus);
                        break;
                    case "OneYearUserBonus":
                        bonus = new OneYearUserBonus();
                        bonuses.Add("OneYearUserBonus", bonus);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return bonus;
        }
    }
}
