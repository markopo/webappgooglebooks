using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppGoogleBooks.Models
{
    public class Book
    {
        public virtual long Id { get; set; }
        public virtual string ItemId { get; set; }
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
        public virtual string Publisher { get; set; }
        public virtual string PublishedDate { get; set; }
        public virtual string Description { get; set; }
        public virtual string PageCount { get; set; }
        public virtual string PrintType { get; set; }
        public virtual string AverageRating { get; set; }
        public virtual string ThumbNail { get; set; }
        public virtual string Language { get; set; }
        public virtual string CanonicalVolumeLink { get; set; }
        public virtual string WebReaderLink { get; set; }
        public virtual string PdfLink { get; set; }
        public virtual string ISBN13 { get; set; }
        public virtual string ISBN10 { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual ISet<Author> Authors { get; set; }
        public virtual ISet<Category> Categories { get; set; }

        protected virtual void InstanceOfAuthor()
        {
            if (Authors == null)
            {
                Authors = new HashSet<Author>();
            }
        }

        protected virtual void InstanceOfCategory()
        {
            if(Categories == null)
            {
                Categories = new HashSet<Category>(); 
            }
        }

        public virtual void AddAuthor(Author author)
        {
            InstanceOfAuthor(); 
            author.Book = this; 
            Authors.Add(author);           
        }

        public virtual void AddCategory(Category category)
        {
            InstanceOfCategory(); 
            category.Book = this; 
            Categories.Add(category); 
        }
    }
}
