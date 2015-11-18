using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubMemberProject
{
    public class GoldMember: Member
    {
        //The extra percentage that is charged for being a Gold member 25%
        private const float percentageChargeGold = 0.25f;

        //Name of the personal trainer attached to a gold member. ..in reality we should use the ID
        private string personalTrainerName;

        //Names of the facilities that are associated with a gold member. Max 6 facilities for a gold member. ..in reality we should use the ID
        private string[] facilitiesGold = new string[6];

        //Name of the personnel that is responsible for advising a gold member on nutrition ..in reality we should use the ID
        private string nutritionistName;

       
        
        public GoldMember()
        {

        }

        public GoldMember(int memberId, string fname, string lname, string addres, string mcity, string phonenumb, string mailadr, string trainerName,
            string nutritionistname, string[] facil)
            : base(memberId, fname, lname, addres, mcity, phonenumb, mailadr)
        {
            personalTrainerName = trainerName;
            NutritionistName = nutritionistname;
            facilitiesGold = facil;
        }

        public float PercentageChargeGold
        {
            get { return percentageChargeGold; }
        }


        public string NutritionistName
        {
            get { return nutritionistName; }
            set { nutritionistName = value; }
        }
        

        public string PersonalTrainerName
        {
            get { return personalTrainerName; }
            set { personalTrainerName = value; }
        }


        public string[] FacilitiesGold
        {
            get { return facilitiesGold; }
            set { facilitiesGold = value; }
        }


        //Method Hiding
        public new float CalculateMemberDue()
        {
            float percentage = PercentageChargeGold;
            float flatrate = base.MemberFlatRate;
            float goldmemberdue = flatrate + (flatrate * percentage);
            return goldmemberdue;
        }


        //Method Override
        public override void PrintInfo()
        {
            Console.WriteLine("Printing a GOLDMEMBER info: ");
            base.PrintInfo();
            Console.WriteLine("Personal Trainer: {0} ", PersonalTrainerName);
            Console.WriteLine("Nutrisionist: {0}", NutritionistName);
            Console.Write("Facilities allocated to this member: ");
            foreach (string item in FacilitiesGold)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("Membership Due: {0}", this.CalculateMemberDue());


           
        }


  

 
    }
}
