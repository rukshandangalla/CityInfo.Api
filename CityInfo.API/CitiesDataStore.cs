﻿using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //iniit dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Colombo",
                    Description = "Main economic city of the Sri Lanka",
                    PointsOfInterest = new List<PointOfInterestsDto>()
                    {
                        new PointOfInterestsDto()
                        {
                            Id = 1,
                            Name = "SubWay",
                            Description = "Eat Fresh"
                        },
                        new PointOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Manhatton Fish Market",
                            Description = "Expensive but delisous"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Nugegoda",
                    Description = "Where my 1st annex located",
                    PointsOfInterest = new List<PointOfInterestsDto>()
                    {
                        new PointOfInterestsDto()
                        {
                            Id = 1,
                            Name = "Mac Donalds",
                            Description = "Fast food in a style"
                        },
                        new PointOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Pizza Hut",
                            Description = "Pizza Hut next bus halt"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Maharagama",
                    Description = "Where I currently live",
                    PointsOfInterest = new List<PointOfInterestsDto>()
                    {
                        new PointOfInterestsDto()
                        {
                            Id = 1,
                            Name = "Red Lantern",
                            Description = "All types of chinese foods"
                        },
                        new PointOfInterestsDto()
                        {
                            Id = 2,
                            Name = "Blue Sky",
                            Description = "Tasty chineese foods"
                        }
                    }
                },
            };
        }
    }
}
