using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { Pipe, Apple, Both}
    public ColliderType colliderType;
    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;

    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    private void Start()
    {
        SetRandomSetting(transform.position.x);
        //randomPosY = Random.Range(-8, -3);
        //transform.position = new Vector3(transform.position.x, randomPosY, 0.3f);
    }


    // Update is called once per frame
    void Update()
    {
        // 배경을 왼쪽으로 이동하는 기능
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        if (transform.position.x <= -returnPosX)
        {
            SetRandomSetting(returnPosX);
            //randomPosY = Random.Range(-8f, -2.5f);

            //transform.position = new Vector3(returnPosX, randomPosY, 0.3f);
        }
    }

    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-8f, -3.5f);
        transform.position = new Vector3(posX, randomPosY, 0.3f);

        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3);



        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.Apple:
                apple.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;

        }
    }
}
