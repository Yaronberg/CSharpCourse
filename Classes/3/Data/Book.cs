using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Data
{
    class Book
    {
        Author author = new Author();
        Title title = new Title();
        Content content = new Content();
        //, string NameTitle, string NameContent
        public void AddInfo(string NameAuthor, string NameTitle, string NameContent)
        {
            author.NameAuthor = NameAuthor;
            title.NameTitle = NameTitle;
            content.NameContent = NameContent;
        }
        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
