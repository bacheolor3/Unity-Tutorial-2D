using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string msg = currentLevel >= maxLevel ? "ÇöÀç ¸¸·¾ÀÔ´Ï´Ù." : "ÇöÀç ¸¸·¾ÀÌ ¾Æ´Õ´Ï´Ù.";

        int LevelPoint = currentLevel >= maxLevel ? 0 : 1;

        currentLevel += LevelPoint;

        Debug.Log(msg);
    }

}
