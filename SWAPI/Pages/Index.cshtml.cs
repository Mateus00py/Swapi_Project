using Microsoft.AspNetCore.Mvc.RazorPages;
using SWAPI.Services;
using SWAPI.Domain;

namespace SWAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SwapiService _swapiService;

        public IndexModel(SwapiService swapiService)
        {
            _swapiService = swapiService;
        }

        public IEnumerable<Film> Films { get; set; }

        public async Task OnGetAsync()
        {
            Films = await _swapiService.GetFilmsAsync();
        }
    }
}
