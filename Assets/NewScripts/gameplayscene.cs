using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameplayscene : MonoBehaviour {



    public Sprite WinImageEnglish;
    public Sprite WinImagespanish;
    public GameObject MainWinObj;


    public Sprite looseImageEnglish;
    public Sprite looseImagespanish;
    public GameObject MainlooseObj;

    //for timeover work


    public GameObject MaintimeoverObj;

    public Text PauseTxt;


    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("language", 1) == 1)
        {
            PauseTxt.text = "PAUSE";
            MainWinObj.GetComponent<Image>().sprite = WinImageEnglish;
            MainlooseObj.GetComponent<Image>().sprite = looseImageEnglish;
            MaintimeoverObj.GetComponent<Text>().text = "TIME OVER";


        }
        else
        {
            PauseTxt.text = "PAUSA";
            MainWinObj.GetComponent<Image>().sprite = WinImagespanish;
            MainlooseObj.GetComponent<Image>().sprite = looseImagespanish;
            MaintimeoverObj.GetComponent<Text>().text = "SE ACABO EL TIEMPO";

        }
    }
        // Update is called once per frame
        void Update () {
		
	}
}
