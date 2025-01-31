using System.ComponentModel.DataAnnotations;

class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

   public Address(string street, string city, string state, string country)
   {
    _street = street;
    _city = city;
    _state = state;
    _country = country;
   } 

   public bool InUSA()
   {
    return !string.IsNullOrEmpty(_country) && _country.Trim().ToLower() == "usa";
   }

   public string DisplayText()
   {
    return $"{_street}, {_city}, {_state}, {_country}";
   }

    public override string ToString()
    {
        return DisplayText();
    }
}