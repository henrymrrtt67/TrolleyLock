using TrolleyLockAPI.Cryptography;

namespace TrolleyLockAPITests.CryptographyTests
{
    public class EncryptionTest
    {
        Cryptography cryptography = new Cryptography();

        [Fact]
        public void Given_StringIsPassedThrough_When_StringHasAlreadyBeenEncrypted_Then_EncryptionStringsAreTheSame() 
        {
            var password = "Password_1234!";
            var firstRunthrough = cryptography.Encrypt(password);
            var secondRunThrough = cryptography.Encrypt(password);

            Assert.Equal(firstRunthrough, secondRunThrough);
        }

        [Fact]
        public void Given_StringIsPassedThrough_Then_EncryptedStringWillBeDifferentFromStringPassedThrough()
        {
            var password = "Password_1234!";
            var encryptedString = cryptography.Encrypt(password);

            Assert.NotEqual(password, encryptedString);
        }

        [Fact]
        public void Given_StringIsPassedThrough_When_StringHasNotBeenEncrypted_Then_EncryptionStringsAreNotTheSame()
        {
            var firstRunthrough = cryptography.Encrypt("FirstPassword");
            var secondRunThrough = cryptography.Encrypt("SecondPassword");

            Assert.NotEqual(firstRunthrough, secondRunThrough);
        }
    }
}
