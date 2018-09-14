using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebAppGoogleBooks.Models.Repositories
{
    public class ErrorlogRepository : BaseRepository, IErrorlogRepository
    {

        public ErrorlogRepository(IHostingEnvironment environment) : base(environment)
        {


        }

        public void AddLog(Errorlog errorlog)
        {
            base.AddOrUpdate(errorlog); 
        }

        public void AddLog(Exception exception)
        {
            base.AddOrUpdate(new Errorlog
            {
                Message = exception.Message,
                Stacktrace = exception.StackTrace,
                Created = DateTime.Now
            }); 
        }
    }
}
