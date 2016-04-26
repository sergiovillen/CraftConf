using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var paymentService = new PaymentService();
            Assert.Throws<Exception>(() =>
            {
                
                paymentService.ProcessPayment(notValidUser, paymentDetails);
            });
        }
    }
}
