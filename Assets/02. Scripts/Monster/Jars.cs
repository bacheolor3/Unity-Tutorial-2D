using UnityEngine;

public class Jars : MonoBehaviour, IItem
{
    private Inventory inventory;

    public enum JarType {Gold, Blue}
    public JarType jarType;

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
        Debug.Log($"{this.name}¿ª »πµÊ«ﬂΩ¿¥œ¥Ÿ");
        inventory.AddItem( this );
        gameObject.SetActive( false );
    }
}
