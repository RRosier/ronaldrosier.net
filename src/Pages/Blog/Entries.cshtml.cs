using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rosier.Blog.Models;
using Rosier.Blog.Services.Abstractions;

namespace Rosier.Blog.Pages
{
    /// <summary>
    /// Model to fetch, query and list blog entries.
    /// </summary>
    public class EntriesModel : PageModel
    {
        private readonly IEntriesService _entriesService;
        private readonly ILogger _logger;

        public EntriesModel(IEntriesService entriesService, ILogger<EntriesModel> logger)
        {
            this._entriesService = entriesService ?? throw new ArgumentNullException(nameof(entriesService));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Entry[] Entries { get; set; } = new Entry[0];

        public async Task OnGetAsync()
        {
            this.Entries = await this._entriesService.GetMostRecentEntriesAsync();
        }
    }
}
