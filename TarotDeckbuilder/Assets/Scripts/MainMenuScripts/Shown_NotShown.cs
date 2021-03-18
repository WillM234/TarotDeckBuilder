using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shown_NotShown : MonoBehaviour
{
    [Header("Menu Object Variables")]
    public Image MainMenuScreen;
    public bool isCovered;
    private Color defaultColor;
    private Color coveredColor;
    private void Awake()
    {
        defaultColor = new Color(1f,1f,1f,1f);
        coveredColor = new Color(.47f,.47f,.47f,1f);
    }
    void Update()
    {
        if (isCovered)
        {
            MainMenuScreen.color = coveredColor;
        }
        else
            MainMenuScreen.color = defaultColor;
    }
    public void IsCovered()
    {
        isCovered = true;
    }
    public void IsNotCovered()
    {
        isCovered = false;
    }
}
