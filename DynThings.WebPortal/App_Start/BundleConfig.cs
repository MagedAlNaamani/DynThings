﻿using System.Web;
using System.Web.Optimization;

namespace DynThings.WebPortal
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstraps.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //bootstrap-notify
            bundles.Add(new ScriptBundle("~/bundles/bootstrapnotify").Include(
                    "~/Scripts/bootstrap-notify/bootstrap-notify.min.js"));


            //HighCharts JS
            bundles.Add(new ScriptBundle("~/bundles/highcharts").Include(
                    "~/Scripts/Highcharts/highcharts.js",
                    "~/Scripts/Highcharts/exporting.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

         
        }
    }
}
