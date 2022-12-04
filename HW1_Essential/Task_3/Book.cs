using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Book
    {

        Title title;
        Content content;
        Author author;

        public Book(Title title, Content content, Author author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
        }

        public void Show()
        {
            this.title.Show();
            this.content.Show();
            this.author.Show();
        }
    }
}
