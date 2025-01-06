using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Update()
    {
        // 检测玩家按下空格键
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("test");
        }

        // 检测玩家按下Esc键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 退出游戏
            Application.Quit();
        }
    }
}
