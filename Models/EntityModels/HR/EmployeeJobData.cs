using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.EntityModels.HR
{
    public class EmployeeJobData
    {
        [Key]
        [ForeignKey("EmployeePerson")]
        public int EmployeePersonID { get; set; }


        public DateTime HireDate { get; set; }

        [ForeignKey("ManagerAgreementType")]
        public int ManagerAgreementTypeID { get; set; }

        [ForeignKey("DutyStation")]
        public int DutyStationID { get; set; }
        [ForeignKey("EmployeePossition")]
        public int EmployeePossitionID { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime ProbationExpirationDate { get; set; }

        public bool IsTemporaryEmployee { get; set; }

   
        public int ManagerID { get; set; }

        [ForeignKey("OrganizationEntity")]
        public int OrganizationEntityID { get; set; }
        
        public DateTime TerminationDate { get; set; }

        public bool ConsiderOveruse { get; set; }



        public OrganizationEntity OrganizationEntity { get; set; }
        public EmployeePerson EmployeePerson { get; set; }
        public EmployeePossition EmployePossition { get; set; }
       // public EmployeePerson ManagerPerson { get; set; }
        public DutyStation DutyStation { get; set; }
        public ManagerAgreementType ManagerAgreementType { get; set; }


    }
}
