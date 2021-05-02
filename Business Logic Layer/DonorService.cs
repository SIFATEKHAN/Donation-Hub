using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class DonorService
    {
        DonorDataAccess donorDataAccess;

        public DonorService()
        {
            this.donorDataAccess = new DonorDataAccess();
        }

        public object DonorDataAccess { get; private set; }

        public List<Donor> GetAllDonors()
        {
            return this.donorDataAccess.GetDonors();
        }
        public Donor GetDonor(int DonorID)
        {
            return this.donorDataAccess.GetDonor(DonorID);
        }

        
        public int UpdateExistingDonor( string firstName, string LasttName, string email, string username, string password,string address, string gender, string bloodGroup)
        {
            Donor donor = new Donor() {  FirstName = firstName, Lastname = LasttName, Email = email, Username = username, Password = password, Address = address, Gender = gender, BloodGroup = bloodGroup };
            //OrganisationID
            return this.donorDataAccess.UpdateDonor(donor);
        }
        
    }

}
