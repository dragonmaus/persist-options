using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley.Menus;

namespace PersistOptions
{
    public class ModEntry : Mod
    {
        private static string OptionsFile => "options.json";

        public override void Entry(IModHelper helper)
        {
            helper.Events.Display.MenuChanged += Menu;
            helper.Events.GameLoop.SaveLoaded += Load;
        }

        private void Load(object sender, SaveLoadedEventArgs e)
        {
            Options options = Helper.Data.ReadJsonFile<Options>(OptionsFile);
            if (options is null)
            {
                Save();
            }
            else
            {
                options.LoadToGame();
            }
        }

        private void Menu(object sender, MenuChangedEventArgs e)
        {
            if (e.OldMenu is GameMenu)
            {
                Save();
            }
        }

        private void Save() => Helper.Data.WriteJsonFile(OptionsFile, new Options());
    }
}
