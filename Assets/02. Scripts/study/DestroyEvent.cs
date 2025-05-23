using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destoryTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destoryTime); // �ڱ� �ڽ��� 3�� �ڿ� �ı��ϴ� ���

    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
        
    }

}
