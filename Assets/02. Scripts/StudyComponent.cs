using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ�� �Ʊ�ó�� �ְ� ������

    public string changeName;



    void Start()
    {
        obj = GameObject.Find("Main Camera");
        // obj.name = "ť��";
        obj.name = changeName;

    }
}
