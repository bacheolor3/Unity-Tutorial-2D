using UnityEngine;

public class StudyComponent : MonoBehaviour
{

    public GameObject obj;
    //�� ��ġ���� new game object�������� ū �ǹ� ����

    //public GameObject obj; // ť�� ���� ������Ʈ�� �Ʊ�ó�� �ְ� ������
    //// ������� private�� �ϴ� �� ����. Ư�� findobject����� ���ٸ�

    public Mesh msh;
    public Material mat; //����Ƽ ������ �󿡼� ���� �ִ� ���

    //public Transform objTF;
    
    
    //public string changeName;



    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube("Cube"); //�Լ� ����, ȣ��

        //obj = GameObject.Find("Main Camera");
        // obj.name = "ť��";

        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        //obj = GameObject.FindGameObjectWithTag("Player");

        ////            return���� ���� ����� GameObject Ÿ��
        //objTF = GameObject.FindGameObjectWithTag("Player").transform;

        ////          ���ϰ�: GameObjectType<���̰� TransformType�� ������ �ϸ� ���� �ȵ����� �־����� �ϴ� ����� �̰�
        //// ��: String���� string str =  "�ȳ��ϼ���"��� ���� �� int number = str�� ��ȯ�ϰ� ���� �� ������ �ߵ���. Ÿ���� �ٸ� �� ������ �ϸ� �ȵ�
        //objTF = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //�̰� �ٸ� Ÿ������ ��ȯ�ϴ� ��

        //objTF.gameObject.SetActive(false); // �׳�  setActive�ϸ� �ȵ�

        //// obj�� MeshRenderer�� �����ؼ� Ȱ�����¸� false�� �����ϰڴ�
        //obj.GetComponent<MeshRenderer>().enabled = false;

        //// obj�� Gameobject Ȱ�����¸� false(���� ���)
        //obj.SetActive(false);

        //                  0~15. R/G/B��� �����ϸ� ��. 16������ ���� ��Ÿ���� ��
        //Debug.Log($"<color=#FF0000>�̸� : {obj.name}"); // ���� ������Ʈ �̸�
        //Debug.Log($"<color=#00FF00>�±� : {obj.tag}"); // ���� ������Ʈ�� �±�
        //Debug.Log($"<color=#0000FF>��ġ : {obj.transform.position}"); // ���� ������Ʈ�� transform ������Ʈ�� ��ġ
        //Debug.Log($"<color=#FFFF00>ȸ�� : {obj.transform.rotation}"); // ���� ������Ʈ�� transform ������Ʈ�� ȸ��
        //Debug.Log($"<color=#FF00FF>ũ�� : {obj.transform.localScale}"); // ���� ������Ʈ�� transform ������Ʈ�� ũ��

        //// MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� ����ϴ� ���
        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshRenderer ������Ʈ�� �����ؼ� material Log �޼����� ����ϴ� ���
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");
        ////obj.name = changeName;

    }
    // �Լ��� ť�� �����
    public void CreateCube(string name)
    {
        obj = new GameObject(name);


        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
