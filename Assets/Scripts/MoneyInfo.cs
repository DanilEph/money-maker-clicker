using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GlobalMoney;

public class MoneyInfo : MonoBehaviour
{

    public GameObject moneyDisplay;
    public GameObject investMoneyDisplay;
    public GameObject passiveIncomeDisplay;
    public GameObject activeIncomeDisplay;
    public GameObject smallBusisDisplay;
    public GameObject mediumBusisDisplay;
    public GameObject largeBusisDisplay;

    // Update is called once per frame
    void Update()
    {
        moneyDisplay.GetComponent<Text>().text = "Money: " + moneyCount;
        investMoneyDisplay.GetComponent<Text>().text = "Money in bank: " + investMoneyCount;
        passiveIncomeDisplay.GetComponent<Text>().text = $"Passive income: {indexAutoIncome}/sec";
        activeIncomeDisplay.GetComponent<Text>().text = $"Active income: {indexManualIncome}/click";
        smallBusisDisplay.GetComponent<Text>().text = $"Small businesses: {smallBusenessCount}";
        mediumBusisDisplay.GetComponent<Text>().text = $"Medium businesses: {mediumBusinessCount}";
        largeBusisDisplay.GetComponent<Text>().text = $"Large businesses: {largeBusinessCount}";

    }
}
