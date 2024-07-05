using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XuLyVaChamChoXe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="CheckPoint")
        {
            GameManeger.Instance.QuaCheckPoint();
        }
        if (other.gameObject.tag == "WinPoint")
        {
            GameManeger.Instance.QuaWinPoint();
        }
    }
}
