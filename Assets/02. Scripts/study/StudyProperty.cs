using Cat;
using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    [Header("�ӵ�")]
    // ����ȭ �ϴ�
    [SerializeField] public float moveSpeed = 10f;


    [Space(10)]
    [Header("�ӵ�2")]
    [Range(0f, 10f)]
    [field: SerializeField]
    private float moveSpeed2 = 10f;
    public float MoveSpeed2
    {
        get { return moveSpeed2; }
        set { moveSpeed2 = value; }
    }

    //private int number1 = 10;
    //public int Number1
    //{
    //    get { return number1;}
    //    set { number1 = value;}
    //}

    //public int Number2 { get; set; } = 20; //���� �Ͱ� ����. �ٸ��� �� ����
    //public int Number3 { get; private set; } = 30; // ��/�ܺο����� ���� ����/ ���ο����� ���� ����


    //private float hp = 100f;
    //public float Hp
    //{
    //    get { return hp; }

    //    set
    //    {
    //        if(value < 0)
    //        {
    //            hp = 0;
    //            Death();
    //        }
    //        else
    //        {
    //            hp = value;
    //        }
    //    }
    //}

    //public float mp = 100f;

    //private SoundManager soundManager;
    //public SoundManager SoundManager
    //{
    //    get 
    //    {
    //        if(soundManager == null)
    //        {
    //            soundManager = FindFirstObjectByType<SoundManager>();
    //        }

    //        return soundManager;
    //    }
        
    //}

    //public void Death()
    //{
    //    Debug.Log("���� ����");
    //}

}
