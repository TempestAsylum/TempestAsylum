Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/script").Include(
                    "~/js/modern/dropdown.js",
                    "~/js/modern/accordion.js",
                    "~/js/modern/buttonset.js",
                    "~/js/modern/carousel.js",
                    "~/js/modern/input-control.js",
                    "~/js/modern/pagecontrol.js",
                    "~/js/modern/rating.js",
                    "~/js/modern/slider.js",
                    "~/js/modern/tile-slider.js",
                    "~/js/modern/tile-drag.js",
                    "~/js/assets/jquery-1.8.2.min.js.js",
                    "~/js/assets/jquery.mousewheel.min.js.js",
                    "~/js/assets/google-analytics.js",
                    "~/js/google-code-prettify/prettify.js",
                    "~/js/sharrre/jquery.sharrre-1.3.4.min.js"))

        bundles.Add(New StyleBundle("~/css").Include("~/css/modern.css"))
    End Sub
End Class