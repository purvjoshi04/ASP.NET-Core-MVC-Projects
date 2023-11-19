using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practical_5.Models;
using System.Collections.Generic;




    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var birds = new List<BirdInfo>
        {
            new BirdInfo { BirdNumber = 1, BirdName = "Bald Eagle", BirdSpecies = "Haliaeetus leucocephalus", BirdDesc = "The bald eagle is a majestic bird of prey with a distinctive white head and tail. It is the national bird and symbol of the United States." },
            new BirdInfo { BirdNumber = 2, BirdName = "American Robin", BirdSpecies = "Turdus migratorius", BirdDesc = "The American robin is a familiar songbird with a red-orange breast and a cheerful, melodious song. It is a common sight in North America." },
            new BirdInfo { BirdNumber = 3, BirdName = "Great Horned Owl", BirdSpecies = "Bubo virginianus", BirdDesc = "The great horned owl is a large and powerful owl known for its tufted 'horns.' It is a skilled nocturnal hunter." },
            new BirdInfo { BirdNumber = 4, BirdName = "Blue Jay", BirdSpecies = "Cyanocitta cristata", BirdDesc = "The blue jay is a striking bird with vibrant blue plumage and distinctive white markings. It is known for its loud calls and intelligence." },
            new BirdInfo { BirdNumber = 5, BirdName = "Peregrine Falcon", BirdSpecies = "Falco peregrinus", BirdDesc = "The peregrine falcon is one of the fastest birds in the world, known for its high-speed aerial hunting. It has distinctive black markings." },
            new BirdInfo { BirdNumber = 6, BirdName = "Ruby-throated Hummingbird", BirdSpecies = "Archilochus colubris", BirdDesc = "The ruby-throated hummingbird is a tiny and colorful bird known for its irBirdNumberescent green feathers and its rapBirdNumber wing beats." },
            new BirdInfo { BirdNumber = 7, BirdName = "American Goldfinch", BirdSpecies = "Spinus tristis", BirdDesc = "The American goldfinch is a small songbird with bright yellow plumage, often seen in gardens and meadows." },
            new BirdInfo { BirdNumber = 8, BirdName = "Northern Cardinal", BirdSpecies = "Cardinalis cardinalis", BirdDesc = "The northern cardinal is a striking red bird known for its vivBirdNumber color and melodious song. It is a common backyard visitor." },
            new BirdInfo { BirdNumber = 9, BirdName = "Mallard Duck", BirdSpecies = "Anas platyrhynchos", BirdDesc = "The mallard duck is a familiar waterfowl BirdSpecies with distinctive irBirdNumberescent green and blue plumage on the male." },
            new BirdInfo { BirdNumber = 10, BirdName = "Eastern Bluebird", BirdSpecies = "Sialia sialis", BirdDesc = "The eastern bluebird is a small, beautifully colored bird with bright blue plumage and is known for its sweet, melodious song." },
        };


            return View(birds);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
