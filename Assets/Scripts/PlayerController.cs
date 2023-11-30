using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 비공개 필드를 유니티 인스펙터 뷰에서 컨트롤할 수 있다
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {

    }

    void Update()
    {
        // 키를 누르고 있으면 true를 리턴한다
        if (Input.GetKey(KeyCode.W))
        {
            // transform.rotation은 Quaternion 타입
            // transform.eulerAngles은 Vector3 타입
            // Quaternion.Euler(Vector3) 메소드는 Vector3를 Quaternion으로 변환해서 리턴한다
            // Quaternion.LookRotation(Vector3) 메소드는 벡터 방향을 바라보는 로테이션 값을 리턴한다
            // Quaternion.Slerp(Quaternion, Quaternion, float) 메소드는 두 쿼터니언의 사잇값을 리턴한다
            // 부드러운 회전을 위해서 주로 사용된다
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.5f);
            // 트랜스폼 컴포넌트
            // transform.position은 월드 스페이스 기준
            // transform.Translate(Vector3, Space)는 스페이스 기준을 선택할 수 있다
            // 스페이스를 선택하지 않으면 기본적으로 로컬 스페이스 기준
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.5f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.5f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.5f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
