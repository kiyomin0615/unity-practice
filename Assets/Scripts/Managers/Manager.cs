using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Singleton Pattern
    // static 멤버는 "유일"하고 "공유"된다
    static Manager instance;
    public static Manager Instance { get { Init(); return instance; } }

    InputManager input = new InputManager();
    public static InputManager Input { get { return Instance.input; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        input.OnUpdate();
    }

    static void Init()
    {
        if (instance == null)
        {
            // 게임 오브젝트를 찾아서 리턴한다
            GameObject managerGameObject = GameObject.Find("@Manager");

            if (managerGameObject == null)
            {
                // 게임 오브젝트 생성한다
                managerGameObject = new GameObject { name = "@Manager" };
                // 게임 오브젝트에 컴포넌트를 추가한다
                managerGameObject.AddComponent<Manager>();
            }

            // 씬을 불러올 때 게임 오브젝트를 제거하지 않는다
            DontDestroyOnLoad(managerGameObject);
            // 게임 오브젝트에서 컴포넌트를 가져와서 리턴한다
            instance = managerGameObject.GetComponent<Manager>();
        }

    }
}
