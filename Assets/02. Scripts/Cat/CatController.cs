using Cat;
using System.Collections; // 사운드 매니저가 있는 namespace
using Unity.VisualScripting;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // public 으로 설정했기 때문에 유니티 상에서 할당 예정
    public VideoManager videoManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    //public GameObject happyVideo;
    //public GameObject sadVideo;

    private Rigidbody2D catRb;
    private Animator catAnim;

    public int jumpCount = 0;
    public float jumpPower = 30f;
    public float limitPower = 25f;

    public bool isGround = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() // 한 번만 실행
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    private void OnEnable() // 켜질때마다 1번씩 실행
    {
        transform.localPosition = new Vector3(-7f, -2f, 0f);
        GetComponent<CircleCollider2D>().enabled = true;
        soundManager.audioSource.Play();
        // soundManager.audioSource.mute = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        
    }

    private void Jump()
    {
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5) // 아무것도 안 적으면 isGround == true란 뜻 + 점프를 2단 까지만 가능하게 하는것
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
                fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white, true);
                this.GetComponent<CircleCollider2D>().enabled = false;
                // Invoke("HappyVideo", 5f);

                StartCoroutine(EndingRoutine(true));
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
            fadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black, true); // 페이드 실행
            this.GetComponent<CircleCollider2D>().enabled = false;
            // Invoke("SadVideo", 5f);

            StartCoroutine(EndingRoutine(false));
        }

        if (other.gameObject.CompareTag("Ground") )
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
            //isGround = true;
        }
    }

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(3.5f);

        videoManager.VideoPlay(isHappy); // 영상 재생 시작
        yield return new WaitForSeconds(1f);
        Debug.Log("영상 재생 시작");

        var newColor = isHappy ? Color.white : Color.black;
        fadeUI.GetComponent<FadeRoutine>().OnFade(3f, newColor, false); // 페이드 실행
        Debug.Log("페이드 해제중");

        yield return new WaitForSeconds(3f);
        soundManager.audioSource.Stop();
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        // soundManager.audioSource.mute = true; 음소거
        Debug.Log("영상 재생 완료");

        transform.parent.gameObject.SetActive(false);        // PLAY 그룹 오브젝트를 OFF
    }

    //private void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Ground"))
    //    {
    //        isGround = false;
    //    }
    //}
    //private void HappyVideo()
    //{
    //    videoManager.VideoPlay(true);

    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}

    //private void SadVideo()
    //{
    //    videoManager.VideoPlay(false);

    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}
}
