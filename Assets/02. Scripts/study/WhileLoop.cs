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
            Debug.Log($"���� {count}�Դϴ�");
            if(count == 5)
            {
                break;
            }
        } ;
    }

}
