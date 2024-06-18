using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DonutSO", menuName = "DonutSO", order = 0)]

public class DonutSO : ScriptableObject
{
    [Header("Donut Info")]
    public string donutName;
    public int price;
    public Sprite image;

    [Header("Clicker Info")]
    public int clickPrice;
}
