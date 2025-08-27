using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private ATMUI atmUI;
    [SerializeField] private MenuUI menuUI;
    [SerializeField] private UserInfoUI userInfoUI;
    [SerializeField] private DepositUI depositUI;
    [SerializeField] private WithdrawlUI withdrawlUI;
    [SerializeField] private NeedMoneyUI needMoneyUI;

    public ATMUI ATMUI { get { return atmUI; } set { atmUI = value; } }
    public MenuUI MenuUI { get { return menuUI; } set { menuUI = value; } }
    public UserInfoUI UserInfoUI { get { return userInfoUI; } set { userInfoUI = value; } }
    public DepositUI DepositUI { get { return depositUI; } set { depositUI = value; } }
    public WithdrawlUI WithdrawlUI { get { return withdrawlUI; } set { withdrawlUI = value; } }
    public NeedMoneyUI NeedMoneyUI { get { return needMoneyUI; } set { needMoneyUI = value; } }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        GameManager gm = GameManager.Instance;

        ATMUI.CashText.text = $"Çö±Ý\n{gm.userData.cash.ToString("N0")}";
        UserInfoUI.UserMoneyText.text = $"Banlance      {gm.userData.balance.ToString("N0")}";
        UserInfoUI.UserNameText.text = gm.userData.name;
    }

    public void OpenMainMenuUI()
    {
        MenuUI.InCashButton.gameObject.SetActive(true);
        MenuUI.OutCashButton.gameObject.SetActive(true);

        DepositUI.gameObject.SetActive(false);
        WithdrawlUI.gameObject.SetActive(false);
    }

    public void OpenDepositUI()
    {
        MenuUI.InCashButton.gameObject.SetActive(false);
        MenuUI.OutCashButton.gameObject.SetActive(false);

        DepositUI.gameObject.gameObject.SetActive(true);
    }

    public void OpenWithdrawlUI()
    {
        MenuUI.InCashButton.gameObject.SetActive(false);
        MenuUI.OutCashButton.gameObject.SetActive(false);

        WithdrawlUI.gameObject.gameObject.SetActive(true);
    }

    public void OpenNeedMoneyUI()
    {
        NeedMoneyUI.gameObject.SetActive(true);
    }

    public void CloseNeedMoneyUI()
    {
        NeedMoneyUI.gameObject.SetActive(false);
    }

    public void AddMoney(int Cash)
    {
        if (Cash > GameManager.Instance.userData.cash)
        {
            OpenNeedMoneyUI();
            return;
        }

        GameManager.Instance.userData.cash -= Cash;
        GameManager.Instance.userData.balance += Cash;

        Refresh();
        GameManager.Instance.SaveUserData();
    }

    public void RemoveMoney(int Cash)
    {
        if (Cash > GameManager.Instance.userData.balance)
        {
            OpenNeedMoneyUI();
            return;
        }

        GameManager.Instance.userData.cash += Cash;
        GameManager.Instance.userData.balance -= Cash;

        Refresh();
        GameManager.Instance.SaveUserData();
    }
}
