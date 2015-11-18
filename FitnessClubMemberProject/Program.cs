using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubMemberProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GoldMember goldMem = new GoldMember()
            {
                MemberID = 100,
                Firstname = "Feddy",
                Lastname = "Jackson",
                Address = "Victor Vej 10",
                City = "Aarhus",
                Phonenum = "345345345",
                Email = "fredymek@gmail.com",
                FacilitiesGold = new string[] {"Jacuzy", "Squash", "Swimming Pool", "Solarium", "Tennis Court", "Coffee Machine"},
                NutritionistName = "Caroline Flemming",
                PersonalTrainerName = "Victor Andersen"
                
            };


            SilverMember silverMem = new SilverMember()
            {
                MemberID = 101,
                Firstname = "Glammy",
                Lastname = "Tara",
                Address = "Hadsund Vej 100",
                City = "Aalborg",
                Phonenum = "98345345",
                Email = "tara@gmail.com",
                FacilitiesSilver = new string[] { "Swimming Pool", "Solarium",  "Coffee Machine" }

            };



            BronzeMember bronzeMem = new BronzeMember()
            {
                MemberID = 102,
                Firstname = "Mary Jane",
                Lastname = "Gilbert",
                Address = "Suldrup Vej 34",
                City = "Copenhagen",
                Phonenum = "75660021",
                Email = "maryjane@gmail.com"
            };



            goldMem.PrintInfo();
            Console.WriteLine("This ClubMember is a : {0} ", goldMem.GetObjectType(goldMem));
            Console.WriteLine("-------------------------------------------------------------------------");
            silverMem.PrintInfo();
            Console.WriteLine("This ClubMember is a {0} ", silverMem.GetObjectType(silverMem));
            Console.WriteLine("-------------------------------------------------------------------------");
            bronzeMem.PrintInfo();
            Console.WriteLine("This ClubMember is a : {0} ", bronzeMem.GetObjectType(bronzeMem));
            Console.WriteLine("-------------------------------------------------------------------------");


            //Polymorphism
            List<Member> memberList = new List<Member>();
            memberList.Add(goldMem);
            memberList.Add(silverMem);
            memberList.Add(bronzeMem);
            foreach (Member item in memberList)
            {
                item.PrintInfo();
                Console.WriteLine("This ClubMember is a : {0} ", item.GetObjectType(item));
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            Console.ReadLine();

            //Member mem = new Member();
            //Console.WriteLine(mem);
            //Console.WriteLine(mem.ToString());
            //Console.WriteLine(Convert.ToString(mem));

        }
    }
}
