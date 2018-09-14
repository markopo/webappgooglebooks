using NHibernate;
using NHibernate.Cfg;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace WebAppGoogleBooks
{
    public class NHibernateSession
    {
        public static ISession OpenSession(IHostingEnvironment environment)
        {
            var configuration = new Configuration();

            var configurationPath = Path.Combine(environment.WebRootPath, "nh", "hibernate.cfg.xml");
            configuration.Configure(configurationPath);

            // BOOK
            var bookConfigurationFile = Path.Combine(environment.WebRootPath, "nh", "Book.hbm.xml");
            configuration.AddFile(bookConfigurationFile);

            // AUTHOR
            var authorsConfFile = Path.Combine(environment.WebRootPath, "nh", "Author.hbm.xml");
            configuration.AddFile(authorsConfFile);

            // CATEGORY 
            var categoryConfFile = Path.Combine(environment.WebRootPath, "nh", "Category.hbm.xml");
            configuration.AddFile(categoryConfFile);

            // ERRORLOG 
            var errorLogConfFile = Path.Combine(environment.WebRootPath, "nh", "Errorlog.hbm.xml");
            configuration.AddFile(errorLogConfFile); 


            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }

    }
}
