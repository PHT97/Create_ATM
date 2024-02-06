using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUIController : MonoBehaviour
{
    public GameObject UI;

    public void InputUI()
    {
        UI.SetActive(true);
    }

    public void OutputUI()
    {
        UI.SetActive(false);
    }
}
