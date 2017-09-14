﻿using System.Web.Optimization;

namespace SanaWebShop.Presentation
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // CUSTOM BUNDLES
            bundles.Add(new ScriptBundle("~/bundles/appScripts").Include(
                "~/Scripts/app/layout.js"));

            bundles.Add(new ScriptBundle("~/bundles/productScripts").Include(
                "~/Scripts/app/services/productService.js",
                "~/Scripts/app/controllers/productController.js"));

            bundles.Add(new ScriptBundle("~/bundles/listScripts").Include(
                "~/Scripts/app/controllers/listController.js"));
        }
    }
}
