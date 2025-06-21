using UnityEngine;

public class Potions : MonoBehaviour, IItem
{
    private Inventory inventory;

    public enum PotionType {Hp }
    public PotionType potionType;
        
    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();

        Obj = gameObject;
    }

    void OnMouseDown()
    {
        Get();
    }
    public GameObject Obj { get; set; }

    public void Get()
    {
        Debug.Log($"{this.name}¿ª »πµÊ«ﬂΩ¿¥œ¥Ÿ.");
        inventory.AddItem( this );
        gameObject.SetActive(false);
    }




}
