using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1; // ��� ���� (�ʵ�)
    public int number2;
    //Ȥ�� public int number1, number2; <-�̷��ĵ� ����
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod();    // �Լ� ȣ��

        int minusResult = MinusMenthod(); // �Լ� ȣ��

        // Debug.Log(AddMethod());
        // Debug.Log(MinusMenthod());

        Debug.Log($"���� �� : {addResult} / �� ��: {minusResult}");
    }

    int AddMethod()
    {
        // ���� ���� result
        int result = number1 + number2;

        return result;
    }

    int MinusMenthod()
    {
        // ���� ���� result
        int result = number1 - number2;

        return result;
    }

}
