//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {

        public Employee(string _name, DateTime _BirthDate, string _Gender, string _Email, string _CPF, DateTime _StartDate, string _Team)
        {
            this.Name = _name;
            this.BirthDate = _BirthDate;
            this.Gender = _Gender;
            this.Email = _Email;
            this.CPF = _CPF;
            this.StartDate = _StartDate;
            this.Team = _Team;
        }

        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Team { get; set; }

        public enum TeamValue
        {
            Noone = 0,
            FrontEnd = 1,
            Mobile = 2,
            BackEnd = 3
        }

    }
}
