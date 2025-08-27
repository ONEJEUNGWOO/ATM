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

    public void AddMoney(int money)
    {
        cash -= money;
        balance += money;
    }

    public void AddCash(int cash)
    {
        GameManager.Instance.userData.cash += cash;
        GameManager.Instance.userData.balance -= cash;
    }
}
