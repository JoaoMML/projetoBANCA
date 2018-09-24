using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Softness.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
              //  "~/Content/Template/bower_components/jquery/dist/jquery.min.js",
                "~/Content/Template/bower_components/jquery/dist/jquery-3.3.1.js",
                "~/Content/Template/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/Template/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Content/Template/bower_components/fastclick/lib/fastclick.js",
                "~/Content/Template/dist/js/adminlte.min.js",
                "~/Content/Template/plugins/JqueryMask/jquery.mask.min.js",
                "~/Content/Template/plugins/JqueryValidate/Validate.js",
                "~/Content/Template/dist/js/demo.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/Template/bower_components/bootstrap/dist/css/bootstrap.css",
                "~/Content/Template/bower_components/bootstrap/dist/css/Styles.css",
                 "~/Content/Template/bower_components/font-awesome/css/font-awesome.min.css",
                "~/Content/Template/bower_components/Ionicons/css/ionicons.min.css",
                "~/Content/Template/dist/css/AdminLTE.min.css",
                "~/Content/Template/dist/css/skins/_all-skins.min.css"));


        }
    }
}