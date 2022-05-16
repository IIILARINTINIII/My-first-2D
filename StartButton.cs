using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private Image image;
    public Sprite btnDown, btnUp;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void BtnPress()
    {
        image.sprite = btnDown;
    }

    public void BtnNorm()
    {
        image.sprite = btnUp;
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
}
