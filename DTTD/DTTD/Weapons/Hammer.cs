﻿
using System;

public class Hammer : IUnit
{
    private int attackPoints;
    private IUnit owner;

    public Hammer(int attackPoints)
    {
        this.attackPoints = attackPoints;
        this.Owner = owner;
    }

    public int AttackPoints
    {
        get
        {
            return this.attackPoints;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("AttackPoints can not be negative!");
            }

            this.attackPoints = value;
        }
    }

    public IUnit Owner
    {
        get
        {
            return this.owner;
        }

        set
        {
            if (value == null)
            {
                throw new NullReferenceException("Owner can not be null!");
            }

            this.Owner = value;
        }
    }
}

