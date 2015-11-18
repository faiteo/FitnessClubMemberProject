using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClubMemberProject
{
    public class Facility
    {
        private int facilityID;

        public int FacilityID
        {
            get { return facilityID; }
            set { facilityID = value; }
        }
        private string facilityName;

        public string FacilityName
        {
            get { return facilityName; }
            set { facilityName = value; }
        }

    }
}
