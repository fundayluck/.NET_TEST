using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_ILCS.Pages;

public class Test4Model : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Test4Model(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

