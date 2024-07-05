using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public float thoiGianChoPhepVeDich = 30f;
    public bool ketThucGame = false;
    public bool winGame = false;
    private static GameManeger instance;
    public GameObject gameOverOfject;
    public GameObject timeGame;
    [SerializeField]
    private float thoiGianCongThem = 31f;
    public GameObject winGameObject;

    public static GameManeger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManeger>();
                if (instance == null)
                {
                    GameObject gameManagerGameObject = new GameObject("GameManager");
                    instance = gameManagerGameObject.AddComponent<GameManeger>();
                }
            }
            return instance;
        }
    }
    private void Update()
    {
        if (!ketThucGame)
        {
            thoiGianChoPhepVeDich -= Time.deltaTime;
            Debug.Log(thoiGianChoPhepVeDich);
            if (thoiGianChoPhepVeDich <= 0)
            {
                KetThucGame();
                gameOverOfject.SetActive(true);
                timeGame.SetActive(false);
            }
        }
        if(winGame)
        {
            timeGame.SetActive(false);
            winGameObject.SetActive(true);
        }
    }
    private void KetThucGame()
    {
        ketThucGame = true;
    }
    public void QuaCheckPoint()
    {
        if(!ketThucGame)
        {
            thoiGianChoPhepVeDich += thoiGianCongThem;
        }
    }
    public void QuaWinPoint()
    {
        if(!ketThucGame)
        {
            winGame = true;
        }
    }
}
