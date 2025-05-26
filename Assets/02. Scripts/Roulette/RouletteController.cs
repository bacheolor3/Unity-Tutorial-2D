using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop; // �⺻�� false

    private void Start()
    {
        rotSpeed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Z�� �������� ȸ���ϴ� ���

        // ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButtonDown(0)) // 0�� ���콺 ����
        {
            rotSpeed = 5f; //���콺 ���� ������ �� �ӵ� 5�� ���� ����
        }

        // Ű���� �����̽� ��ư�� ������ �� -> 1�� ����. ���� =Get Key "Down"�̿���
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
        // rotSpeed *= 0.98f;  ���� �ӵ����� Ư�� ����ŭ ���̴� ���

        //transform.Rotate(0f, 0f, rotSpeed);
    }
}
