using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GlobalMoney;

public class Investing : MonoBehaviour
{
    public GameObject smallBusinessBtn;
    public GameObject smallBusinessText;
    private double smallBusinessPrice = 50;

    public GameObject mediumBusinessBtn;
    public GameObject mediumBusinessText;
    private double mediumBusinessPrice = 1000;

    public GameObject largeBusinessBtn;
    public GameObject largeBusinessText;
    private double largeBusinessPrice = 10000;

    public GameObject autoMoney;

    public GameObject investYourselfBtn;
    public GameObject investYourselfText;
    public double investYourselfPrice = 30;

    public void SmallBusinessClick()
    {
        if (investMoneyCount >= smallBusinessPrice)
        {
            smallBusenessCount += 1;
            investMoneyCount -= smallBusinessPrice;
            smallBusinessPrice *= 2;
            indexAutoIncome = indexAutoIncome != 0 ? indexAutoIncome * 2 : 1;           
        }
        else
        {

        }
    }
    public void MediumBusinessClick()
    {
        if (investMoneyCount >= mediumBusinessPrice)
        {
            mediumBusinessCount += 1;
            investMoneyCount -= mediumBusinessPrice;
            mediumBusinessPrice *= 4;
            indexAutoIncome = indexAutoIncome != 0 ? indexAutoIncome * 4 : 1;
        }
        else
        {

        }
    }
    public void LargeBusinessClick()
    {
        if (investMoneyCount >= largeBusinessPrice)
        {
            largeBusinessCount += 1;
            investMoneyCount -= largeBusinessPrice;
            largeBusinessPrice *= 8;
            indexAutoIncome = indexAutoIncome != 0 ? indexAutoIncome * 8 : 1;
        }
        else
        {

        }
    }
    public void YourselfInvestClick()
    {
        if (investMoneyCount >= investYourselfPrice)
        {
            investMoneyCount -= investYourselfPrice;
            investYourselfPrice *= 2;
            indexManualIncome *= 2;
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        smallBusinessText.GetComponent<Text>().text = $"Invest in small business \n({smallBusinessPrice} bitcoins)";
        mediumBusinessText.GetComponent<Text>().text = $"Invest in medium business \n({mediumBusinessPrice} bitcoins)";
        largeBusinessText.GetComponent<Text>().text = $"Invest in large business \n({largeBusinessPrice} bitcoins)";

        investYourselfText.GetComponent<Text>().text = $"Invest in yourself \n({investYourselfPrice} bitcoins)";
    }
}
