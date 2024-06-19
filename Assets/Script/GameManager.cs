using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public DonutSO NowDonutLevel;
    public Objectpool pool;

    [Header("플레이어 정보")]
    public int playerMoney = 0; // 현재 돈
    public int getDonutPrice = 1; // 도넛 개수당 얻는 가격
    public int makeDonutToOneClick = 1; // 클릭시 얻는 도넛 개수

    [Header("자동 생산")]
    public int makeAutoDonut = 1; // 자동으로 얻는 도넛 개수
    public float makeAutoDonutRange = 5f; // 자동으로 도넛을 얻는 주기

    [Header("UI TMP")]
    public TextMeshProUGUI Money;
    public TextMeshProUGUI DonutName;
    public TextMeshProUGUI DonutLevel;
    public TextMeshProUGUI CatLevel;
    public TextMeshProUGUI DonutPrice;
    public TextMeshProUGUI MakeSpeed;

    private void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;

        pool = GetComponent<Objectpool>();
    }
    void Start()
    {
        
    }

    private void Update()
    {
        Money.text = $"{playerMoney.ToString()}냥";

        DonutPrice.text = $"개당 {NowDonutLevel.price}냥";
        DonutName.text = NowDonutLevel.donutName;
    }
}
