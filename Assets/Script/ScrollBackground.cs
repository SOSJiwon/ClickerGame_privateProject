using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    [Range(-1f,1f)]
    public float ScrollSpeed = 0.5f;
    private float offset;
    private Material mat; //설정한 마테리얼

    private void Start()
    {
        mat = GetComponent<Renderer>().material; //마테리얼을 가져온다
    }

    void Update()
    {
        offset += (Time.deltaTime * ScrollSpeed) / 10f; // X만큼 움직일 값을 Time.DeltaTime에 곱해서 업데이트로 계속 더함
        mat.SetTextureOffset("_MainTex", new Vector2 (offset, 0)); //SetTextureOffset (텍스쳐의 오프셋(밀기))를 설정함
        //Update에서 offset 만큼 x좌표로 미므로 이미지가 점점 정한 방향으로 밀림.
    }
}
