using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;

public class MakeGetDonutUI : MonoBehaviour
{
    public static MakeGetDonutUI instance;

    [Header("UI TMP")]
    public GameObject prefab;
    public Queue<GameObject> savePrefabs = new Queue<GameObject>();


    private void Awake()
    {
        instance = this;
    }


    public IEnumerator PlayerGetDonut()
    {
        savePrefabs.Enqueue(Instantiate(prefab, new Vector3(Random.Range(300, 600),
            Random.Range(500, 600), 1f), Quaternion.identity, transform));

        yield return new WaitForSeconds(1f);
        GameObject destroyPrefabs = savePrefabs.Dequeue();
        Destroy(destroyPrefabs);

    }

    public IEnumerator PlayerGetDonut(int AutoDonutCount)
    {
        for(int i = 0; i < AutoDonutCount; i++)
        {
            savePrefabs.Enqueue(Instantiate(prefab, new Vector3(Random.Range(300, 600),
            Random.Range(500, 600), 1f), Quaternion.identity, transform));
        }

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < AutoDonutCount; i++)
        {
            GameObject destroyPrefabs = savePrefabs.Dequeue();
            Destroy(destroyPrefabs);
        }
    }

}
