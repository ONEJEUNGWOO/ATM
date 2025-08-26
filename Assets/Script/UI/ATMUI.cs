using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATMUI : MonoBehaviour
{
    [SerializeField] private Text cashText;

    public Text CashText { get { return cashText; } set { cashText = value; } }
}
