﻿using System.Web;
using System.Web.Optimization;

namespace Powerlink
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/HomeDesign").Include(
                        "~/Scripts/HomeDesign.js"));

            bundles.Add(new ScriptBundle("~/bundles/Datatables").Include(
            "~/Scripts/Datatables/jquery.dataTables.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                           "~/Content/css/main.css",
                           "~/Content/css/home_style.css"));

            bundles.Add(new StyleBundle("~/Content/css/Datatables").Include(
               "~/Content/css/extras/jquery.dataTables.css",
               "~/Content/css/extras/css-responsive-table.css"));
        }
    }
}
