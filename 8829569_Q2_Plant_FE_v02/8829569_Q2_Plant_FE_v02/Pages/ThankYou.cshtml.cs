// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8829569_Q2_Plant_FE_v02.Pages;

public class ThankYouModel : PageModel
{
    public Flower flower = new Flower();
    private readonly ILogger<ThankYouModel> _logger;

    public ThankYouModel(ILogger<ThankYouModel> logger)
    {
        try{
            _logger = logger;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }

    public void OnGet(Flower flower)
    {
        try{
            
            this.flower = flower;
        }
        catch(Exception ex){
            Console.WriteLine(ex);
        }
        
    }
}
