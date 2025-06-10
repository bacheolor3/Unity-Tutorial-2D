using System.Collections.ObjectModel;
using UnityEngine;

public class Study_ForEach : MonoBehaviour
{
    public string[] persons = new string[5] {"철수", "영희", "동수", "마이클", "존"};

    public string findName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindPerson(findName);
    }
    
    private void FindPerson(string name)
    {
        bool isFind = false;
        foreach(var person in persons)
        {
            if (person == name)
            {
                isFind = true;
                Debug.Log($"인원 중에 {name}이 존재합니다.");
            }
            
        }
        if (!isFind)
        {
            Debug.Log($"{name}을 찾지 못했습니다");
        }
    }

}
