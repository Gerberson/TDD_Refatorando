using System;
using Domain.Commands.Interfaces;
using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Commands
{
    public class CreateOrderItemCommand : Notifiable, ICommand
    {
        public Guid Product { get; set; }
        public int Quantity { get; set; }

        public CreateOrderItemCommand() { }
        public CreateOrderItemCommand(Guid product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }        

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasLen(Product.ToString(), 32, "Product", "Produto inválido")
                .IsGreaterThan(Quantity, 0, "Quantity", "Quantidade inválida")
            );
        }
    }
}