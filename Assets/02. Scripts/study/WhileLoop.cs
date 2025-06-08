using System.Threading;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (count<10)
        {
            count++;
            Debug.Log($"현재 {count}입니다");
            if(count == 5)
            {
                break;
            }
        } ;
    }

}
