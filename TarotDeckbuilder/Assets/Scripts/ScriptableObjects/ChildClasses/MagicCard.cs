using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Magic Card", menuName = "Custom Scriptable Objects/Cards/Magic Card")]
public class MagicCard : CardObject
{
    public void Awake()
    {
        cardType = CardType.Magic;
    }
}
