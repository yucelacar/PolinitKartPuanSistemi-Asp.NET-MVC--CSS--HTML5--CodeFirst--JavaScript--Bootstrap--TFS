using System.Web.Mvc;

namespace PolinitKartSistemi.Areas.Musteri
{
    public class MusteriAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Musteri";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Musteri_default",
                "Musteri/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}