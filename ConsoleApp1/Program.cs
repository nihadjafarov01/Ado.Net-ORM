using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Blog blog = new Blog()
            {
                Title = "testtitle",
                Description = "testdes",
                UserId = 1
            };
            //BlogService.Create(blog);
            //foreach (Blog item in BlogService.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} {item.Title} {item.Description} {item.UserId}");
            //}
            User user = new User()
            {
                Name = "Test",
                Surname = "Test",
                Password = "Test123",
            };
            UserService.Register(user);
        }
    }
}
