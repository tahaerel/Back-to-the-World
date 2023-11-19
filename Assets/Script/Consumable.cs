using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "New Consumable", menuName = "Items/Consumable")]
public class Consumable : Item
{
    [SerializeField] private Rarity rarity;
    [SerializeField] private string useText = "Something";

    public Rarity Rarity { get { return rarity; } }

    public override string ColouredName
    {
        get
        {
            string hexColour = ColorUtility.ToHtmlStringRGB(rarity.TextColour);
            return $"<color=#{hexColour}>{Name}</color>";
        }
    }

    public override string GetTooltipInfoText()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append(Rarity.Name).AppendLine();
        builder.Append("<color=green>Gerekli: ").Append(useText).Append("</color>").AppendLine();
        
        //builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");

        return builder.ToString();
    }
}
