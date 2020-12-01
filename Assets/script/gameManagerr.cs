using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerr : MonoBehaviour
{
    enum elements { Rock = 1, Paper, sesior     }
    private int player_choise = -1;
    private int bot_choose = -1;
    private bool player_turn = true;
    public GameObject WinnerText;
    public Sprite paperImage,RockImage,SessiorImage;
    public GameObject Botchoseeimage;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Player_Choose(int choose)
    {
        player_choise = choose;
        player_turn = false;
    }
    public void bot_turn()
    {
        bot_choose = Random.Range(1, 3);

        if (bot_choose==3)
        {
            Botchoseeimage.GetComponent<Image>().sprite =SessiorImage;
        }
        else if (bot_choose==2)
        {
            Botchoseeimage.GetComponent<Image>().sprite = paperImage;
        }
        else
        {
            Botchoseeimage.GetComponent<Image>().sprite = RockImage;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (player_turn && player_choise == -1)
            return;
        
        
            bot_turn();
            Check_Winner();
            player_choise = -1;
            player_turn = true;
        
    }
    public void Check_Winner()
    {
        if (player_choise == (int)elements.Paper && bot_choose == (int)elements.Paper)
        {
            WinnerText.GetComponent<Text>().text = "Draw";
            //Draw
        }

        else if (player_choise == (int)elements.Rock && bot_choose == (int)elements.Rock)
        {
            WinnerText.GetComponent<Text>().text = "Draw";
            //Draw
        }

        else if (player_choise == (int)elements.sesior && bot_choose == (int)elements.sesior)
        {
            WinnerText.GetComponent<Text>().text = "Draw";
            //Draw
        }




        else if (player_choise==(int) elements.sesior&&bot_choose==(int)elements.Rock)
        {

            //playes win
            WinnerText.GetComponent<Text>().text = "You Loss";
        }
        else if (player_choise ==(int) elements.Rock && bot_choose==(int)elements.Paper)
        {
            //bot wins
            WinnerText.GetComponent<Text>().text = "You Loss";
        }
        else if (player_choise==(int) elements.Paper&&bot_choose==(int)elements.sesior)      
        {
            // bot wins
            WinnerText.GetComponent<Text>().text = "you Loss";
        }
        else if (player_choise == (int)elements.Rock && bot_choose == (int)elements.sesior)
        {
            //player  wins
            WinnerText.GetComponent<Text>().text = "Player Wins";
        }

        else  if (player_choise == (int)elements.sesior && bot_choose == (int)elements.Paper)
        {
            //player  wins
            WinnerText.GetComponent<Text>().text = "Player Wins";
        }
        else if (player_choise == (int)elements.Paper && bot_choose == (int)elements.Rock)
        {
            //player  wins
            WinnerText.GetComponent<Text>().text = "Player Wins";
        }
    }
}
