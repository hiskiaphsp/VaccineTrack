using System.Web;
using System.Web.Optimization;

namespace Vaccine
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/scripts").Include(
                        "~/Content/libs/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/libs/simplebar/simplebar.min.js",
                        "~/Content/libs/node-waves/waves.min.js",
                        "~/Content/libs/feather-icons/feather.min.js",
                        "~/Scripts/js/pages/plugins/lord-icon-2.1.0.js",
                        "~/Scripts/js/plugins.js",
                        "~/Content/libs/apexcharts/apexcharts.min.js",
                        "~/Content/libs/jsvectormap/js/jsvectormap.min.js",
                        "~/Content/libs/swiper/swiper-bundle.min.js",
                        "~/Scripts/js/app.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/libs/jsvectormap/css/jsvectormap.min.css",
                      "~/Content/css/libs/swiper/swiper-bundle.min.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/icons.min.css",
                      "~/Content/css/app.min.css",
                      "~/Content/css/custom.min.css"
                      ));
        }
    }
}
