using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDonut : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClickDonut()
    {
        animator.SetTrigger("IsClick");
        GameManager.instance.playerMoney += GameManager.instance.getDonutPrice;
        StartCoroutine(MakeGetDonutUI.instance.PlayerGetDonut());
    }
    
}
