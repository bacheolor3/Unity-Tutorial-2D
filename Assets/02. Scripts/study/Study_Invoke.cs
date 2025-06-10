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
        // 반복 Invoke ("함수명, 처음 지연시간, 몇초마다 실행)
        InvokeRepeating("Bomb", 0f, 1f);
    }

    private void Bomb()
    {
        Debug.Log($"현재 남은 시간 : {count}");
        count--;
        if (count == 0)
        {
            Debug.Log("폭탄이 터졌습니다");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CancelInvoke("Bomb");
            Debug.Log("폭탄이 해제되었습니다.");
        }
    }
}
