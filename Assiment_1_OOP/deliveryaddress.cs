using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment_1_OOP
{
    #region Part_1 
    //public struct DeliveryAddress
    //{
    //    public string city;
    //    public string street;
    //}

    //public class Customer
    //{
    //    public string Name;
    //}
    #endregion

    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNubmer;

        public DeliveryAddress(string city, string street, int buildingNubmer)
        {
            City = city;
            Street = street;
            BuildingNubmer = buildingNubmer;
        }

        public string GetFullAddress()
        {
            return $"{City},{Street},Building {BuildingNubmer}";
        }

    }



}
