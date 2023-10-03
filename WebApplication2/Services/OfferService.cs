using WebApplication2.Interface;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class OfferService : IOfferService
    {
        OfferService() {
            AddInventory();
        }  
        private List<Products> Inventory { get; set; }

        private void AddInventory()
        {
            Products an = new Products();
            an.ProductName = "P1";
            an.Price = 1;
            an.Description = "Dec P1";
            Inventory.Add(an);
        }

        public async Task<List<Products>> GetAllProducts()
        { 
            return  Inventory;
        }
        public async Task<Offer> GetTodaysOffers()
        {
            Offer ab = new Offer();
            ab.OfferName = "ComboPackage1";
            ab.Products = Inventory;
            return ab;
        }
        public List<Products> AddProducts(Products prod) {
            Inventory.Add(prod);
            return Inventory;
        }

    }
}
