using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickUI : MonoBehaviour
{
    public TextMeshProUGUI getMoney;
    private void Awake()
    {
        getMoney = GetComponentInChildren<TextMeshProUGUI>();
        getMoney.text = $"+ {GameManager.instance.getDonutPrice.ToString()}³É";
    }

}
