using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 10f;
    public bool isGround = false;

    public int jumpCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount< 2) // 아무것도 안 적으면 isGround == true란 뜻 + 점프를 2단 까지만 가능하게 하는것
        {
            // 점프 = y 축 방향으로 이동 X
                                                        // 순간적으로 힘을 가하는 방식 = Impulse
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++; // 점프 할때마다 1 씩 증가.
                                               
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") )
        {
            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
