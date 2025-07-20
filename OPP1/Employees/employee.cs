using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1.Employees
{
    #region Enums
    public enum SecurityLevel
    {
        guest,
        Developer,
        secretary,
        DBA,
    }
    public enum Gender
    {
        Male,
        Female,
    }
    #endregion
    class Hiringdate
    {
        private int day;
        private int month;
        private int year;
        public Hiringdate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Day must be between 1 and 31.");
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12.");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2000 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Year must be between 1900 and the current year.");
                }
            }
        }
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }
        class employee
        {
            #region Properties
            private int Id;
            private string Name;
            private SecurityLevel SecurityLevel;
            private double Salary;
            private Gender Gender;

            public int id
            {
                get { return Id; }
            }
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }
            public SecurityLevel securityLevel
            {
                get { return SecurityLevel; }
                set { SecurityLevel = value; }
            }
            public double salary
            {
                get { return Salary; }
                set { Salary = value; }
            }
            public Hiringdate HireDate { get; set; }

            public Gender gender
            {
                get { return Gender; }
                set { Gender = value; }
            }

            #endregion

            #region Constructor
            public employee(int id, string name, SecurityLevel securityLevel, int salary, Hiringdate hiredate, Gender gender)
            {
                this.Id = id;
                this.Name = name;
                this.SecurityLevel = securityLevel;
                this.Salary = salary;
                this.HireDate = hiredate;
                this.Gender = gender;
            }

            #endregion

            #region Display
            public override string ToString()
            {
                return $"employee id: {Id}\nemployee name: {Name}\nemployee securityLevel: {SecurityLevel}\nemployee salary: {Salary:C}\nemployee hiredate: {HireDate}\nemployee gender: {Gender}";
            }
        #endregion
        public class ReverseClass : IComparer<employee>
        {
            public int Compare(employee? x, employee? y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;

                DateTime dateX = new DateTime(x.HireDate.Year, x.HireDate.Month, x.HireDate.Day);
                DateTime dateY = new DateTime(y.HireDate.Year, y.HireDate.Month, y.HireDate.Day);

                return dateX.CompareTo(dateY);
            }
        }
    }
    }