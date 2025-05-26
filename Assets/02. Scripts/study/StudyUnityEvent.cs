using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    private int i = 1;
    private void Awake()
    {
        Debug.Log($"Awake : { i++}");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Start : {i++}");
    }

    private void OnEnable() // 켜질 때 마다 1번 실행
    {
        Debug.Log($"OnEnalbe : {i++}");
    }

    private void OnDisable() // 꺼질 때 마다 1번 실행
    {
        Debug.Log($"OnDisable : {i++}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
