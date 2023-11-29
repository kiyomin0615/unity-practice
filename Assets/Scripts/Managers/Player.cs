using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 싱글턴 패턴으로 유일한 Manager 컴포넌트에 접근할 수 있다
        Manager manager = Manager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
