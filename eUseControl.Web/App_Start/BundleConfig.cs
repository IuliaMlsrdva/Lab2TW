using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                       "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/js").Include(
                      "~/Script/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                     "~/Scripts/jquery-3.4.1.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapbundle/js").Include(
                      "~/Script/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery.min/js").Include(
                    "~/Scripts/jquery-3.4.1.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/validation/js").Include(
                    "~/Scripts/jquery.validate.min.js"));

            bundles.Add(new StyleBundle("~/bundles/flex-slider/css").Include(
                     "~/Content/flex-slider.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/fontawesome/css").Include(
                     "~/Content/fontawesome.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl/css").Include(
                     "~/Content/owl.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/templatemo-style/css").Include(
                     "~/Content/templatemo-style.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/breakpoints.min/js").Include(
                    "~/Script/breakpoints.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/browser.min/js").Include(
                    "~/Script/browser.min.js"));     //
            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include(
                    "~/Script/custom.js"));
            bundles.Add(new StyleBundle("~/bundles/owl-carousel/js").Include(
                     "~/Script/owl-carousel.js"));
            bundles.Add(new ScriptBundle("~/bundles/transition/js").Include(
                    "~/Script/transition.js"));
        }
    }
}