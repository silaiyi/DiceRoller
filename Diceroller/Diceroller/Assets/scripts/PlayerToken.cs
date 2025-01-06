using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerToken : MonoBehaviour 
{

    public Tile startingTile;
    public DiceManager diceManager;
    public Text valueText,MoneyText;
    public static int Money=300;
    Tile currentTile;

    Tile[] moveQueue;
    public static int moveQueueIndex,spacesToMove,canShowBuyBtn;

    Vector3 targetPosition;
    Vector3 velocity;

    Tile finalTile;
    public int seeMove;
	
    void Awake()
    {
        finalTile = startingTile;
        targetPosition = this.transform.position;
    }

    /// Moves this object to the desired position which is set by the dice roll.
	void Update () 
    {
        if (Vector3.Distance(this.transform.position, targetPosition) > 0.03f)
        {
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, 0.2f);
        }
        else
        {
            if (moveQueue != null && moveQueueIndex < moveQueue.Length)
            {
                Tile nextTile = moveQueue[moveQueueIndex];
                SetNewTargetPosition(nextTile.transform.position);
                moveQueueIndex++;
                canShowBuyBtn=spacesToMove-moveQueueIndex;
            }
        }
        seeMove = canShowBuyBtn;
        MoneyText.text="Coin: "+Money;
    }

    void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos;
        velocity = Vector3.zero;
    }

    /// Moves the player 1-6 spaces depending on value of the dice roll.
    public void MovePlayerToken()
    {
        spacesToMove = diceManager.totalValue;
        valueText.text = "Value: " + spacesToMove.ToString();

        if (spacesToMove == 0)
        {
            return;
        }            

        moveQueue = new Tile[spacesToMove];

        for (int i = 0; i < spacesToMove; i++)
        {
            finalTile = finalTile.nextTile;
            moveQueue[i] = finalTile;
        }
        moveQueueIndex = 0;

        
    }

}