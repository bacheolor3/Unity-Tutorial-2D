using Unity.VisualScripting;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    //public GameObject destroyobj;

    //public Vector3 pos;
    //public Quaternion rot;

    void Start()
    {
        //Debug.Log("�����Ǿ����ϴ�.");
        CreateAmongus();

        //Destroy(destroyobj, 3f); // �Ű� ������ �� ���� ������Ʈ�� �ı��ϴ� ���. , 3f<-3�� �ڿ� �ı��� ��Ű�ڴ� ��� ��

    }

    // void OnDestroy()
    //{
    //    Debug.Log("�ı��Ǿ����ϴ�");
    //}
    /// <summary>
    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab /*, pos, rot*/);
        //Instantiate(prefab, pos, rot); // GameObject�� �����ϴ� ���
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {objTf.childCount}");

        
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");

    }

   
}
