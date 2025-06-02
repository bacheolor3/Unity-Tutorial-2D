using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    public static int coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        // input system(old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽
        /// 

        float h = Input.GetAxis("Horizontal"); //<-이건 관성이 있는 거(부드럽게 증감하는 값)
        float v = Input.GetAxis("Vertical");

        // 딱 떨어지는 값
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;
        Vector3 normalDir = dir.normalized;

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}

        //if(Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}
    }
}
