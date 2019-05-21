using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Post
    {
        long _id;
        string _content;
        string _type;
        DateTime _postedTime;
        User _postedBy;
        int _numberOfUpVotes;
        int _numberOfDownVotes;

        public Post(long id, string content, string type, DateTime postedTime, User postedBy, int numberOfUpVotes, int numberOfDownVotes)
        {
            Id = id;
            Content = content;
            Type = type;
            PostedTime = postedTime;
            PostedBy = postedBy;
            NumberOfUpVotes = numberOfUpVotes;
            NumberOfDownVotes = numberOfDownVotes;
        }

        public long Id { get { return _id; } set { _id = value; } }
        public string Content { get { return _content; } set { _content = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public DateTime PostedTime { get { return _postedTime; } set { _postedTime = value; } }
        public int NumberOfUpVotes { get { return _numberOfUpVotes; } set { _numberOfUpVotes = value; } }
        public int NumberOfDownVotes { get { return _numberOfDownVotes; } set { _numberOfDownVotes = value; } }
        internal User PostedBy { get { return _postedBy; } set { _postedBy = value; } }

        public static Post CreatePost(string detail, User user)
        {
            string[] i = detail.Split(',');
            return new Post(long.Parse(i[0]), i[1], i[2], DateTime.ParseExact(i[3],"dd-MM-yyyy hh:mm:ss", null), user, int.Parse(i[4]), int.Parse(i[5]));

        }
        public static SortedDictionary<string, int> CalculatePostCount(List<Post> list)
        {
            SortedDictionary<string, int> d = new SortedDictionary<string, int>();
            List<string> p = new List<string>();
            foreach(var x in list)
            {
                p.Add(x.Type);
            }

            foreach (var c in p.Distinct())
            {
                int count = 0;
                foreach(var b in list)
                {
                    if(b.Type == c)
                    {
                        count++;
                    }
                }
                d.Add(c, count);
            }
            return d;
        }
        public static String PredictTrending(SortedDictionary<string, int> postCount)
        {
            int max = 0;
            string k = "";
            foreach(var x in postCount)
            {
                if(x.Value > max)
                {
                    max = x.Value;
                    k = x.Key;
                }
            }

            return k;

        }
    }
}
