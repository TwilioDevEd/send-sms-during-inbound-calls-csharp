using System.Web;
using System.Web.Optimization;

namespace TwilioApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/lib/dist/js/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/lib/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Scripts/lib/dist/css/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
