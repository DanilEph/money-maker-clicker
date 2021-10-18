using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GlobalMoney;

public class InvestMoney : MonoBehaviour
{
    public GameObject statusBar;
    public GameObject statusText;
    public void ClickButton()
    {
        if (moneyCount > 0)
        {            
            investMoneyCount += moneyCount;            
            statusText.GetComponent<Text>().text = $"{moneyCount} money has been invested!";
            moneyCount = 0;
            statusBar.GetComponent<Animation>().Play("StatusAnim");

        }
        else
        {
            statusText.GetComponent<Text>().text = "Not enough money to invest!";
            statusBar.GetComponent<Animation>().Play("StatusAnim");
        }
    }
}
