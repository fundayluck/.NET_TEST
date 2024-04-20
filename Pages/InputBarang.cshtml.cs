using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_ILCS.Pages;

public class InputBarangModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public InputBarangModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}



