using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    private float h;

    // Update is called once per frame
    void Update() // 성능에 따라 다른 프레임으로 실행되는 유니티 기본 함수(항상 실행되고 있음) 컴 성능 좋을수록 빠름. 보통 키입력을 여기에
    {
        h = Input.GetAxis("Horizontal");
        
        // transform(순간이동 방식)이동
        // transform.position += Vector3.right * h * moveSpeed * Time.deltaTime; 

    }

    private void FixedUpdate() // 고정 프레임으로 실행되는 유니티 기본 함수(입력 등 변화를 감지했을 때 작용) 물리엔진 등 물리적인 작용을 여기에
    {
        
        // Rigidbody 이동
        carRb.linearVelocityX = h * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //other.gameObject.SetActive(false);
        Debug.Log("Collision Enter");
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        //other.gameObject.SetActive(false);
        Debug.Log("Collision Stay");
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        //other.gameObject.SetActive(false);
        Debug.Log("Collision Exit");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger Stay");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger Exit");
    }
}
