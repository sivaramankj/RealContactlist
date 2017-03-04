using System.Web;
using System.Web.Optimization;

namespace ContactList
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.jqgrid*"));

            bundles.Add(new ScriptBundle("~/Masterbundle/all").Include(
                "~/Scripts/jquery/jquery-1.10.2.js",
                "~/Scripts/jquery validator/jquery.validate.js",
                "~/Scripts/jquery validator/jquery.validate.unobtrusive.js",
                "~/Scripts/appjs/validation.js",
                "~/JQGridReq/grid.locale-en.js",
                "~/JQGridReq/jquery.jqGrid.js",
                "~/Scripts/bootstrap/bootstrap.min.js"
                ));
   
                   // Use the development version of Modernizr to develop with and learn from. Then, when you're
                   // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                   bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/ui.jqgrid.min.css"));

            bundles.Add(new StyleBundle("~/Masterbundle/css").Include(
                      "~/Content/Site.css",
                      "~/Content/bootstrap.css",
                      "~/Content/ui.jqgrid.css",
                      "~/Content/jquery-ui-1.9.2.custom.css",
                      "~/Content/LoginStyle.css"
                      ));

            BundleTable.EnableOptimizations = true;

        }
    }
}
