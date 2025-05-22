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
        //Debug.Log("생성되었습니다.");
        CreateAmongus();

        //Destroy(destroyobj, 3f); // 매개 변수로 들어간 게임 오브젝트를 파괴하는 기능. , 3f<-3초 뒤에 파괴를 시키겠다 라는 뜻

    }

    // void OnDestroy()
    //{
    //    Debug.Log("파괴되었습니다");
    //}
    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab /*, pos, rot*/);
        //Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {objTf.childCount}");

        
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");

    }

   
}
