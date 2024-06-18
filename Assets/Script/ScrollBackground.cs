using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    [Range(-1f,1f)]
    public float ScrollSpeed = 0.5f;
    private float offset;
    private Material mat; //������ ���׸���

    private void Start()
    {
        mat = GetComponent<Renderer>().material; //���׸����� �����´�
    }

    void Update()
    {
        offset += (Time.deltaTime * ScrollSpeed) / 10f; // X��ŭ ������ ���� Time.DeltaTime�� ���ؼ� ������Ʈ�� ��� ����
        mat.SetTextureOffset("_MainTex", new Vector2 (offset, 0)); //SetTextureOffset (�ؽ����� ������(�б�))�� ������
        //Update���� offset ��ŭ x��ǥ�� �̹Ƿ� �̹����� ���� ���� �������� �и�.
    }
}
