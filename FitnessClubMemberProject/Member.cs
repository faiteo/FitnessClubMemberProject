using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubMemberProject
{
    public class Member
    {

        //The extra percentage that is charged for being a Member 2%
        private const float percentageChargeMember = 0.2f;

 
        //Membership charge or flatrate. This is the initial price that is charged for all members.
        private const float memberFlatRate = 250;

        protected int memberID;
        protected string firstname;
        protected string lastname;
        protected string phonenum;
        protected string email;
        protected string address;
        protected string city;

        public Member(int memId, string fn, string ln, string addr, string city, string phone, string emailadr)
        {
            this.memberID = memId;
            this.firstname = fn;
            this.lastname = ln;
            this.address = addr;
            this.city = city;
            this.phonenum = phone;
            this.email = emailadr;
        }

        public Member()
        {
                
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }


        public float MemberFlatRate
        {
            get { return memberFlatRate; }
            
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
     
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
 
        public string Phonenum
        {
            get { return phonenum; }
            set { phonenum = value; }
        }
      
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
     

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public float PercentageChargeMember
        {
            get { return percentageChargeMember; }
        } 
   


        public virtual void PrintInfo()
        {
            Console.WriteLine("Member ID:  {0}", MemberID);
            Console.WriteLine("Name:  {0}  {1}", Firstname,  Lastname);
            Console.WriteLine("Address: {0} ", Address);
            Console.WriteLine("City: {0} ", City);
            Console.WriteLine("Phone Number: {0} ", Phonenum);
            Console.WriteLine("Email Addr.: {0}", Email);
        }



        public override string ToString()
        {
            string[] lines = {
                                 "Member ID: {0}",
                                 "First Name: {1}",
                                 "Lastname: {2}",
                                 "Address: {3}",
                                 "City: {4}",
                                 "Phone Number: {5}",
                                 "Email: {6}"
                                 

                             };
            return string.Format(string.Join(Environment.NewLine, lines), this.MemberID, this.Firstname, this.Lastname, this.Address, this.City, this.Phonenum, this.Email);
        }

       
        public float CalculateMemberDue()
        {
            float percentage = this.PercentageChargeMember;
            float flatrate = MemberFlatRate;
            float memberdue = flatrate + (flatrate * percentage);
            return memberdue;

        }

        public string GetObjectType(Member obj)
        {
            Type typeobj = obj.GetType();
            string result = typeobj.Name;
            return result;
        }



    }
}
