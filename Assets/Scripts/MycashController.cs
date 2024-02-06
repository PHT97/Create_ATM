using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MycashController : MonoBehaviour
{
    public int myMoney = 100000;
    public string _myMoney;
    public int buttonnum;
    public int selfMoney;

    public TMP_Text MyMoney;
    public BankcashController bankcashController;
    public DelayPopUp delayPopup;
    public TMP_InputField inputmoney;

    void Start()
    {
        MyCash();
    }

    private void MyCash()
    {
        ShowMoney();
    }
    public void ShowMoney()
    {
        _myMoney = string.Format("{0:#,0}", myMoney);
        MyMoney.text = _myMoney;
    }
    public void InputMoney()
    {
        buttonnum = InputMoneyButtonController.num;
        switch (buttonnum)
        {
            case 1:
                if (myMoney >= 10000)
                {
                    myMoney -= 10000;
                    ShowMoney();
                    bankcashController.InputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 2:
                if (myMoney >= 30000)
                {
                    myMoney -= 30000;
                    ShowMoney();
                    bankcashController.InputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 3:
                if (myMoney >= 50000)
                {
                    myMoney -= 50000;
                    ShowMoney();
                    bankcashController.InputMoney();
                }
                else
                    delayPopup.Show();
                break;
            case 4:
                SelfInputMoney();
                if (myMoney >= selfMoney)
                {
                    myMoney -= selfMoney;
                    ShowMoney();
                    bankcashController.InputMoney();
                }
                else
                    delayPopup.Show();
                break;
        }
    }
    public void OutputMoney()
    {
        buttonnum = OutputMoneyController.num;
        switch (buttonnum)
        {
            case 1:
                myMoney += 10000;
                ShowMoney();
                break;
            case 2:
                myMoney += 30000;
                ShowMoney();
                break;
            case 3:
                myMoney += 50000;
                ShowMoney();
                break;
            case 4:
                myMoney += bankcashController.selfMoney;
                ShowMoney();
                bankcashController.selfMoney = 0;
                break;
        }
    }
    public void SelfInputMoney()
    {
        selfMoney = int.Parse(inputmoney.text);
        inputmoney.text = "";
    }
}
