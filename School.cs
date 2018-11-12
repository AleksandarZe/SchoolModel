using System.Collections.Generic;
using System.Text;

namespace MultipleClasses
{
    public class School
    {
        public string name { get; set; }
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public School(string name)
        {
            this.name = name;
            this.Groups = new List<Group>();
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public override string ToString()
        {
            StringBuilder opa = new StringBuilder();
            opa.AppendLine("School: " + this.name);
            opa.AppendLine("Groups: " + string.Join(", ",this.Groups.Select(x => x.name)));
            opa.AppendLine("Teachers: " + string.Join(", ",this.Teachers.Select(x => x.Name)));

            foreach(var gr in this.Groups)
            {
                opa.Append("\n---\n");
                opa.Append(gr);
            }
            foreach(var tea in this.Teachers)
            {
                opa.Append("\n---\n");
                opa.Append(tea);
            }
            return opa.ToString();
        }
    }
}
