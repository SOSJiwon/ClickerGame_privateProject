using UnityEngine;

[CreateAssetMenu(fileName = "CatSO", menuName = "CatSO", order = 1)]
public class CatSO : ScriptableObject
{
    [Header("Cat Info")]
    public int makeSpeed; // 몇초에 한개?
    public int getMoreMoney; // 추가 돈 얼마나 얻어?

}
