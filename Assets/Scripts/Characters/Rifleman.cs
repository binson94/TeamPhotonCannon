using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifleman : PlayerController
{
    public override void IsAttack()
    {

    }
    public override void IsSkill()
    {

    }
    
    protected override void init()
    {

        _myClass = Define.Charcter.Rifleman;
        MaxHP = 98754321.0f;
        MoveSpeed = 10.0f;
        AttackDMG = 10.0f;
        Position = Vector2.zero;// ������ġ
    }
}
