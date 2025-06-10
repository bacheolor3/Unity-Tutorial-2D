using System.Collections;
using UnityEngine;

public class Study_Coroutine : MonoBehaviour
{
    private Coroutine runningCoroutine;
    private bool isStop = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BombRoutine());
        //StartCoroutine("RoutineA");
        //StartCoroutine(RoutineB());
        //runningCoroutine = StartCoroutine(RoutineA());


        //StopCoroutine("RoutineA"); // O
        //StopCoroutine(RoutineB()); // X
        //StopCoroutine(runningCoroutine);
        //StopAllCoroutines();

    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while(t > 0)
        {
            Debug.Log($"{t}초 남았습니다");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("폭탄이 해제되었습니다.");
                yield break;
            }
        }
        Debug.Log("폭탄이 터졌습니다");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }

    //IEnumerator RoutineA() // 대기를 할 수 있는 기능
    //{
    //    yield return new WaitForSeconds(2f); // 2초 대기
    //    Debug.Log("1");

    //    yield return new WaitForSeconds(2f); // 2초 대기
    //    Debug.Log("2");

    //    yield return new WaitForSeconds(2f); // 2초대기
    //    Debug.Log("3");
    //}

    //IEnumerator RoutineB()
    //{
    //    yield return new WaitForSeconds(2f); // 2초 대기
    //    Debug.Log("A");

    //    yield return new WaitForSeconds(2f); // 2초 대기
    //    Debug.Log("B");

    //    yield return new WaitForSeconds(2f); // 2초대기
    //    Debug.Log("C");
    //}
    //private void StopMethod()
    //{
    //    StopCoroutine(RoutineA());
    //}
}
