using System;

namespace Payment
{
    public class PaymentService 
    {
        private IUserService _userService;

        public PaymentService(IUserService _userService)
        {
            this._userService = _userService;
        }

        public void ProcessPayment(User user, PaymentDetails paymentDetails)
        {
            if(!_userService.Validate(user))
                throw new Exception();
            throw new NotImplementedException();
        }
    }
}