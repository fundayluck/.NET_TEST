using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_ILCS.Pages;

public class Test5Model : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Test5Model(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

