using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubMemberProject
{
    public class SilverMember:Member
    {
        //the extra percentage that is charged for being a Silver member 15% of the flatrate
        private const float percentageChargeSilver = 0.15f;


        //Names of the facilities that are associated with a gold member. Max 3 for a Silver member.
        private string[] facilitiesSilver = new string[3];

        public SilverMember()
        {

        }


        public SilverMember(int memberId, string fname, string lname, string addres, string mcity, string phonenumb, string mailadr, string[] facil)
              : base(memberId, fname, lname, addres, mcity, phonenumb, mailadr)
        {
            facilitiesSilver = facil;
        }   
            
          


        public float PercentageChargeSilver
        {
            get { return percentageChargeSilver; }
        }

        public string[] FacilitiesSilver
        {
            get { return facilitiesSilver; }
            set { facilitiesSilver = value; }
        }

        //Method Hiding
        public new float CalculateMemberDue()
        {
            float percentage = PercentageChargeSilver;
            float flatrate = base.MemberFlatRate;
            float silverMemberDue = flatrate + (flatrate * percentage);

            return silverMemberDue;
        }

        //Method Override
        public override void PrintInfo()
        {
            Console.WriteLine("Printing a SILVERMEMBER info: ");
            base.PrintInfo();
            Console.Write("Facilities allocated to this member: ");
            foreach (string item in FacilitiesSilver)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("Membership Due: {0}", this.CalculateMemberDue());
        }


 

 
 
    }
}
