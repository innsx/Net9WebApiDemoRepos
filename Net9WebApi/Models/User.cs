
﻿namespace Net9WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = "jd@hotmail.com";
        public string Password { get; set; } = string.Empty;
        public string Address {get; set;} = "999 Ocean Drive, One Plaza";
        public string City {get; set;} = string.Empty;
        public string State {get; set;} = "Florida";
        public string ZipCode {get; set;} = string.Empty;
    }

}
