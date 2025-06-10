using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Study_For : MonoBehaviour
{
    // public int[] arrayInt = new int[5];
    // public List<int> listInt = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        for(int i = 0; i < 3; i++)
        {
            for(int j =0; j <3; j++)
            {
                Debug.Log($"{i} / {j}");
            }
        }
    }

    
}
