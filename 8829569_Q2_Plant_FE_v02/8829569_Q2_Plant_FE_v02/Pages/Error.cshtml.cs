// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829569_Q2_Plant_FE_v02.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    private readonly ILogger<ErrorModel> _logger;

    public ErrorModel(ILogger<ErrorModel> logger)
    {
        try{
            _logger = logger;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }

    public void OnGet()
    {
        try{
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }
}

