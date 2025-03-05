using Newtonsoft.Json;

namespace SWAPI.Domain
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [JsonProperty("episode_id")]
        public int EpisodeId { get; set; }
        public string Director { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Planets { get; set; }
        public List<string> Starships { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Species { get; set; }



        public List<People> CharactersDetails { get; set; }
        public List<Planet> PlanetsDetails { get; set; }
        public List<Specie> SpeciesDetails { get; set; }
        public List<Starship> StarshipsDetails { get; set; }
        public List<Vehicle> VehiclesDetails { get; set; }
    }

public class Filmlist
    {
        public List<Film> Results { get; set; }
    }
}