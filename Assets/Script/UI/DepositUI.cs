using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DepositUI : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button money_1_Button;
    [SerializeField] private Button money_3_Button;
    [SerializeField] private Button money_5_Button;
    [SerializeField] private Button enterButton;
    [SerializeField] private TMP_InputField inputField;

    public Button BackButton { get { return backButton; } set { backButton = value; } }
    public Button Money_1_Button { get { return money_1_Button; } set { money_1_Button = value; } }
    public Button Money_3_Button { get { return money_3_Button; } set { money_3_Button = value; } }
    public Button Money_5_Button { get { return money_5_Button; } set { money_5_Button = value; } }
    public Button EnterButton { get { return enterButton; } set { enterButton = value; } }
    public TMP_InputField InputField { get { return inputField; } set { inputField = value; } }
    
    private void Start()
    {
        BackButton.onClick.AddListener(BackToMainUI);
        EnterButton.onClick.AddListener(EnterButtonClickTOAddMoney);
    }

    public void BackToMainUI()
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void AddMoney(int cash)  //�ν����Ϳ��� ���� �ϴ� ������ �־ �״�� �߽��ϴ�.
    {
        UIManager.Instance.AddMoney(cash);
    }

    public void EnterButtonClickTOAddMoney()
    {
        if (int.TryParse(InputField.text, out int cash))
        {
            if (cash < 0) return;

            AddMoney(cash);
            //InputField.text = ""; ���ǿ����� ���� �ʱ�ȭ �Ǵ� �κ��� ��� �켱 ������ �� �ξ����ϴ�.
        }
    }
}
