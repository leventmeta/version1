using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        // Angular bundles
        bundles.Add(new ScriptBundle("~/bundles/Angular")
            .Include(
                "~/Scripts/Client1/*.js"));

        bundles.Add(new StyleBundle("~/Content/Angular")
            .Include("~/Scripts/Client1/*.css"));
    }
}
