using UnityEngine;

public class StudyComponent : MonoBehaviour
{

    public GameObject obj;
    //이 위치에서 new game object만들어봐야 큰 의미 없음

    //public GameObject obj; // 큐브 게임 오브젝트를 아까처럼 넣고 싶을때
    //// 원래라면 private로 하는 게 맞음. 특히 findobject기능을 쓴다면

    public Mesh msh;
    public Material mat; //유니티 에디터 상에서 직접 넣는 경우

    //public Transform objTF;
    
    
    //public string changeName;



    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube("Cube"); //함수 실행, 호출

        //obj = GameObject.Find("Main Camera");
        // obj.name = "큐브";

        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        //obj = GameObject.FindGameObjectWithTag("Player");

        ////            return으로 나온 결과가 GameObject 타입
        //objTF = GameObject.FindGameObjectWithTag("Player").transform;

        ////          리턴값: GameObjectType<ㅡ이걸 TransformType에 넣으려 하면 원래 안되지만 넣어지게 하는 방법이 이거
        //// 예: String으로 string str =  "안녕하세요"라고 적는 걸 int number = str로 변환하고 싶을 때 에러가 뜨듯이. 타입이 다른 걸 넣으려 하면 안됨
        //objTF = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //이게 다른 타입으로 전환하는 법

        //objTF.gameObject.SetActive(false); // 그냥  setActive하면 안됨

        //// obj의 MeshRenderer에 접근해서 활성상태를 false로 변경하겠다
        //obj.GetComponent<MeshRenderer>().enabled = false;

        //// obj의 Gameobject 활성상태를 false(끄는 기능)
        //obj.SetActive(false);

        //                  0~15. R/G/B라고 생각하면 됨. 16진수로 색깔 나타내는 법
        //Debug.Log($"<color=#FF0000>이름 : {obj.name}"); // 게임 오브젝트 이름
        //Debug.Log($"<color=#00FF00>태그 : {obj.tag}"); // 게임 오브젝트의 태그
        //Debug.Log($"<color=#0000FF>위치 : {obj.transform.position}"); // 게임 오브젝트의 transform 컴포넌트의 위치
        //Debug.Log($"<color=#FFFF00>회전 : {obj.transform.rotation}"); // 게임 오브젝트의 transform 컴포넌트의 회전
        //Debug.Log($"<color=#FF00FF>크기 : {obj.transform.localScale}"); // 게임 오브젝트의 transform 컴포넌트의 크기

        //// MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshRenderer 컴포넌트에 접근해서 material Log 메세지로 출력하는 기능
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        ////obj.name = changeName;

    }
    // 함수로 큐브 만들기
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
