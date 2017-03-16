using NUnit.Framework;
using System;


/*
Create a Password verifications class called “PasswordVerifier”.
Add the following verifications to a master function called “Verify()”

- password should be larger than 8 chars

- password should not be null

- password should have one uppercase letter at least

- password should have one lowercase letter at least

- password should have one number at least

    Each one of these should throw an exception with a different message of your choosing

    2. Add feature: Password is OK if at least three of the previous conditions is true

    3. Add feature: password is never OK if item 1.4 is not true.

8. Assume Each verification takes 1 second to complete. How would you solve  items 2 and 3  so tests can run faster?
 */

namespace TDD_Katas_project.PasswordVerifier
{
    [TestFixture]
    [Category("PasswordVerifier")]
    public class TestPasswordVerifier
    {
        [Test]
        public void passwordShouldBeLargerThan8Chars()
        {
            var password = new PasswordVerifier();
            password.InputPassword("12345678");

            var message = "password should be larger than 8 chars";

            Assert.Throws(
                Is.TypeOf<PasswordVerifierException>()
                .With.Property("Message")
                .EqualTo(message),
                () => password.Verify()
                );
        }

        [Test]
        public void passwordShouldNotBeNull()
        {
            var password = new PasswordVerifier();
            password.InputPassword(null);
            var message = "password should not be null";

            Assert.Throws(
                Is.TypeOf<PasswordVerifierException>()
                .With.Property("Message")
                .EqualTo(message),
                ()=>password.Verify()
                );
        }

        [Test]
        public void passwordShouldHaveOneUppercaseLetterAtLeast()
        {
            var password = new PasswordVerifier();
            password.InputPassword("123456789");
            var message = "password should have one uppercase letter at least";

            Assert.Throws(
                Is.TypeOf<PasswordVerifierException>()
                .With.Property("Message")
                .EqualTo(message),
                () => password.Verify()
                );
        }

        [Test]
        public void passwordShouldHaveOneLowercaseLetterAtLeast()
        {
            var password = new PasswordVerifier();
            password.InputPassword("12345678A");
            var message = "password should have one lowercase letter at least";

            Assert.Throws(
                Is.TypeOf<PasswordVerifierException>()
                .With.Property("Message")
                .EqualTo(message),
                () => password.Verify()
                );
        }
        [Test]
        public void passwordShouldHaveOneNumberAtLeast()
        {
            var password = new PasswordVerifier();
            password.InputPassword("Helloworld");
            var message = "password should have one number at least";

            Assert.Throws(
                Is.TypeOf<PasswordVerifierException>()
                .With.Property("Message")
                .EqualTo(message),
                () => password.Verify()
                );
        }
        [Test]
        public void passwordSatisfied()
        {
            var password = new PasswordVerifier();
            password.InputPassword("Helloworld2");

            Assert.DoesNotThrow(
                () => password.Verify()
                );
        }

    }
}
