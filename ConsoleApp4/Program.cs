using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args) 
    {
        List<Post> list = new List<Post>();
        Console.WriteLine("Enter the number of posts");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Enter detail " + (i + 1) + ":");
            string r = Console.ReadLine();
            User u = User.CreateUser(r);
            string s = Console.ReadLine();
            Post p = Post.CreatePost(s, u);
            list.Add(p);
        }
        SortedDictionary<DateTime, int> k = Post.CalculateDateCount(list);
        Console.WriteLine("{0,-15} {1}", "Date", "Count");
        foreach (var t in k)
        {
            Console.WriteLine("{0,-15} {1}",t.Key.ToString("dd-MM-yyyy"),t.Value);
        }
    }
}