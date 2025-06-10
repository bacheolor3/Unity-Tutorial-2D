using UnityEngine;
using Cat;
using Unity.VisualScripting; // 사운드 매니저가 있는 namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // public 으로 설정했기 때문에 유니티 상에서 할당 예정

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happyVideo;
    public GameObject sadVideo;

    private Rigidbody2D catRb;
    private Animator catAnim;

    public int jumpCount = 0;
    public float jumpPower = 30f;
    public float limitPower = 25f;

    public bool isGround = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount< 5) // 아무것도 안 적으면 isGround == true란 뜻 + 점프를 2단 까지만 가능하게 하는것
        {
            catAnim.SetTrigger("Jump");
            catAnim.SetBool("isGround", false);
            // 점프 = y 축 방향으로 이동 X
                                                        // 순간적으로 힘을 가하는 방식 = Impulse
            jumpCount++; // 점프 할때마다 1 씩 증가.
            soundManager.OnJumpSound();            
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);

            if (catRb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
                catRb.linearVelocityY = limitPower;

            //if (catRb.linearVelocityY) ;

        }

        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocity.y * 2.5f;
        transform.eulerAngles = catRotation;

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);
            GameManager.score++;

            if(GameManager.score == 5) // 사과를 5개 먹어서 성공
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white);
                this.GetComponent<CircleCollider2D>().enabled = false;
                Invoke("HappyVideo", 5f);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Pipe"))
        {
            soundManager.OnColliderSound();
            // Fade or Outro or Game End UI

            gameOverUI.SetActive(true); // 게임 오버 켜기
            fadeUI.SetActive(true); // 페이드 켜기
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black); // 페이드 실행
            this.GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 5f);
        }

        if (other.gameObject.CompareTag("Ground") )
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
            //isGround = true;
        }
    }

    //private void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Ground"))
    //    {
    //        isGround = false;
    //    }
    //}
    private void HappyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    private void SadVideo()
    {
        sadVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
}
