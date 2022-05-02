using System;
/*
 * https://www.sololearn.com/learning/eom-project/1080/1024
 */
namespace Social_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
            Console.ReadKey();
        }
    }

    class Post
    {
        private string text;

        public Post()
        {

        }

        public Post(string newText)
        {
            Text = newText;
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        public string Text
        {
            get
            { return text; }
            set
            { text = "New post\n" + value; }
        }

    }
}
