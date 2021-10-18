using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public static double moneyCount;
    public static double investMoneyCount;
    public static double maxWalletSize = 100;
    public static double indexManualIncome = 1;
    public double _indexManualIncome;
    public static double indexAutoIncome = 0;
    public double _indexAutoIncome;

    public static int smallBusenessCount = 0;
    public static int mediumBusinessCount = 0;
    public static int largeBusinessCount = 0;

    // Update is called once per frame
    void Update()
    {
        _indexAutoIncome = indexAutoIncome;
        _indexManualIncome = indexManualIncome;
    }
}
