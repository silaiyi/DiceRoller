using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarterGiveMoney : MonoBehaviour
{
    int wavecount=0;
    public GameObject winmenu;
    // Start is called before the first frame update
    void Start()
    {
        wavecount=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(wavecount>=50){
            winmenu.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
            SceneManager.LoadScene("SampleScene");
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }else{
            winmenu.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // 检查碰撞的物体是否是玩家
        if (other.CompareTag("Player"))
        {
            PlayerToken.Money+=500;
            wavecount++;
        }
    }

}
