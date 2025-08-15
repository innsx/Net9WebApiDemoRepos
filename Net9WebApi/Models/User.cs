
﻿namespace Net9WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Jon Doe";
        public string Email { get; set; } = "jd@hotmail.com";
        public string Password { get; set; } = "Test123";
        public string Address {get; set;} = "123 Main Avenue";
        public string City { get; set; } = "St Petersburgs";
        public string State {get; set;} = "Florida";
        public string ZipCode { get; set; } = "98765";
    }

}
