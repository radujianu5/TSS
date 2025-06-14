using PasswordManager;
using Xunit;

namespace PasswordManager.Tests
{
    public class PasswordValidatorTests
    {
        private readonly PasswordValidator _validator = new PasswordValidator();

        [Theory]
        [InlineData(null, "Parola nu poate fi goala.")]
        [InlineData("", "Parola nu poate fi goala.")]
        [InlineData("abc", "Parola este prea scurta.")]
        [InlineData("abcdefgh", "Parola trebuie sa contina cel putin o litera mare.")]
        [InlineData("Abcdefgh", "Parola trebuie sa contina cel putin o cifra.")]
        [InlineData("Abcd123456", "Parola trebuie sa contina cel putin un caracter special (!@#$%^&*).")]
        [InlineData("Abcdefg1!", "Parola este valida.")]
        public void ValidatePassword_ShouldReturnCorrectMessage(string? password, string expectedMessage)
        {
            var result = _validator.ValidatePassword(password);
            Assert.Equal(expectedMessage, result);
        }



        [Fact]
        public void PasswordWithoutUppercase_ShouldReturnError()
        {
            var result = _validator.ValidatePassword("password123!");
            Assert.Equal("Parola trebuie sa contina cel putin o litera mare.", result);
        }

        [Fact]
        public void PasswordWithoutDigit_ShouldReturnError()
        {
            var result = _validator.ValidatePassword("Password!");
            Assert.Equal("Parola trebuie sa contina cel putin o cifra.", result);
        }


    }
}
