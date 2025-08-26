using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawlUI : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button money_1_Button;
    [SerializeField] private Button money_3_Button;
    [SerializeField] private Button money_5_Button;

    public Button BackButton { get { return backButton; } set { backButton = value; } }
    public Button Money_1_Button { get { return money_1_Button; } set { money_1_Button = value; } }
    public Button Money_3_Button { get { return money_3_Button; } set { money_3_Button = value; } }
    public Button Money_5_Button { get { return money_5_Button; } set { money_5_Button = value; } }

    private void Start()
    {
        BackButton.onClick.AddListener(BackToMainUI);
    }

    public void BackToMainUI()
    {
        UIManager.Instance.OpenMainMenuUI();
    }
}
