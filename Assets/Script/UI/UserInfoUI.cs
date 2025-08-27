using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfoUI : MonoBehaviour
{
    [SerializeField] private Text userNameText;
    [SerializeField] private Text userMoneyText;


    public void SetData(string userName, int money)
    {
        userNameText.text = userName;   
        userMoneyText.text = $"Banlance      {money.ToString("N0")}";
    }
}
