 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    class Note : IComparable
    {
        string _name;
        string _content;
        double _size;
        double _priorityLevel;
        DateTime _createdDate;

        public Note() { }
        public Note(string name, string content, double size, double priorityLevel, DateTime createdDate)
        {
            Name = name;
            Content = content;
            Size = size;
            PriorityLevel = priorityLevel;
            CreatedDate = createdDate;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Content { get { return _content; } set { _content = value; } }
        public double Size { get { return _size; } set { _size = value; } }
        public double PriorityLevel { get { return _priorityLevel; } set { _priorityLevel = value; } }
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }

        public static Note CreateNote(string detail)
        {
            string[] i = detail.Split(',');
            return new Note(i[0], i[1], double.Parse(i[2]), double.Parse(i[3]), DateTime.ParseExact(i[4], "dd-MM-yyyy", null));
        }

        public int CompareTo(object obj)
        {
            Note n = (Note)obj;
            return this._name.CompareTo(n.Name);
        }
    }
}