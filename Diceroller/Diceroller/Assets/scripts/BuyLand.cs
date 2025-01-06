using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLand : MonoBehaviour
{
    public GameObject lv1house,lv2house,lv3house,BuyLandBtn;
    int Cost=100;
    int landLv=0;
    public Text text;
    bool showBtn = false;
    //public bool canBuy = false;
    public bool canbuy = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text="Cost: " + Cost + " Lv: " + landLv;
        if(landLv==0){
            lv1house.SetActive(false);
            lv2house.SetActive(false);
            lv3house.SetActive(false);
        }else if(landLv==1){
            lv1house.SetActive(true);
            lv2house.SetActive(false);
            lv3house.SetActive(false);
        }else if(landLv==2){
            lv1house.SetActive(false);
            lv2house.SetActive(true);
            lv3house.SetActive(false);
        }else if(landLv==3){
            lv1house.SetActive(false);
            lv2house.SetActive(false);
            lv3house.SetActive(true);
        }
        if(showBtn==true){
            if(PlayerToken.canShowBuyBtn==0){
                if(canbuy == true){
                    if(landLv<=2){
                        BuyLandBtn.SetActive(true);
                    }else{
                        BuyLandBtn.SetActive(false);
                    }
                }else{
                    BuyLandBtn.SetActive(false);
                }
                
            }else{
                BuyLandBtn.SetActive(false);
            }
        }else if(showBtn==false){
            BuyLandBtn.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            BuyALand();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // 检查碰撞的物体是否是玩家
        if (other.CompareTag("Player"))
        {
            if(landLv<=3){
                showBtn=true;
            }
            if(canbuy==true){
                if(PlayerToken.canShowBuyBtn==0){
                    PlayerToken.Money+=0;
                }else if(landLv>0){
                    PlayerToken.Money+=Cost-50;
                }
            }
        }
            
    }
    void OnTriggerExit(Collider other){
        if (other.CompareTag("Player"))
        {
            //BuyLandBtn.SetActive(false);
            showBtn=false;
        }
    }
    public void BuyALand(){
        if(showBtn==true){
            if(PlayerToken.canShowBuyBtn==0){
                if(canbuy == true){
                    if(landLv<4){
                        BuyLandBtn.SetActive(true);
                        if(PlayerToken.Money-Cost>=0){
                            PlayerToken.Money-=Cost;
                            landLv++;
                            Cost+=50;
                            
                        }
                    }
                } 
            }
        }
        
    }
}
