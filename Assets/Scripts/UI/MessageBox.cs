using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBox : MonoBehaviour
{
    public void ShowMessageBox()
    {
        this.gameObject.SetActive(true);
    }

    public void CloseMessageBox()
    {
        this.gameObject.SetActive(false);
    }
}
