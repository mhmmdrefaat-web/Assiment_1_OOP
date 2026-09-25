namespace Assiment_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part_1
            ////Q1
            ////a
            ////struct --> value type
            ////When we copy a DeliveryAddress the copy changes, but the original does not

            //DeliveryAddress address1 = new DeliveryAddress();
            //address1.city = "Cairo";

            //DeliveryAddress address2 = address1;
            //address2.city = "Giza";

            //Console.WriteLine(address1.city);  //Cairo
            //Console.WriteLine(address2.city);  //Giza

            ////b
            ////class --> Refrence type
            ////When we copy a Customer both variables refer to the same object, so changing one changes the object for both

            //Customer customer1 = new Customer();
            //customer1.Name = "Ahmed";

            //Customer customer2 = customer1;
            //customer2.Name = "Ali";

            //Console.WriteLine(customer1.Name); //Ali 
            //Console.WriteLine(customer2.Name); //Ali 


            ////Q2
            ////a
            ////1.The fields are public, so anyone can change them directly.
            ////2.There is no validation for values like negative weight or delivery fee.
            ////3.The struct has no control over how its data is modified.

            ////b
            ////Private fields hide the data, while public properties control access and allow validation.
            #endregion

            
            
                DeliveryCenter center = new DeliveryCenter();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter data for Shipment {i + 1}");

                    Console.Write("Tracking Code: ");
                    string trackingCode = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Delivery Fee: ");
                    decimal deliveryFee = decimal.Parse(Console.ReadLine());

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("Street: ");
                    string street = Console.ReadLine();

                    Console.Write("Building Number: ");
                    int buildingNumber = int.Parse(Console.ReadLine());

                    DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);

                Shipment shipment = new Shipment(
                                    trackingCode,
                                    description,
                                    weight,
                                    deliveryFee,
                                    address)
                { 

                };
                center.Addshipment(shipment);

                    Console.WriteLine();
                }

                Console.WriteLine("Three Shipments:");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(center[i]);
                    Console.WriteLine();
                }

                Console.Write("Enter tracking code to search: ");
                string searchCode = Console.ReadLine();

                Shipment result = center[searchCode];

                if (result.TrackingCode != null)
                {
                    Console.WriteLine("Shipment found:");
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Shipment not found.");
                }

                Console.WriteLine();

                DeliveryAddress address1 = new DeliveryAddress("Cairo", "El Nasr Street", 25);

                DeliveryAddress address2 = address1;

                address2.City = "Giza";

                Console.WriteLine("DeliveryAddress Copy Behavior:");

                Console.WriteLine("Address 1: " + address1.GetFullAddress());
                Console.WriteLine("Address 2: " + address2.GetFullAddress());
            


        }
    }
}
