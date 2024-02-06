using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputMoneyButtonController : MonoBehaviour
{
    public MycashController mycashController;
    public BankcashController bankcashController;

    public Button First;
    public Button Second;
    public Button Thard;
    public Button inputButton;

    public static int num;
    public void FirstButton()
    {
        num = 1;
        mycashController.InputMoney();
    }

    public void SecondButton()
    {
        num = 2;
        mycashController.InputMoney();
    }

    public void ThardButton()
    {
        num = 3;
        mycashController.InputMoney();
    }

    public void SelfInputButton()
    {
        num = 4;
        mycashController.InputMoney();
    }
}
