using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title1 = new Title() { name = "Brotherhood" };

            Author author1 = new Author() { name = "Oliwer Boudan" };

            Content content1 = new Content() { content = "Story about clan of killers" };



            Book book = new Book() { title = title1, author = author1, content = content1 };

            book.title.Show();

            book.author.Show();

            book.content.Show();
        }
    }
}
