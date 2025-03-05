using Microsoft.AspNetCore.Mvc.RazorPages;
using SWAPI.Services;
using SWAPI.Domain;

namespace SWAPI.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly SwapiService _swapiService;

        public IEnumerable<People> People { get; set; }

        public PeopleModel(SwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        public async Task OnGet()
        {
            People = await _swapiService.GetPeopleAsync();
        }
    }
}