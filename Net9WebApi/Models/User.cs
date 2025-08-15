
namespace Net9WebApi.Models
{
    public class User
    {
      public string Name {get; set; };
      public string Address {get; set;} = string.Empty;
      public string City {get; set;} = string.Empty;
      public string State {get; set;} = string.Empty;
      public string ZipCode {get; set;} = string.Empty;
    }
}
