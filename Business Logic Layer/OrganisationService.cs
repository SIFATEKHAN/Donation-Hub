using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class OrganisationService
    {
        OrganisationDataAccess organisationDataAccess ;

        public OrganisationService()
        {
            this.organisationDataAccess = new OrganisationDataAccess();
        }

        public object OrganisationDataAccess { get; private set; }

        public List<VolunteerOrganisation> GetAllVolunteerOrganisations()
        {
            return this.organisationDataAccess.GetOrganisations();
        }
        public VolunteerOrganisation GetVolunteerOrganisation(int organisationID)
        {
            return this.organisationDataAccess.GetOrganisation(organisationID);
        }

        
        public int UpdateExistingOrganisation(string OrganisationName, string email, string username, string password, int govtLicenseNO)
        {
            VolunteerOrganisation volunteerOrganisation = new VolunteerOrganisation() { OrganisationName = OrganisationName, Email = email, Username = username, Password = password, GovtLicenseNo = govtLicenseNO };
            //OrganisationID
            return this.organisationDataAccess.UpdateOrganisation(volunteerOrganisation);
        }
        
    }
    
}
