using System;
using System.ComponentModel.DataAnnotations;

namespace AuraTicket.Services.ShoppingBasket.Models
{
    public class BasketForCreation
    {
        [Required]
        public Guid UserId { get; set; }
    }
}
