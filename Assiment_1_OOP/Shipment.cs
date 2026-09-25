using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment_1_OOP
{
    #region Part_1   
    //public class Shipment
    //{
    //        public string Description;
    //        public double Weight;
    //        public decimal DeliveryFee;

    //}
    //better to do 
    #endregion

    public struct Shipment
    {
        private string trackingcode;
        private string description;
        private double weight;
        private decimal deliveryfee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingcode; }

           private set 
            
           { 
                  if (!string.IsNullOrWhiteSpace(value))
                  { 
                    trackingcode = value; 
                  }
                    
            }

        }

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryfee; }

            private set
            {
                if (deliveryfee > 0)
                    deliveryfee = value;
            }
        }

        public decimal EstimatedCost
        {
            get
            {
               return  DeliveryFee + ((decimal)Weight * 5);
            }
        }

        public Shipment(string trackingcode)
        {
            TrackingCode = trackingcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(
                         string trackingCode,
                         string description,
                         double weight,
                         decimal deliveryFee,
                         DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee >  0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }
}