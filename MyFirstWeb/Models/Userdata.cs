﻿namespace MyFirstWeb.Models
{
    public class Userdata
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Dob { get; set; }
        public string Designation { get; set;}
        public int Salary { get; set;}
        public Gender Gender { get; set; }

    }
    public enum Gender
    {
        MALE,
        FEMALE,
    }
}