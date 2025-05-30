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
        // �����̽� Ű �Է�
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount< 2) // �ƹ��͵� �� ������ isGround == true�� �� + ������ 2�� ������ �����ϰ� �ϴ°�
        {
            // ���� = y �� �������� �̵� X
                                                        // ���������� ���� ���ϴ� ��� = Impulse
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++; // ���� �Ҷ����� 1 �� ����.
                                               
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
