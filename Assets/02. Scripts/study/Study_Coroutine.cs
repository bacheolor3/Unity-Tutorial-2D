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
            Debug.Log($"{t}�� ���ҽ��ϴ�");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("��ź�� �����Ǿ����ϴ�.");
                yield break;
            }
        }
        Debug.Log("��ź�� �������ϴ�");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }

    //IEnumerator RoutineA() // ��⸦ �� �� �ִ� ���
    //{
    //    yield return new WaitForSeconds(2f); // 2�� ���
    //    Debug.Log("1");

    //    yield return new WaitForSeconds(2f); // 2�� ���
    //    Debug.Log("2");

    //    yield return new WaitForSeconds(2f); // 2�ʴ��
    //    Debug.Log("3");
    //}

    //IEnumerator RoutineB()
    //{
    //    yield return new WaitForSeconds(2f); // 2�� ���
    //    Debug.Log("A");

    //    yield return new WaitForSeconds(2f); // 2�� ���
    //    Debug.Log("B");

    //    yield return new WaitForSeconds(2f); // 2�ʴ��
    //    Debug.Log("C");
    //}
    //private void StopMethod()
    //{
    //    StopCoroutine(RoutineA());
    //}
}
