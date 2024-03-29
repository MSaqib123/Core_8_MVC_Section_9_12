﻿using ServiceInterfaces;

namespace ServiceDL
{
    public class CitiesService : ICitiesService
    {
        public List<string> cities { get; set; }
        public CitiesService()
        {
            cities = new List<string>()
            {
                "Karachi",
                "India",
                "srilanka"
            };
        }

        public List<string> getAllList()
        {
            return cities;
        }
    }
}