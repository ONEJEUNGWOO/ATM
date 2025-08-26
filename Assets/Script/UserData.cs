using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class UserData
{
    public string name;
    public int balance;
    public int cash;

    public UserData(string Name, int Balance, int Cash)
    {
        name = Name;
        balance = Balance;
        cash = Cash;
    }
}
