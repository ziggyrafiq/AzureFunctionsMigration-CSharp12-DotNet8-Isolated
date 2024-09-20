namespace AzureFunctionsApp.Shared.Models
{
    //Old Way
    //public class Person
    //{
    //    public string FirstName { get; }
    //    public string LastName { get; }
    //    public string EmailAddress { get; }
    //    public string TelphoneNumber { get; }


    //    public Person(string firstName, string lastName, string eamilAddress, string telephoneNumber)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        EmailAddress = eamilAddress;
    //        TelphoneNumber = telephoneNumber;
    //    }

    //}

    public readonly record struct Person(string FirstName, string LastName, string EmailAddress, string TelephoneNumber);
}
