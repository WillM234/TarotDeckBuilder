using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Neutral Card", menuName = "Custom Scriptable Objects/Cards/Neutral Card")]
public class NeutralCard : CardObject
{
    public void Awake()
    {
        cardType = CardType.Neutral;
    }
}
