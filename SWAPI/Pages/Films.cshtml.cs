using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using SWAPI.Domain;
using SWAPI.Services;

namespace SWAPI.Pages
{
    public class FilmsModel : PageModel
    {
        private readonly SwapiService _swapiService;

        public FilmsModel(SwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        public List<Film> Films { get; set; } = new List<Film>();
        public Film CurrentFilm { get; set; }
        public int CurrentFilmIndex { get; set; } = 0;

        public async Task OnGetAsync(int? id)
        {
            // Carrega todos os filmes (se ainda não foi carregado)
            if (!Films.Any())
            {
                Films = (await _swapiService.GetFilmsAsync()).ToList();
            }

            // Se id for null, vai pegar o primeiro filme
            CurrentFilmIndex = id ?? 0;

            // Atribui o filme atual
            if (Films.Count > 0)
            {
                CurrentFilm = Films[CurrentFilmIndex];

                // Buscar informações detalhadas de pessoas, planetas, espécies, etc.
                var speciesDetails = new List<Specie>();
                foreach (var url in CurrentFilm.Species)
                {
                    speciesDetails.Add(await _swapiService.GetSpeciesDetailsAsync(url));
                }
                CurrentFilm.SpeciesDetails = speciesDetails;

                var starshipsDetails = new List<Starship>();
                foreach (var url in CurrentFilm.Starships)
                {
                    starshipsDetails.Add(await _swapiService.GetStarshipDetailsAsync(url));
                }
                CurrentFilm.StarshipsDetails = starshipsDetails;

                var vehiclesDetails = new List<Vehicle>();
                foreach (var url in CurrentFilm.Vehicles)
                {
                    vehiclesDetails.Add(await _swapiService.GetVehicleDetailsAsync(url));
                }
                CurrentFilm.VehiclesDetails = vehiclesDetails;

                var planetsDetails = new List<Planet>();
                foreach (var url in CurrentFilm.Planets)
                {
                    planetsDetails.Add(await _swapiService.GetPlanetDetailsAsync(url));
                }
                CurrentFilm.PlanetsDetails = planetsDetails;

                var charactersDetails = new List<People>();
                foreach (var url in CurrentFilm.Characters)
                {
                    charactersDetails.Add(await _swapiService.GetPeopleDetailsAsync(url));
                }
                CurrentFilm.CharactersDetails = charactersDetails;
            }
        }

        public IActionResult OnGetNext()
        {
            if (Films.Count == 0) return RedirectToPage("/Films");

            CurrentFilmIndex = (CurrentFilmIndex + 1) % Films.Count;
            return RedirectToPage("/Films", new { id = CurrentFilmIndex });
        }

        public IActionResult OnGetPrevious()
        {
            if (Films.Count == 0) return RedirectToPage("/Films");

            CurrentFilmIndex = (CurrentFilmIndex - 1 + Films.Count) % Films.Count;
            return RedirectToPage("/Films", new { id = CurrentFilmIndex });
        }
    }
}
