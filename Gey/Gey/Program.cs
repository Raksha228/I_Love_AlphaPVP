using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace Gey
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TaskerDbContext())
            {
                DatabaseInitializer.Initialize(context);

                var users = context.Users.Include(u => u.Tasks).ToList();

                foreach (var user in users)
                {
                    Console.WriteLine($"User: {user.Name}");
                    foreach (var task in user.Tasks)
                    {
                        Console.WriteLine($" - {task.Description}: {task.Status}");
                    }
                }
            }
        }
    }
}