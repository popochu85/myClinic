using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClinic.Model;

namespace myClinic.Controller
{
    internal class PatientController
    {
        public Patient patient { get; set; }
        public PatientController()
        {
            this.patient = new Patient();
        }

        public List<Patient> getPatients()
        {
            
            return patient.getPatients();
        }

    }
}
