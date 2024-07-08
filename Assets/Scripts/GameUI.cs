using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public void Update()
    {
        HienThiThoiGian();
    }
    public void HienThiThoiGian()
    {
        timeText.SetText(Mathf.FloorToInt(GameManager.Instance.thoiGianChoPhepVeDich).ToString());
    }
    public void ChoiLai()
    {
        SceneManager.LoadScene("Game");
    }
    public void VeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
