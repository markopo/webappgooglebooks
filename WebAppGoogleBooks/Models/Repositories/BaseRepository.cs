using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;
using Microsoft.AspNetCore.Hosting;


namespace WebAppGoogleBooks.Models.Repositories
{
    public class BaseRepository
    {
        private readonly IHostingEnvironment _environment;
       

        public BaseRepository(IHostingEnvironment environment)
        {
            _environment = environment;

        }

        public ISession OpenSession()
        {
            return NHibernateSession.OpenSession(_environment);
        }


        public void AddOrUpdate(object obj)
        {
            using (ISession session = OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(obj);
                        session.Flush();
                        transaction.Commit();
                    }
                    catch (Exception exception)
                    {
                        AddOrUpdate(Errorlog.Create(exception)); 
                        transaction.Rollback();
                    }
                }
            }
        }


        public void Delete(object obj)
        {
            using (ISession session = OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(obj);
                        session.Flush(); 
                        transaction.Commit();
                    }
                    catch (Exception exception)
                    {
                        AddOrUpdate(Errorlog.Create(exception));
                        transaction.Rollback();
                    }
                }
            }

        }

    }

}
