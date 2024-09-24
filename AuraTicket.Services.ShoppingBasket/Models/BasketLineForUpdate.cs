using System.ComponentModel.DataAnnotations;

namespace AuraTicket.Services.ShoppingBasket.Models
{
    public class BasketLineForUpdate
    {
        [Required]
        public int TicketAmount { get; set; }
    }
}
