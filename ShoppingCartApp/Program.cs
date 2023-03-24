using ShoppingCartApp;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Cart cart = new Cart();

        // Add some items to the cart
        cart.AddItem(new Item("Book", 10.99));
        cart.AddItem(new Item("T-Shirt", 19.99));
        cart.AddItem(new Item("Headphones", 29.99));

        // Display the cart
        cart.DisplayCart();

        // Remove an item from the cart
        cart.RemoveItem("T-Shirt");

        // Display the updated cart
        cart.DisplayCart();

        // Clear the cart
        cart.ClearCart();
    }
}

