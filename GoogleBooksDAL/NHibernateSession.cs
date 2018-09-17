using NHibernate;
using NHibernate.Cfg;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace GoogleBooksDAL
{
    public class NHibernateSession
    {
        public static ISession OpenSession(IHostingEnvironment environment)
        {
            var configuration = new Configuration();

            var assembly = typeof(GoogleBooksDAL.NHibernateSession).Assembly;
            configuration.Configure(assembly, "GoogleBooksDAL.hibernate.cfg.xml");

            configuration.AddAssembly("GoogleBooksDAL"); 

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }

    }
}
