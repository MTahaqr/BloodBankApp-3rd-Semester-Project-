using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BloodBankApp_FinalProject_
{
    abstract class DonorOrPatient
    {
        public abstract SqlDataAdapter RefreshDonors();
        public abstract SqlDataAdapter RefreshPatients();

    }
}
