
﻿namespace Net9WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


namespace Net9WebApi.Models
{
    public class User
    {

      public string Address {get; set;} = string.Empty;
      public string City {get; set;} = string.Empty;
      public string State {get; set;} = string.Empty;
      public string ZipCode {get; set;} = string.Empty;

    }
}
