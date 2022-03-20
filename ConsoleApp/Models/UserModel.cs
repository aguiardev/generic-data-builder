using System;

namespace ConsoleApp.Models
{
    public class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public UserModel(int id, string name, DateTime birth)
        {
            Id = id;
            Name = name;
            Birth = birth;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
    }
}
