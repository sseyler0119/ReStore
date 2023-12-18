namespace API.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } = new(); // new List<BasketItem>(); equivalent statement

        public void AddItem(Product product, int quantity)
        {
            if(Items.All(item => item.ProductId != product.Id)) // item is not already in cart
            {
                Items.Add(new BasketItem{Product = product, Quantity = quantity});
            }

            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id); // item already in cart

            if(existingItem != null) existingItem.Quantity += quantity; // add to existing items in cart
        }

        public void RemoveItem(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);
            if(item == null) return;

            item.Quantity -= quantity;
            if(item.Quantity == 0) Items.Remove(item);
        }
    }
}