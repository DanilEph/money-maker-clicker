using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalMoney;

public class MakeMoney : MonoBehaviour
{
    public void ClickButton()
    {
        if (moneyCount <= maxWalletSize)
        {
            moneyCount += indexManualIncome;
        }
    }
}
