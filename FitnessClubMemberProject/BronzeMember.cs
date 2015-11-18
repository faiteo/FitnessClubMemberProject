using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubMemberProject
{
    public class BronzeMember: Member
    {

        //the default percentage that is charged for being a Bronze member is fixed at 5%
        private const float percentageChargeBronze = 0.05f;


        public BronzeMember()
        {
          
        }
        
        
        public float PercentageChargeBronze
        {
            get { return percentageChargeBronze; }
        }

        //Method Hiding
        public new float CalculateMemberDue()
        {
            float percentage = PercentageChargeBronze;
            float flatrate = base.MemberFlatRate;
            float bronzeMemberDue = flatrate + (flatrate * percentage);

            return bronzeMemberDue;
        }

        //Method Override
        public override void PrintInfo()
        {
            Console.WriteLine("Printing a BRONZEMEMBER info: ");
            base.PrintInfo();
            Console.WriteLine("Membership Due: {0}", this.CalculateMemberDue());
        }

    }
}
