using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop; // 기본값 false

    private void Start()
    {
        rotSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Z축 기준으로 회전하는 기능

        // 마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능
        if (Input.GetMouseButtonDown(0)) // 0은 마우스 왼쪽
        {
            rotSpeed = 5f; //마우스 왼쪽 눌렀을 때 속도 5로 돌게 만듬
        }

        // 키보드 스페이스 버튼을 눌렀을 때 -> 1번 실행. 이유 =Get Key "Down"이여서
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if(isStop == true)
        {
            rotSpeed *= 0.98f;

            if(rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }

        // rotSpeed = rotSpeed * 0.98f;
        // rotSpeed *= 0.98f;  현재 속도에서 특정 값만큼 줄이는 기능

        //transform.Rotate(0f, 0f, rotSpeed);
    }
}
