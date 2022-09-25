using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    using Data.Model;
    using Business;
    public class Display
    
    {
        private int closeOperationId = 6;
        private DestinationBusiness destinationBusiness = new DestinationBusiness();
        public Display()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 55));
            Console.WriteLine(new string(' ', 12) + "Management of travel agency" + new string(' ', 12));
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("1. Show all destinations");
            Console.WriteLine("2. Add new destination");
            Console.WriteLine("3. Update destination");
            Console.WriteLine("4. Get destination by ID");
            Console.WriteLine("5. Delete destination by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Get();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            destinationBusiness.Delete(id);
            Console.WriteLine("Destination deleted");
        }

        private void Get()
        {
            Console.WriteLine("Enter ID to get: ");
            int id = int.Parse(Console.ReadLine());
            Destination destination = destinationBusiness.Get(id);
            if (destination != null)
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("ID: " + destination.Id);
                Console.WriteLine("Country: " + destination.country);
                Console.WriteLine("Town: " + destination.townName);
                Console.WriteLine("Hotel: " + destination.hotelName);
                Console.WriteLine("Price per night: " + destination.price);
                Console.WriteLine("Amenity: " + destination.amenities);
                Console.WriteLine("Price per amenity: " + destination.priceOfAmenities);
                Console.WriteLine(new string('-', 30));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Destination destination = destinationBusiness.Get(id);
            if (destination != null)
            {
                Console.Write("Update country: ");
                destination.country = Console.ReadLine();
                Console.Write("Update town : ");
                destination.townName = Console.ReadLine();
                Console.Write("Updatee hotel: ");
                destination.hotelName = Console.ReadLine();
                Console.Write("Update price per night: ");
                destination.price = decimal.Parse(Console.ReadLine());
                Console.Write("Update stars of the hotel:");
                destination.stars = int.Parse(Console.ReadLine());
                Console.Write("Update amenity of the hotel:");
                destination.amenities = Console.ReadLine();
                Console.Write("Update price of amenity:");
                destination.priceOfAmenities = decimal.Parse(Console.ReadLine());
                destinationBusiness.Update(destination);
            }
            else
            {
                Console.WriteLine("Destination not found!");
            }
        }

        private void Add()
        {
            Destination destination = new Destination();
           
            Console.Write("Enter country name: ");
            destination.country = Console.ReadLine();
            Console.Write("Enter town name: ");
            destination.townName = Console.ReadLine();
            Console.Write("Enter hotel: ");
            destination.hotelName = Console.ReadLine();
            Console.Write("Enter price per night: ");
            destination.price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter stars of the hotel:");
            destination.stars = int.Parse(Console.ReadLine());
            Console.Write("Enter amenity of the hotel:");
            destination.amenities = Console.ReadLine();
            Console.Write("Enter price of amenity:");
            destination.priceOfAmenities = decimal.Parse(Console.ReadLine());

            destinationBusiness.Add(destination);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "DESTINATIONS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var destinations = destinationBusiness.GetAll();
            
            foreach (var item in destinations)
            {
                Console.WriteLine("ID:{0} \nCountry:{1} \nTown:{2} \nName of the hotel: {3}  " +
                    "\nPrice per night:{4}  \nStars of the hotel{5} \nAmenity:{6}  \nPrice of amenity:{6}",
                    item.Id, item.country, item.townName, item.hotelName, item.price,item.stars,item.amenities,item.priceOfAmenities);
            }
        }
    }
}
