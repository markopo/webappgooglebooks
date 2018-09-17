using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleBooksDAL.Models; 


namespace WebAppGoogleBooks.Models.Repositories
{
    interface IErrorlogRepository
    {
        void AddLog(Errorlog errorlog); 
        void AddLog(Exception exception); 
    }
}
