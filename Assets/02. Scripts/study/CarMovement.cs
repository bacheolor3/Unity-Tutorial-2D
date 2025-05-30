using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    private float h;

    // Update is called once per frame
    void Update() // ���ɿ� ���� �ٸ� ���������� ����Ǵ� ����Ƽ �⺻ �Լ�(�׻� ����ǰ� ����) �� ���� �������� ����. ���� Ű�Է��� ���⿡
    {
        h = Input.GetAxis("Horizontal");
        
        // transform(�����̵� ���)�̵�
        // transform.position += Vector3.right * h * moveSpeed * Time.deltaTime; 

    }

    private void FixedUpdate() // ���� ���������� ����Ǵ� ����Ƽ �⺻ �Լ�(�Է� �� ��ȭ�� �������� �� �ۿ�) �������� �� �������� �ۿ��� ���⿡
    {
        
        // Rigidbody �̵�
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
