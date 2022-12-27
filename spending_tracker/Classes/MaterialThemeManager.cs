using MaterialSkin;

namespace spending_tracker.Classes;

public class MaterialThemeManager
{
    public void setDefaultTheme(MaterialSkinManager materialSkinManager)
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        // materialSkinManager.ColorScheme = new ColorScheme(
        //            Primary.Cyan700,
        //            Primary.Cyan900,
        //            Primary.Cyan500,
        //            Accent.DeepOrange200,
        //            TextShade.WHITE);
        // materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        // materialSkinManager.ColorScheme = new ColorScheme(
        //            Primary.Blue600,
        //            Primary.Blue800,
        //            Primary.Blue300,
        //            Accent.Red100,
        //            TextShade.WHITE);
    }
}