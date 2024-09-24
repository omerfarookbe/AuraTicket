using System;
using System.Threading.Tasks;
using AuraTicket.Messages;
using Rebus.Handlers;

namespace AuraTicket.Services.Payment
{
    public class NewOrderHandler : IHandleMessages<PaymentRequestMessage>
    {
        public Task Handle(PaymentRequestMessage message)
        {
            Console.WriteLine($"Payment request received for basket id {message.BasketId}.");
            return Task.CompletedTask;
        }
    }
}
