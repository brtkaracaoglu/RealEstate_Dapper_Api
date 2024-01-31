using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public interface I_DefaultWhoWeAreComponentPartial
    {
        Task<IViewComponentResult> InvokeAsync();
    }
}