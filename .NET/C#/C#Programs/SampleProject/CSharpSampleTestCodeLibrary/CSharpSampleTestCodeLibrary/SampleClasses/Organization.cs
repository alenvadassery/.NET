using System;

namespace CSharpSampleTestCodeLibrary.SampleClasses
{
    //Parent Class
    public class Organization
    {
        protected string Name;
        public readonly string OrganizationType;
        public readonly string Sector; // ReadOnly value can be initialized here as well in constructor. No where else.
        private DateTime ObjectCreationDateTime;

        public Organization(string name, string organizationType, string sector)
        {
            this.Name = name;
            this.OrganizationType = organizationType;
            this.Sector = sector;
            this.ObjectCreationDateTime = DateTime.Now;
        }

        public Organization()
        { }

        //public virtual void Appreciation()
    }

    // This is-a relationship. School is a Organization.
    public sealed class School : Organization
    {
        private int NumberOfTeachers;
        private int NumberOfStudents;
        public string EducationMedium;

        // Calling immediate Base class custom constructor to initialize base class field members. 
        public School(string name, string organizationType, string sector,
                      int numberOfTeachers, int numberOfStudents, string educationMedium) : base(name, organizationType, sector)
        {
            this.NumberOfTeachers = numberOfTeachers;
            this.NumberOfStudents = numberOfStudents;
            this.EducationMedium = educationMedium;
        }
        public School()
        { }
    }

    //if you uncomment the code will give compile error. Because the inherited class is sealed.

    //public class SubSchool : School
    //{
    //    // Class Members
    //}
}


