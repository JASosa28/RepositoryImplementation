using System;
using RepositoryEntityFramework.DataAccess;
using RepositoryEntityFramework.DataAccess.Model;
using RepositoryEntityFramework.DataAccess.Repository;

namespace RepositoryEntityFramework.UI
{
    class Program
    {
        public static void Guardar()
        {
            User user = new User();
            user.Codigo = "2";
            user.Nombre = "joel";

            string connString = @"Data Source=DOMINGO\SQLEXPRESS;Initial Catalog=PRUEBA;Integrated Security=True";
            using (var dataContext = new MyContext(connString))
            {
                var userRepository = new Repository<User>(dataContext);

                //userRepository.Create(user);

                userRepository.Update(user);


            }
        }
        static void Main(string[] args)
        {
            string connString = @"Data Source=DOMINGO\SQLEXPRESS;Initial Catalog=PRUEBA;Integrated Security=True";
            using (var dataContext = new MyContext(connString))
            {
                var userRepository = new Repository<User>(dataContext);

                User user = userRepository
                    .Find(c => c.Nombre.StartsWith("Rob"));


                


                //userRepository.Create(user);
                //userRepository.Update(user);

                Console.WriteLine("Nombre del usuario: {0} *", user.Nombre);
                Guardar();
                Console.ReadKey();
            }
        }
    }
}
