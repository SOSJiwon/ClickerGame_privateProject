using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] poolsize;

    Queue<GameObject> objectPool = new Queue<GameObject>();

    private void Awake()
    {
        poolsize = new GameObject[10];

        for (int i = 0; i < poolsize.Length; i++)
        {
            GameObject obj = Instantiate(prefab, transform);
            obj.SetActive(false);
            objectPool.Enqueue(obj);
        }

    }

    public GameObject SpawnFromPool()
    {
        // ���� ������ ��ü�� ��Ȱ��
        GameObject obj = objectPool.Dequeue();
        objectPool.Enqueue(obj);
        return obj;
    }
}

