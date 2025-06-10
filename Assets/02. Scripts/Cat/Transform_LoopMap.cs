using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float returnPosX = 15f;

    public float randomPosY;

    private void Start()
    {
        randomPosY = Random.Range(-8, -3);
        transform.position = new Vector3(transform.position.x, randomPosY, 0);
    }


    // Update is called once per frame
    void Update()
    {
        // ����� �������� �̵��ϴ� ���
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        
        if(transform.position.x <= -returnPosX) 
        {
            randomPosY = Random.Range(-8f, -2.5f);

            transform.position = new Vector3(returnPosX, randomPosY, 0.3f);
        }
    }
}
