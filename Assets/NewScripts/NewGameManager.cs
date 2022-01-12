using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewGameManager : MonoBehaviour 
{

    //Main Menu Texts
    public Text Languagetext;
    public Text optionText;
    public Text World1Text;
    public Text World2Text;
    public Text World3Text;

    public Text CareerText;
    public Text timeAttack;
    public Text ChampionShiptext;

    //day translation
    public Text[] daytexts;

    public Text worldunlocking1;
    public Text worldunlocking2;




    // Use this for initialization
    void Start () 
    {
        
        //dont destry on load
        //DontDestroyOnLoad(this.gameObject);
        changelanguage(PlayerPrefs.GetInt("language", 1));

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void changelanguage(int n)
    {
        PlayerPrefs.SetInt("language", n);
        //1 for english
        //2 for spanish


        //for first scene
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //checking for player pref
            if (PlayerPrefs.GetInt("language", 1) == 1)
            {
                Languagetext.text = "Language";
                optionText.text = "Options";
                World1Text.text = "World 1";
                World2Text.text = "World 2";
                World3Text.text = "World 3";
                CareerText.text = "Career";
                timeAttack.text = "Time Attack";
                ChampionShiptext.text = "Chief ChampionShip";
                worldunlocking1.text = "For To unlock";
                worldunlocking2.text = "For To unlock";

                for (int i = 0; i < daytexts.Length; i++)
                {
                    daytexts[i].text = "DAY";
                }

            }
            //for spanish
            else if (PlayerPrefs.GetInt("language", 1) == 2)
            {
                worldunlocking1.text= "ParaDesbloquear";
                worldunlocking2.text = "ParaDesbloquear";

                Languagetext.text = "idioma";
                optionText.text = "AJUSTES";
                World1Text.text = "Mundo 1";
                World2Text.text = "Mundo 2";
                World3Text.text = "Mundo 3";
                CareerText.text = "Carrera";
                timeAttack.text = "CONTRA RELOJ";
                ChampionShiptext.text = "campeonato De Chef";

                for (int i = 0; i < daytexts.Length; i++)
                {
                    daytexts[i].text = "DIA";
                }
            }

        }
    }

}
