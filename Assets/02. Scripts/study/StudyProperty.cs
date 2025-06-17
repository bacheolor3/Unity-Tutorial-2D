using Cat;
using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    [Header("속도")]
    // 직렬화 하다
    [SerializeField] public float moveSpeed = 10f;


    [Space(10)]
    [Header("속도2")]
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

    //public int Number2 { get; set; } = 20; //위의 것과 같음. 다른건 값 정도
    //public int Number3 { get; private set; } = 30; // 내/외부에서만 접근 가능/ 내부에서만 수정 가능


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
    //    Debug.Log("몬스터 죽음");
    //}

}
