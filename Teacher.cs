using System.Collections.Generic;
using System.Text;

namespace MultipleClasses
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        public List<Group> Groups { get; set; }

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public Teacher(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Groups = new List<Group>();
        }
        public override string ToString()
        {
            StringBuilder teacherAsString = new StringBuilder();
            teacherAsString.AppendLine("Teachers: " + this.Name);
            teacherAsString.Append("Group of this teacher: " + string.Join(", ",
                this.Groups.Select(x => x.name)));
            return teacherAsString.ToString();
        }

    }
}
