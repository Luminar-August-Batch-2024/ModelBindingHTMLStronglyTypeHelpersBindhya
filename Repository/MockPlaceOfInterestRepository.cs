using ModelBindingHTMLStronglyTypeHelpersBindhya.Models;

namespace ModelBindingHTMLStronglyTypeHelpersBindhya.Repository
{
    public class MockPlaceOfInterestRepository
    {
        public List<PlaceOfInterest> GetPlaces()
        {
            List<PlaceOfInterest> placeOfInterests = new List<PlaceOfInterest>()
        {
           new PlaceOfInterest { Place = "Eiffel Tower", City = "Paris" },
        new PlaceOfInterest { Place = "Statue of Liberty", City = "New York" },
        new PlaceOfInterest { Place = "Colosseum", City = "Rome" },
        new PlaceOfInterest { Place = "Great Wall", City = "Beijing" },
        new PlaceOfInterest { Place = "Sydney Opera House", City = "Sydney" },
        new PlaceOfInterest { Place = "Taj Mahal", City = "Agra" },
        new PlaceOfInterest { Place = "Machu Picchu", City = "Peru" },
        new PlaceOfInterest { Place = "Christ the Redeemer", City = "Rio de Janeiro" },
        new PlaceOfInterest { Place = "Big Ben", City = "London" },
        new PlaceOfInterest { Place = "Sagrada Familia", City = "Barcelona" },
        new PlaceOfInterest { Place = "Burj Khalifa", City = "Dubai" },
        new PlaceOfInterest { Place = "Acropolis", City = "Athens" },
        new PlaceOfInterest { Place = "Pyramids of Giza", City = "Giza" },
        new PlaceOfInterest { Place = "Stonehenge", City = "Wiltshire" },
        new PlaceOfInterest { Place = "Louvre Museum", City = "Paris" },
        new PlaceOfInterest { Place = "Petra", City = "Jordan" },
        new PlaceOfInterest { Place = "Angkor Wat", City = "Cambodia" },
        new PlaceOfInterest { Place = "Niagara Falls", City = "Ontario" },
        new PlaceOfInterest { Place = "Golden Gate Bridge", City = "San Francisco" },
        new PlaceOfInterest { Place = "Tokyo Tower", City = "Tokyo" }
        };

            return placeOfInterests;
        }
    }
}
