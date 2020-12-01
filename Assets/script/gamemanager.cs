 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    enum elements { Rock,Paper, sesior}
    private int player_choise =-1;
    private int bot_chance = -1;
    private bool player_turn = true;

    // Start is called before the first frame update
    void Start()
    {
        if (player_turn && player_choise == -1)
            return;
        {

        }    

    }

    public void Player_Choose(int choose)
    {
        player_choise = choose;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
