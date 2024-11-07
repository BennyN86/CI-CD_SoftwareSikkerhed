using Models.DomainPrimitives;

namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private Firstname _firstName;
        private Lastname _lastName;

        public Person(Firstname firstName, Lastname lastName)
        {
            _firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            _lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));

            
        }

        public string GetFirstName() => _firstName.GetValue();
        public string GetLastName() => _lastName.GetValue();

        

    }
}
