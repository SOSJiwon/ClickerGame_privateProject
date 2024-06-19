using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAutoDonut : MonoBehaviour
{
    private int getDonutPrice => GameManager.instance.getDonutPrice;
    private int makeAutoDonut => GameManager.instance.makeAutoDonut;
    private float makeAutoDonutRange => GameManager.instance.makeAutoDonutRange;

    private void Awake()
    {
    }
    void Start()
    {
        StartCoroutine(GetAutoDonutPrice());
    }

    IEnumerator GetAutoDonutPrice()
    {
        while (Time.timeScale == 1f)
        {
            GameManager.instance.playerMoney += getDonutPrice * makeAutoDonut;
            if(makeAutoDonut > 1)
            {
                StartCoroutine(MakeGetDonutUI.instance.PlayerGetDonut(makeAutoDonut));
            }
            else
            {
                StartCoroutine(MakeGetDonutUI.instance.PlayerGetDonut());
            }
            yield return new WaitForSeconds(makeAutoDonutRange);
        }

        yield break;
    }
}
