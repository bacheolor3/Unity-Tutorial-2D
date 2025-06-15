using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Study_Casting : MonoBehaviour
{
    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();

    List<Monster> monsters = new List<Monster>();
    private void Start()
    {
        Orc o = new Orc();
        Goblin g = new Goblin();

        // 다운 캐스팅
        Monster m5 = new Monster();
        Orc o2 = (Orc)m5;

        Debug.Log(o2);

        // 업 캐스팅
        // 명시적 형변환
        Monster m1 = (Monster) o;
        Monster m2 = (Monster) g;

        // 암시적 형변환
        Monster m3 = o;
        Monster m4 = g;
        
        monsters.Add(o);
        monsters.Add(g);
    }
}
