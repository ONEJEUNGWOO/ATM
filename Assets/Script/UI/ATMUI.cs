using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATMUI : MonoBehaviour
{
    [SerializeField] private Text cashText;

    public void SetData(int cash)
    {
        cashText.text = $"Çö±Ý\n{cash.ToString("N0")}";
    }
}
