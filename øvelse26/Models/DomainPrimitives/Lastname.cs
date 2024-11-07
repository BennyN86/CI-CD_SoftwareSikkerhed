namespace Models.DomainPrimitives
{
    public class Lastname
    {
        private const int MinimumLength = 2;
        private const int MaximumLength = 20;
        private string _lastName;

        public Lastname(string lastName)
        {
            ValidateLastName(lastName);
            _lastName = lastName;
        }

        private void ValidateLastName(string lastName)
        {
            if (IsNull(lastName))
            {
                throw new ArgumentNullException("Lastname cannot be null");
            }
            if (IsShorterThanMinimumLength(lastName))
            {
                throw new ArgumentOutOfRangeException($"Last name cannot have less than {MinimumLength} characters");
            }
            if (IsLongerThanMaximumLength(lastName))
            {
                throw new ArgumentOutOfRangeException($"Last name cannot have more than {MaximumLength} characters");
            }
            if (ContainsNonAlphabeticCharacters(lastName))
            {
                throw new ArgumentException("Last name can only contain alphabetic letters");
            }
        }

        private bool IsNull(string lastName) => lastName == null;

        private bool IsShorterThanMinimumLength(string lastName) => lastName.Length < MinimumLength;

        private bool IsLongerThanMaximumLength(string lastName) => lastName.Length > MaximumLength;

        private bool ContainsNonAlphabeticCharacters(string lastName) => lastName.Any(c => !char.IsLetter(c));

        public string GetValue() => _lastName;
    }
}
