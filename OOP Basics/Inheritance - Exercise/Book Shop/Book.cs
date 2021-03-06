﻿
namespace Book_Shop
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (Regex.IsMatch(value," \\d"))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
