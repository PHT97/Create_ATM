using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayPopUp : MonoBehaviour
{
    public GameObject Popup;
    public void Show()
    {
        Popup.SetActive(true);
    }

    public void Hide()
    {
        Popup.SetActive(false);
    }
}
