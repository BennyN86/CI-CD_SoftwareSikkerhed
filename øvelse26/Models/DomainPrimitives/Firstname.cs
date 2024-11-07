namespace Models.DomainPrimitives
{
    public class Firstname
    {
        private const int MinimumLength = 2;
        private const int MaximumLength = 20;
        private string _firstName;

        public Firstname(string firstName)
        {
            ValidateFirstName(firstName);
            _firstName = firstName;
        }

        private void ValidateFirstName(string firstName)
        {
            if (IsNull(firstName))
            {
                throw new ArgumentNullException("Firstname cannot be null");
            }
            if (IsShorterThanMinimumLength(firstName))
            {
                throw new ArgumentOutOfRangeException($"First name cannot have less than {MinimumLength} characters");
            }
            if (IsLongerThanMaximumLength(firstName))
            {
                throw new ArgumentOutOfRangeException($"First name cannot have more than {MaximumLength} characters");
            }
            if (ContainsNonAlphabeticCharacters(firstName))
            {
                throw new ArgumentException("First name can only contain alphabetic letters");
            }
        }

        private bool IsNull(string firstName) => firstName == null;

        private bool IsShorterThanMinimumLength(string firstName) => firstName.Length < MinimumLength;

        private bool IsLongerThanMaximumLength(string firstName) => firstName.Length > MaximumLength;

        private bool ContainsNonAlphabeticCharacters(string firstName) => firstName.Any(c => !char.IsLetter(c));

        public string GetValue() => _firstName;
    }
}
