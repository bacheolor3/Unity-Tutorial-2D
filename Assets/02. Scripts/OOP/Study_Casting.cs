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

        // 다운 캐스팅
        //Monster m5 = new Monster();
        //FlyingEye o2 = (FlyingEye)m5;

        //Debug.Log(o2);

        // 업 캐스팅
        // 명시적 형변환
        Monster m1 = (Monster) o;
        //Monster m2 = (Monster) g;

        // 암시적 형변환
        //Monster m3 = o;
        //Monster m4 = g;
        
        //monsters.Add(o);
        //monsters.Add(g);
    }
}
