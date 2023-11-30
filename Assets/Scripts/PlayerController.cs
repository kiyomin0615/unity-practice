using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 비공개 필드를 유니티 인스펙터 뷰에서 컨트롤할 수 있다
    [SerializeField]
    float _speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키를 누르고 있으면 true를 리턴한다
        if (Input.GetKey(KeyCode.W))
            // 트랜스폼 컴포넌트
            // transform.position은 월드 스페이스 기준
            // transform.Translate(Vector3, Space)는 스페이스 기준을 선택할 수 있다
            // 스페이스를 선택하지 않으면 기본적으로 로컬 스페이스 기준
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}
