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
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����
        /// 

        float h = Input.GetAxis("Horizontal"); //<-�̰� ������ �ִ� ��(�ε巴�� �����ϴ� ��)
        float v = Input.GetAxis("Vertical");

        // �� �������� ��
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
