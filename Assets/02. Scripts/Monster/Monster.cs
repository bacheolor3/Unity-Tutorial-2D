using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;


using static UnityEngine.RuleTile.TilingRuleOutput;
public abstract class Monster : MonoBehaviour
{
    public SpawnManager spawner;

    public SpriteRenderer sRenderer;
    private Animator animator;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    private int dir = 1;
    public int Dir
    {
        get { return dir; }
        set { dir = value; }
    }

    private bool isMove = true;
    private bool isHit = false;

    public abstract void Init();

    private void Start()
    {
        spawner = FindFirstObjectByType<SpawnManager>();
        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Init();
    }

    void OnMouseDown()
    {
        // Hit(1);
        if(!isHit)
            StartCoroutine(Hit(1));
    }
    
    void Update()
    {
        Move();
    }
    /// <summary>
    /// 몬스터가 움직이는 기능
    /// </summary>
    void Move()
    {
        if (!isMove)
            return;

        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            // sRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            // sRenderer.flipX = false;
        }

        SetFlip(dir);
    }

    public void SetFlip(int dir)
    {
        if(dir > 0)
        {
            sRenderer.flipX = false;
        }
        else
        {
            sRenderer.flipX = true;
        }
    }

    /// <summary>
    /// 몬스터가 공격 받았을 때 로직
    /// </summary>
    /// <param name="damage"></param>
    /// <returns></returns>
    IEnumerator Hit(float damage)
    {
        //if (isHit)
        //    yield break;

        isHit = true;
        isMove = false;

        hp -= damage;

        if (hp <= 0)
        {
            // Debug.Log("몬스터 죽음");
            // Destroy(gameObject);
            animator.SetTrigger("Death");
            spawner.DropItems(transform.position); // 해당 위치에 코인 생성

            yield return new WaitForSeconds(3f);
            gameObject.SetActive(false);

            yield break;
        }

        animator.SetTrigger("Hit");

        yield return new WaitForSeconds(0.5f);

        isMove = true;
        isHit = false;
    }

   
}
