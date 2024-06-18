using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDonut : MonoBehaviour
{
    public void OnClickDonut()
    {
        GameManager.instance.playerMoney += GameManager.instance.getDonutPrice;
        StartCoroutine(MakeGetDonutUI.instance.PlayerGetDonut());
    }
    
}
