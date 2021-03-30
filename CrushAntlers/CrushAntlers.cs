using System;
using BepInEx;
using JotunnLib.Managers;
using JotunnLib.Entities;

namespace CrushAntlers
{
    [BepInPlugin("com.bepinex.plugins.crushantlers", "CrushAntlers", "0.1.0")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    public class CrushAntlers : BaseUnityPlugin
    {
        private void Awake()
        {
            ObjectManager.Instance.ObjectRegister += registerObjects;
        }

        private void registerObjects(object sender, EventArgs e)
        {
            ObjectManager.Instance.RegisterRecipe(new RecipeConfig()
            {
                Name = "Recipe_CrushAntlers",
                Item = "BoneFragments",
                Amount = 10,
                CraftingStation = "piece_workbench",

                Requirements = new PieceRequirementConfig[]
                {
                    new PieceRequirementConfig()
                    {
                        Item = "HardAntler",
                        Amount = 1
                    }
                }
            });
        }
    }
}