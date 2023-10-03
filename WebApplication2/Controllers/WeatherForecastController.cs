using Microsoft.AspNetCore.Mvc;
using WebApplication2.Interface;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOfferService offerService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,IOfferService offer)
        {
            _logger = logger;
            offerService = offer;
        }

        [HttpGet(Name = "GetTodaysOffers")]
        public async Task<Offer> Get()
        {
            return await offerService.GetTodaysOffers();
        }
        [HttpGet(Name = "GetAllProducts")]
        public async Task<List<Products>> GetAllProductsAsync()
        {
            var offers = await offerService.GetAllProducts();
            return offers.OrderBy(i => i.Price).Take(3).ToList();
        }
        [HttpGet(Name = "GetAllProducts")]
        public async Task<List<Products>> GetAllProducts()
        {
            var offers = await offerService.GetAllProducts();//.OrderBy(i => i.Price).Take(3).ToList();
            return offers.OrderBy(i => i.Price).Skip(1).Take(1).ToList();
        }
        [HttpPost(Name = "GetAllProducts")]
        public List<Products> AddProducts(Products prod)
        {
            return offerService.AddProducts(prod);
        }
    }
}