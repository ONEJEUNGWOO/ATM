using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedMoneyUI : MonoBehaviour
{
    [SerializeField] private Button enterButton;

    public Button EnterButton { get { return enterButton; } set { enterButton = value; } }

    private void Awake()
    {
        EnterButton.onClick.AddListener(Close);
    }

    private void Close()
    {
        UIManager.Instance.CloseNeedMoneyUI();
    }
}
