using Newtonsoft.Json;
using SWAPI.Domain;

namespace SWAPI.Services
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient;

        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<People>> GetPeopleAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/people/");
            var people = JsonConvert.DeserializeObject<Peoplelist>(response);
            return people.Results;
        }
        public async Task<IEnumerable<Film>> GetFilmsAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/films/");
            var films = JsonConvert.DeserializeObject<Filmlist>(response);
            return films.Results;
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/vehicles/");
            var vehicles = JsonConvert.DeserializeObject<Vehiclelist>(response);
            return vehicles.Results;
        }

        public async Task<IEnumerable<Planet>> GetPlanetsAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/planets/");
            var planets = JsonConvert.DeserializeObject<Planetlist>(response);
            return planets.Results;
        }

        public async Task<IEnumerable<Specie>> GetSpeciesAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/species/");
            var species = JsonConvert.DeserializeObject<Specielist>(response);
            return species.Results;
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync()
        {
            var response = await _httpClient.GetStringAsync("https://swapi.dev/api/starships/");
            var starships = JsonConvert.DeserializeObject<Starshiplist>(response);
            return starships.Results;
        }

        //MÉTODOS PARA BUSCAR OS DETALHES DE CADA RECURSO PARA AO INVÉS DE PUXAR A URL, PUXAR NOME E OUTRAS COISAS QUANDO PRECISAR

        public async Task<People> GetPeopleDetailsAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var person = JsonConvert.DeserializeObject<People>(response);
            return person;
        }

        public async Task<Planet> GetPlanetDetailsAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var planet = JsonConvert.DeserializeObject<Planet>(response);
            return planet;
        }

        public async Task<Specie> GetSpeciesDetailsAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var specie = JsonConvert.DeserializeObject<Specie>(response);
            return specie;
        }

        public async Task<Starship> GetStarshipDetailsAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var starship = JsonConvert.DeserializeObject<Starship>(response);
            return starship;
        }
        public async Task<Vehicle> GetVehicleDetailsAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            var vehicle = JsonConvert.DeserializeObject<Vehicle>(response);
            return vehicle;
        }
    }

}
