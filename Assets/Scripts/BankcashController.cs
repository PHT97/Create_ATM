using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BankcashController : MonoBehaviour
{
    public int bankMoney = 50000;
    public string _bankMoney;
    public int buttonnum;
    public int selfMoney;

    public TMP_Text BankMoney;
    public MycashController mycashController;
    public DelayPopUp delayPopup;
    public TMP_InputField outputmoney;

    void Start()
    {
        BankCash();
    }
    private void BankCash()
    {
        ShowMoney();
    }
    public void ShowMoney()
    {
        _bankMoney = string.Format("{0:#,0}", bankMoney);
        BankMoney.text = _bankMoney;
    }
    public void InputMoney()
    {
        buttonnum = InputMoneyButtonController.num;
        switch (buttonnum)
        {
            case 1:
                bankMoney += 10000;
                ShowMoney();
                break;
            case 2:
                bankMoney += 30000;
                ShowMoney();
                break;
            case 3:
                bankMoney += 50000;
                ShowMoney();
                break;
            case 4:
                bankMoney += mycashController.selfMoney;
                mycashController.selfMoney = 0;
                ShowMoney();
                break;
        }
    }

    public void OutputMoney()
    {
        buttonnum = OutputMoneyController.num;
        switch (buttonnum)
        {
            case 1:
                if (bankMoney >= 10000)
                {
                    bankMoney -= 10000;
                    ShowMoney();
                    mycashController.OutputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 2:
                if (bankMoney >= 30000)
                {
                    bankMoney -= 30000;
                    ShowMoney();
                    mycashController.OutputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 3:
                if (bankMoney >= 50000)
                {
                    bankMoney -= 50000;
                    ShowMoney();
                    mycashController.OutputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 4:
                SelfOutputMoney();
                if (bankMoney >= selfMoney)
                {
                    bankMoney -= selfMoney;
                    ShowMoney();
                    mycashController.OutputMoney();
                }
                else
                    delayPopup.Show();
                break;
        }
    }
    public void SelfOutputMoney()
    {
        selfMoney = int.Parse(outputmoney.text);
        outputmoney.text = "";
    }
}
