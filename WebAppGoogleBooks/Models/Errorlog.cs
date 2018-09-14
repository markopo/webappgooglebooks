using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppGoogleBooks.Models
{
    public class Errorlog
    {
        public virtual long Id { get; set; }
        public virtual string Message { get; set; }
        public virtual string Stacktrace { get; set; }
        public virtual DateTime Created { get; set; }

        public static Errorlog Create(Exception exception)
        {
            return new Errorlog
            {
                Message = exception.Message,
                Stacktrace = exception.StackTrace,
                Created = DateTime.Now
            }; 
        }
    }
}
