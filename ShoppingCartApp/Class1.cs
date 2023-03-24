using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class Cart
    {
        private List<Item> items;

        public Cart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Added " + item.Name + " to cart.");
        }

        public void RemoveItem(string itemName)
        {
            Item itemToRemove = items.Find(item => item.Name == itemName);
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine("Removed " + itemName + " from cart.");
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }

        public void DisplayCart()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in cart:");
                foreach (Item item in items)
                {
                    Console.WriteLine("- " + item.Name + " ($" + item.Price + ")");
                }
                Console.WriteLine("Total: $" + GetTotal());
            }
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Price;
            }
            return total;
        }

        public void ClearCart()
        {
            items.Clear();
            Console.WriteLine("Cart cleared.");
        }
    }
}
