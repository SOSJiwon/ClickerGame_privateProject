using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public DonutSO NowDonutLevel;
    public Objectpool pool;

    [Header("�÷��̾� ����")]
    public int playerMoney = 0; // ���� ��
    public int getDonutPrice = 1; // ���� ������ ��� ����
    public int makeDonutToOneClick = 1; // Ŭ���� ��� ���� ����

    [Header("�ڵ� ����")]
    public int makeAutoDonut = 1; // �ڵ����� ��� ���� ����
    public float makeAutoDonutRange = 5f; // �ڵ����� ������ ��� �ֱ�

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
        Money.text = $"{playerMoney.ToString()}��";

        DonutPrice.text = $"���� {NowDonutLevel.price}��";
        DonutName.text = NowDonutLevel.donutName;
    }
}
