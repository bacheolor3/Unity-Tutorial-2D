using UnityEngine;

public class Coins : MonoBehaviour, IItem
{
    private Inventory inventory;

    public enum CoinType { Gold, Green, Blue }
    public CoinType coinType;

    public float price;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        Debug.Log($"{this.name}�� ȹ���߽��ϴ�");

        inventory.AddItem(this);

        gameObject.SetActive(false);
    }
}
