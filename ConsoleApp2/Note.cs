using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x { 
    class Note
    {
        string _name;
        string _content;
        double _size;
        double _priorityLevel;
        DateTime _createdDate;

        public Note() { }
        public Note(string name, string content, double size, DateTime createdDate, double priorityLevel)
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



        SortedDictionary dic = new SortedDictionary<>
        public static SortedDictionary<DateTime, int> CalculateDateCount(List<Note> list)
        {
            foreach(var i in list)
            {

            }
        }
    }
}