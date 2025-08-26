using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfoUI : MonoBehaviour
{
    [SerializeField] private Text userNameText;
    [SerializeField] private Text userMoneyText;

    public Text UserNameText { get { return userNameText; } set { userNameText = value; } }
    public Text UserMoneyText { get { return userMoneyText; } set { userMoneyText = value; } }


}
