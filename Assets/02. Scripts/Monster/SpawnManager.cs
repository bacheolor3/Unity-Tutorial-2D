using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    // 이미 정해진 개수가 있는 경우
    [SerializeField] private GameObject[] monsters;  // 몬스터 종류가 이미 정해진 상태

    private List<Monster> monsterList = new List<Monster>();

    // [SerializeField] private GameObject coinPrefab;
    [SerializeField] private GameObject[] items;

    // n초마다 몬스터를 랜덤으로 생성하는 기능

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-8, 9);
            var randomY = Random.Range(-3, 5);

            var createPos = new Vector3(randomX, randomY, 0);
            GameObject monster = Instantiate(monsters[randomIndex], createPos, Quaternion.identity);  // 몬스터를 생성하는 기능 -> 원점 생성

            monsterList.Add(monster.GetComponent<Monster>());
            Debug.Log($"현재 몬스터 수 : {monsterList.Count}");

            int ranDir = Random.Range(0, 2) > 0 ? 1 : -1;
            // int ranDir = ranInt >  0 ? 1 : -1;
            monster.GetComponent<Monster>().Dir = ranDir;
            monster.GetComponent<Monster>().SetFlip(ranDir);
        }
    }

    //public void OnSpawnMonster()
    //{
    //    StartCoroutine(SpawnRoutine());
    //}

    public void DropItems(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length); // 랜덤 인덱스 생성
        
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity); // 아이템 생성

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        // itemRb.AddForce(new Vector3(Random.Range(-2f,2f),3f), ForceMode2D.Impulse);
        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);


        float ranPower = Random.Range(-1.5f, 2f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }
    
    //private float timer = 0f;

    //private void Update()
    //{
    //    timer += Time.deltaTime;

    //    if(timer >= 3f)
    //    {
    //        timer = 0f;
    //        몬스터 생성
    //    }
    //}
}
