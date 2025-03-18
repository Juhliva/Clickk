using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
    float TotalClicks;
    public float minimumClicksToUnlockUpgrade;
    public int amount;
    public int autoClicksPerSecond;
    public TextMeshProUGUI ClicksTotalText;
    public UpdateClick clicker;

    private void Update()
    {
        if (amount > 0)
        {
            clicker.Click += autoClicksPerSecond * amount * Time.deltaTime;
        }
    }
    public void autoClickUpgrade()
    {
        if (clicker.Click >= minimumClicksToUnlockUpgrade)
        {
            clicker.Click -= minimumClicksToUnlockUpgrade;
            amount++;
        }
    }
}
