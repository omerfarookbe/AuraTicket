using System;

namespace AuraTicket.Messages
{
    public class PaymentRequestMessage
    {
        public Guid BasketId { get; set; }
    }
}
