using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Study_Casting : MonoBehaviour
{
    List<FlyingEye> orcs = new List<FlyingEye>();
    List<Goblin> goblins = new List<Goblin>();

    List<Monster> monsters = new List<Monster>();
    private void Start()
    {
        FlyingEye o = new FlyingEye();
        Goblin g = new Goblin();

        // �ٿ� ĳ����
        //Monster m5 = new Monster();
        //FlyingEye o2 = (FlyingEye)m5;

        //Debug.Log(o2);

        // �� ĳ����
        // ����� ����ȯ
        Monster m1 = (Monster) o;
        //Monster m2 = (Monster) g;

        // �Ͻ��� ����ȯ
        //Monster m3 = o;
        //Monster m4 = g;
        
        //monsters.Add(o);
        //monsters.Add(g);
    }
}
