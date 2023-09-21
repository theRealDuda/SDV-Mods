using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace CJBItemSpawner.Framework.Models
{
    /// <summary>The mod settings.</summary>
    internal class ModConfig
    {
        /// <summary>The key which opens the item spawner menu.</summary>
        public KeybindList ShowMenuKey { get; set; } = new(SButton.I);

        /// <summary>Whether the trash can upgrade which reclaims part of the price of the destroyed items is applied in the item spawner menu too.</summary>
        public bool ReclaimPriceInMenuTrashCan { get; set; } = true;
    }
}
