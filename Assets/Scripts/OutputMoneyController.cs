using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutputMoneyController : MonoBehaviour
{
    public MycashController mycashController;
    public BankcashController bankcashController;

    public Button First;
    public Button Second;
    public Button Thard;
    public Button OutputButton;

    public static int num;
    public void FirstButton()
    {
        num = 1;
        bankcashController.OutputMoney();
    }

    public void SecondButton()
    {
        num = 2;
        bankcashController.OutputMoney();
    }

    public void ThardButton()
    {
        num = 3;
        bankcashController.OutputMoney();
    }
    public void SelfOutputButton()
    {
        num = 4;
        bankcashController.OutputMoney();
    }
}
