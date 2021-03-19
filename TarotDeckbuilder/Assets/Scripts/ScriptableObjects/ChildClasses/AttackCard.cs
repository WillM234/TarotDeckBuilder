using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack Card", menuName = "Custom Scriptable Objects/Cards/Attack Card")]
public class AttackCard : CardObject
{
   public void Awake()
    {
        cardType = CardType.Attack;
    }
}
