using UnityEngine;

public class Study_Invoke : MonoBehaviour
{
    public int count = 10;
    //public int Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Invoke("Method1", Timer);
        //CancelInvoke("Method1");
        // �ݺ� Invoke ("�Լ���, ó�� �����ð�, ���ʸ��� ����)
        InvokeRepeating("Bomb", 0f, 1f);
    }

    private void Bomb()
    {
        Debug.Log($"���� ���� �ð� : {count}");
        count--;
        if (count == 0)
        {
            Debug.Log("��ź�� �������ϴ�");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CancelInvoke("Bomb");
            Debug.Log("��ź�� �����Ǿ����ϴ�.");
        }
    }
}
