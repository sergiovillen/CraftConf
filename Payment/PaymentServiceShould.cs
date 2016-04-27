using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using FakeItEasy.ExtensionSyntax.Full;
using NUnit.Framework;

namespace Payment
{
    public class PaymentServiceShould
    {
        private readonly User notValidUser = null;
        private readonly PaymentDetails paymentDetails = null;

        [Test]
        public void throw_an_exception_if_the_user_is_not_valid()
        {
            var userService = A.Fake<IUserService>();
            
            var paymentService = new PaymentService(userService);
            Assert.Throws<Exception>(() =>
            {                
                paymentService.ProcessPayment(notValidUser, paymentDetails);
            });
            A.CallTo(() => userService.Validate(notValidUser)).MustHaveHappened(Repeated.Never);

        }

        [Test]
        public void not_invoke_process_payment_when_user_is_not_valid()
        {
            var userService = A.Fake<IUserService>();
            var paymentGateway = A.Fake<IPaymentGateway>();
            var paymentService = new PaymentService(userService);
            Assert.Throws<Exception>(() =>
            {
                paymentService.ProcessPayment(notValidUser, paymentDetails);
            });
            A.CallTo(() => paymentGateway.Pay(paymentDetails)).MustNotHaveHappened();
        }

    }
}
