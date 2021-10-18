using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalMoney;

public class AutoMoney : MonoBehaviour
{
    public bool makingMoney = false;

    // Update is called once per frame
    void Update()
    {
        if (!makingMoney && moneyCount <= maxWalletSize)
        {
            makingMoney = true;
            StartCoroutine(MakeSomeMoney());
        }
    }

    IEnumerator MakeSomeMoney()
    {       
        moneyCount += indexAutoIncome;
        yield return new WaitForSeconds(1);
        makingMoney = false;
    }
}
