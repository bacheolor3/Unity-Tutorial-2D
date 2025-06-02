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
        h = Input.GetAxis("Horizontal"); // 키 입력

        Jump();

        // 트랜스폼 이동
        // transform.position~~
        // transform.Translate(~)

        // 리지드바디 이동
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

        if(h != 0) // 움직일 때
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run
            // 리지드바디 이동
            characterRb.linearVelocityX = h * moveSpeed; // 물리적인 이동

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
        else // 안움직일 때
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
        }
        
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump")) // Input.GetKeyDown(KeyCode.Space)와 같은 기능
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            //renderers[0].gameObject.SetActive(false); // Idle
            //renderers[1].gameObject.SetActive(false); // Run
            /*renderers[2].gameObject.SetActive(true);*/ // Jump
        }
    }

}
