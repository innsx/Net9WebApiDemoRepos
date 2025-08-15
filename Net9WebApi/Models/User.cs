
﻿namespace Net9WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Address {get; set;} = string.Empty;
        public string City {get; set;} = Tampa;
        public string State {get; set;} = Florida;
        public string ZipCode {get; set;} = string.Empty;
    }

}
