using UnityEngine;

public class GunmanCharacterMovement : MonoBehaviour
{
    private Rigidbody2D characterRb;

    public SpriteRenderer[] renderers;

    public GameObject[] renderObjs;

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;

    private bool isGround;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal"); // Ű �Է�

        Jump();

        // Ʈ������ �̵�
        // transform.position~~
        // transform.Translate(~)

        // ������ٵ� �̵�
        // characterRb.linearVelocityX = h * moveSpeed;
    }

    private void FixedUpdate()
    {
        
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;
        
        renderers[2].gameObject.SetActive(false); // Jump
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround= false;
        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true); // Jump
    }

    private void Move()
    {
        if (!isGround)
            return;

        if(h != 0) // ������ ��
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run
            // ������ٵ� �̵�
            characterRb.linearVelocityX = h * moveSpeed; // �������� �̵�

            if(h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else if (h < 0)
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }

        }
        else // �ȿ����� ��
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
        }
        
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump")) // Input.GetKeyDown(KeyCode.Space)�� ���� ���
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            //renderers[0].gameObject.SetActive(false); // Idle
            //renderers[1].gameObject.SetActive(false); // Run
            /*renderers[2].gameObject.SetActive(true);*/ // Jump
        }
    }

}
