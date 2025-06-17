using System.Collections;
using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    public StudyProperty studyProperty;

    private void Start()
    {
        // studyProperty.moveSpeed = 100f;

        //int num1 = studyProperty.Number1; // private 필드에 접근
        //studyProperty.Number1 = 100; 

        //int num2 = studyProperty.Number2; // public 필드에 접근
        //studyProperty.Number2 = 200;

        //int num3 = studyProperty.Number3;
        ////studyProperty.Number3 = 300;
    }

    
}