using TrolleyLockAPI.Cryptography;

namespace TrolleyLockAPITests.CryptographyTests
{
    public class DecryptionTest
    {
        Cryptography cryptography = new Cryptography();


        [Fact]
        public void Given_EncryptedStringHasBeenPassed_Then_EncryptStringIsDifferentFromDecryptedString()
        {
            var encryptedString = cryptography.Encrypt("password1243~@$#");
            var decryptedString = cryptography.Decrypt(encryptedString);

            Assert.NotEqual(encryptedString, decryptedString);
        }

        [Fact]
        public void Given_EncryptedStringIsPassed_When_EncryptedStringHasAlreadyBeenPassed_Then_BothPassedStringsAreTheSame()
        {
            var encryptedString = cryptography.Encrypt("password*$&!@#$$@");
            var firstDecryptedString = cryptography.Decrypt(encryptedString);
            var secondDecryptedString = cryptography.Decrypt(encryptedString);

            Assert.Equal(firstDecryptedString, secondDecryptedString);
        }


        [Fact]
        public void Given_EncryptedStringIsPassed_When_ASeperateEncryptedStringHasBeenPassed_Then_BothPassedStringsAreNotTheSame()
        {
            var firstEncryptedString = cryptography.Encrypt("password*$&!@#$$@");
            var secondEncryptedString = cryptography.Encrypt("oldManJenkins78234^!#@&@*$^$&@");

            var firstDecryptedString = cryptography.Decrypt(firstEncryptedString);
            var secondDecryptedString = cryptography.Decrypt(secondEncryptedString);

            Assert.NotEqual(firstDecryptedString, secondDecryptedString);

        }
    }
}
