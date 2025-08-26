using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button inCashButton;
    [SerializeField] private Button outCashButton;

    public Button InCashButton { get { return inCashButton; } set { inCashButton = value; } }
    public Button OutCashButton { get { return outCashButton; } set { outCashButton = value; } }

    private void Start()
    {
        InCashButton.onClick.AddListener(OpenInCash);
        OutCashButton.onClick.AddListener(OpenOutCash);
    }

    public void OpenInCash()
    {
        UIManager.Instance.OpenDepositUI();
    }

    public void OpenOutCash()
    {
        UIManager.Instance.OpenWithdrawlUI();
    }
}
