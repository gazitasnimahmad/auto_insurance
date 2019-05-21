using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace x { 
class Program
{
    static void Main(string[] args)
    {
        List<Note> noteList = new List<Note>();
	    Console.WriteLine("Enter the number of notes:");
        int x = int.Parse(Console.ReadLine());
        for(int i = 1; i <= x; i++)
            {
                string s = Console.ReadLine();
                Note n = Note.CreateNote(s);
                noteList.Add(n);
            }
     
	    Console.WriteLine("Enter a type to sort:\n1.Sort by name\n2.Sort by priority level\n3.Sort by date created");
        int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    noteList.Sort();
                    Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", "Name", "Content", "Size", "Priority level", "Created date");
                    foreach(var j in noteList)
                    {
                        Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", j.Name, j.Content, j.Size, j.PriorityLevel, j.CreatedDate.ToString("dd-MM-yyyy"));
                    }
                    break;
                case 2:
                    PriorityLevelComparer p = new PriorityLevelComparer();
                    noteList.Sort(p);
                    Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", "Name", "Content", "Size", "Priority level", "Created date");
                    foreach (var j in noteList)
                    {
                        Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", j.Name, j.Content, j.Size, j.PriorityLevel, j.CreatedDate.ToString("dd-MM-yyyy"));
                    }
                    break;
                case 3:
                    DateComparer d = new DateComparer();
                    noteList.Sort(d);
                    Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", "Name", "Content", "Size", "Priority level", "Created date");
                    foreach (var j in noteList)
                    {
                        Console.WriteLine("{0,-15} {1,-20} {2,-5:0.0} {3,-15:0.0} {4}", j.Name, j.Content, j.Size, j.PriorityLevel, j.CreatedDate.ToString("dd-MM-yyyy"));
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
    }
  } 
}