using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UnitTestApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public interface IRepository
    {
        IEnumerable<User> getAll();
        User Get(int id);
        void Create(User user);
        string? GetAll();
    }
}