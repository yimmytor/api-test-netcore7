using Entities;

namespace DataAccess
{
    public static class ProductDA
    {
        private static readonly List<Product> _productsList = new()
        {
            new Product()
            {
                Id = 1,
                Name = "Blaztor Bluetooth Headset SRM456",
                Sku = "BL-SRM456-BLUTC",
                Category = CategoryDA.GetById(1),
                Description = "Bluetooth headset, color blue, weight 200 grams, usb type C",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/1/1.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/1/1.jpg"}
                },
                Tags = new List<string>
                {
                    "headset","audio","bluetooth"
                }
            },
            new Product()
            {
                Id = 2,
                Name = "Samsung A20s Smartphone",
                Sku = "SM-A20S-BLK32",
                Category = CategoryDA.GetById(1),
                Description = "Smartphone, color blue, usb type C, 32GB storage",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/1/2.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/1/2.jpg"}
                },
                Tags = new List<string>
                {
                    "smartphone","movil","mobile"
                }
            },
            new Product()
            {
                Id = 3,
                Name = "Spartan 10lbs dumbells",
                Sku = "SP-DB0001-PLAGRE10LBS",
                Category = CategoryDA.GetById(2),
                Description = "Plastic dumbells, 10 lbs, color green",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/2/1.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/2/1.jpg"}
                },
                Tags = new List<string>
                {
                    "fitness","wellness","excercise","excercises","health","workout","gym"
                }
            },
            new Product()
            {
                Id = 4,
                Name = "FitnessWear Tracker XYZ",
                Sku = "FW-XYZ-FT2022-BLK",
                Category = CategoryDA.GetById(2),
                Description = "Fitness tracker, color black, heart rate monitor, step counter, sleep tracker",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/2/2.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/2/2.jpg"}
                },
                Tags = new List<string>
                {
                    "fitness","wellness","excercise","excercises","health","workout","gym","fitness wear","gear"
                }
            },
            new Product()
            {
                Id = 5,
                Name = "Executive Leather Desk Chair",
                Sku = "OS-ECLDC-001-BLK",
                Category = CategoryDA.GetById(3),
                Description = "Executive leather desk chair, ergonomic design, lumbar support and adjustable features",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/3/1.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/3/1.jpg"}
                },
                Tags = new List<string>
                {
                    "office","chair","leather","desk","furniture"
                }
            },
            new Product()
            {
                Id = 6,
                Name = "Assorted Sticky Note Set",
                Sku = "OS-ASN-003-AST",
                Category = CategoryDA.GetById(3),
                Description = "Variety of vibrant-colored sticky notes in different shapes and sizes",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/3/2.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/3/2.jpg"}
                },
                Tags = new List<string>
                {
                    "office","supplies","supply"
                }
            },
            new Product()
            {
                Id = 7,
                Name = "Outdoor Solar-Powered LED Pathway Lights",
                Sku = "HG-OSPL-006-SS",
                Category = CategoryDA.GetById(4),
                Description = "Set of six eco-friendly lights harness solar energy during the day and automatically light up at dusk",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/4/1.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/4/1.jpg"}
                },
                Tags = new List<string>
                {
                    "light","garden","illumination","home","led","outdoor"
                }
            },
            new Product()
            {
                Id = 8,
                Name = "Indoor Plant Pot with Self-Watering System",
                Sku = "HG-IPP-SWS-002-WHT",
                Category = CategoryDA.GetById(4),
                Description = "Made from durable ceramic, designed to keep your plants hydrated without constant monitoring",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/4/2.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/4/2.jpg"}
                },
                Tags = new List<string>
                {
                    "plant","plants","garden","gardening","nature"
                }
            },
            new Product()
            {
                Id = 9,
                Name = "Orthopedic Memory Foam Dog Bed",
                Sku = "PS-OMFDB-001-MED",
                Category = CategoryDA.GetById(5),
                Description = "This bed features a high-density memory foam mattress that provides joint support and relieves pressure points, making it perfect for older dogs or those with arthritis",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/5/1.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/5/1.jpg"}
                },
                Tags = new List<string>
                {
                    "bed","pets","pet","dog","orthopedic","vet","veterinary"
                }
            },
            new Product()
            {
                Id = 10,
                Name = "Interactive Cat Toy with Feather Wand",
                Sku = "PS-ICT-FW-003",
                Category = CategoryDA.GetById(5),
                Description = "The toy features a feather wand suspended from an adjustable string, encouraging your cat to pounce, bat, and play",
                Images = new List<ProductImage>
                {
                    new ProductImage() { Id = 1, Type = 1, Url = "https://mysite.com/images/5/2.jpg"},
                    new ProductImage() { Id = 2, Type = 2, Url = "https://mysite.com/images/thumbs/5/2.jpg"}
                },
                Tags = new List<string>
                {
                    "toy","toys","pets","pet","cat","vet","veterinary"
                }
            }
        };

        public static List<Product> GetAll()
        {
            return _productsList;
        }

        public static List<Product> SearchByText(string? searchtext)
        {
            return (_productsList
                   .Where(product => product.Name.ToLower().Contains(searchtext.ToLower()) ||
                                     product.Description.ToLower().Contains(searchtext.ToLower()) ||
                                     product.Category.Name.ToLower().Contains(searchtext.ToLower()) ||
                                     product.Tags.Any(tag => tag.ToLower().Contains(searchtext.ToLower())))
                   .Select(product => product)).ToList();
        }

        public static List<Product> SearchByCategory(int? categoryId)
        {
            return (_productsList
                   .Where(product => product.Category.Id == categoryId)
                   .Select(product => product)).ToList();
        }

        public static Product? GetById(int? productId)
        {
            return _productsList
                   .Where(product => product.Id == productId)
                   .Select(product => product).ToList().FirstOrDefault();
        }
    }
}
