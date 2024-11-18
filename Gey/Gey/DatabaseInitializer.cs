using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gey
{
    public static class DatabaseInitializer
    {
        public static void Initialize(TaskerDbContext context)
        {
            context.Database.EnsureCreated();





            if (context.Users.Any()) return;




            var users = new[]
            {
            new User { Name = "Эшкере" },
            new User { Name = "Абаб" },
            new User { Name = "Голум" }
            };






            context.Users.AddRange(users);
            context.SaveChanges();





            var tasks = new[]
            {
            new Task { Description = "Запись 1", IsCompleted = false, UserId = 1 },
            new Task { Description = "Запись 2", IsCompleted = false, UserId = 1 },
            new Task { Description = "Запись 3", IsCompleted = false, UserId = 2 },
            new Task { Description = "Запись 4", IsCompleted = true, UserId = 3 }
            };





            context.Tasks.AddRange(tasks);



            context.SaveChanges();
        }
    }
}
