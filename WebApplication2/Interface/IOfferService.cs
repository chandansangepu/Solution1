using WebApplication2.Models;

namespace WebApplication2.Interface
{
    public interface IOfferService
    {
        Task<List<Products>> GetAllProducts();
        Task<Offer> GetTodaysOffers();
        List<Products> AddProducts(Products prod);

    }
}
