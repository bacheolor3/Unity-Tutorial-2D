using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1; // 멤버 변수 (필드)
    public int number2;
    //혹은 public int number1, number2; <-이런식도 가능
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod();    // 함수 호출

        int minusResult = MinusMenthod(); // 함수 호출

        // Debug.Log(AddMethod());
        // Debug.Log(MinusMenthod());

        Debug.Log($"더한 값 : {addResult} / 뺀 값: {minusResult}");
    }

    int AddMethod()
    {
        // 지역 변수 result
        int result = number1 + number2;

        return result;
    }

    int MinusMenthod()
    {
        // 지역 변수 result
        int result = number1 - number2;

        return result;
    }

}
