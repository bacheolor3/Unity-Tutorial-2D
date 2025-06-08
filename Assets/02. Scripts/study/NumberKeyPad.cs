using UnityEngine;


public class NumberKeyPad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorLock;
    public string password;
    public string keyPadNumber;
    

    public void OnInputNumber(string numString)
    {
        keyPadNumber += numString;
        // KeyPadNumber = KeyPadNumber + numString;

        Debug.Log($"{numString}입력 -> 현재 입력 : {keyPadNumber}");
    }
    public void OnCheckNumber()
    {
        if(keyPadNumber == password)
        {
            Debug.Log("문 열림");
            doorAnim.SetTrigger("Door Open");
            
            doorLock.SetActive(false);
        }
        else
        {
            Debug.Log("비밀 번호 오류");
            keyPadNumber = "";
        }
    }
}
