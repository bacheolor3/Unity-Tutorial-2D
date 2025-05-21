using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임 오브젝트를 아까처럼 넣고 싶을때

    public string changeName;



    void Start()
    {
        obj = GameObject.Find("Main Camera");
        // obj.name = "큐브";
        obj.name = changeName;

    }
}
