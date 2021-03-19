using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class CardObject : ScriptableObject
{
    public enum CardType { Magic, Attack, Neutral}
    public CardType cardType;

    [Header("Variables for Children")]
    public string cardName;
    [TextArea(10, 5)]
    public string effectDescription;
    public int cardCost;
    public Image cardImage;
}
