using System.Web;
using System.Web.Optimization;

namespace gsm
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/jquery-migrate-1.2.1.js",
                        "~/Scripts/jquery.equalheights.js",
                        "~/Scripts/jquery.mobile.customized.min.js",
                        "~/Scripts/modal.js",
                        "~/Scripts/TMForm",
                        "~/Scripts/camera.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/grid.css",
                      "~/Content/camera.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/contact-form.css",
                      "~/Content/style_feedback.css",
                      "~/Content/style.css"));
        }
    }
}
