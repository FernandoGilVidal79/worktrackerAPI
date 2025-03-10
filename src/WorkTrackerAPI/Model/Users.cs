﻿using Dapper;
using KeyAttribute = Dapper.KeyAttribute;

namespace WorkTrackerAPI.Model
{
    /// <summary>
    /// Users Model
    /// </summary>
    public class Users
    {
        [Key]
        [IgnoreInsert]
        public int IdUser { get; set; }

        public string Name { get; set; }

        public string SurName1 { get; set; }

        public string SurName2 { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public string Department { get; set; }

        public bool Status { get; set; }

        public int UserTypeId { get; set; }

        public string Password { get; set; }

        public int NHollidays { get; set; }

       




    }
}
