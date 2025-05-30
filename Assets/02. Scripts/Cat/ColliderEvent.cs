using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
            Debug.Log("Collision Enter");
        //if (other.gameObject.CompareTag("Player"))
        //{
        //}

    }
    public void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Collision Stay");
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Collision Exit");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger Stay");
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger Exit");
    }

}
