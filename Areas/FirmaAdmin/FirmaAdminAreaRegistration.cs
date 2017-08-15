using System.Web.Mvc;

namespace PolinitKartSistemi.Areas.FirmaAdmin
{
    public class FirmaAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FirmaAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FirmaAdmin_default",
                "FirmaAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}