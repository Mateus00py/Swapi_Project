using Microsoft.AspNetCore.Mvc.RazorPages;
using SWAPI.Services;
using SWAPI.Domain;

namespace SWAPI.Pages
{
    public class StarshipsModel : PageModel
    {
        private readonly SwapiService _swapiService;

        public IEnumerable<Starship> Starships { get; set; }

        public StarshipsModel(SwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        public async Task OnGet()
        {
            Starships = await _swapiService.GetStarshipsAsync();
        }
    }
}
