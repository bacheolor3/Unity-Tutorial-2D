using UnityEngine;

public class Character : MonoBehaviour
{
    public IDropItem currentItem;
    [SerializeField] private Transform grabPos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }

        if (Input.GetKeyDown(KeyCode.B)) 
        {
            currentItem.Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if(other.GetComponent<IDropItem>() != null)
        {
            IDropItem item = other.GetComponent<IDropItem>();

            item.Grab(grabPos); //æ∆¿Ã≈€ »πµÊ
                        
            currentItem = item;
        }

        //if(other.CompareTag("Flash Light"))
        //{
        //    other.GetComponent<FlashLight>().FlashOn();
        //}
        //else if (other.CompareTag("Gun"))
        //{
        //    other.GetComponent<Gun>().Shoot();
        //}
        //else if (other.CompareTag("Key"))
        //{

        //}
    }
}
