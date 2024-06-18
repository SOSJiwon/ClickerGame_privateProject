using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MakeGetDonutUI : MonoBehaviour
{
    public static MakeGetDonutUI instance;

    [Header("UI TMP")]
    public GameObject moneyUI;
    public TextMeshProUGUI getMoney;

    private int randomPosition;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Instantiate(moneyUI, new Vector3(1,1,1), Quaternion.identity);
        moneyUI.SetActive(false);
    }

    public IEnumerator PlayerGetDonut()
    {
        getMoney.text = $"+ {GameManager.instance.getDonutPrice.ToString()}³É";
        moneyUI.SetActive(true);
        yield return new WaitForSeconds(1f);
        moneyUI.SetActive(false);
    }

}
