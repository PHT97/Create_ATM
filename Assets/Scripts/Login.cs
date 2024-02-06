using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public GameObject MainTitle;
    public GameObject login;
    public TMP_InputField ID;
    public TMP_InputField PS;
    

    public void LoginUI()
    {
        if (3 <= ID.text.Length && 3 <= PS.text.Length)
        {
            login.SetActive(false);
            MainTitle.SetActive(true);
        }
    }
}
