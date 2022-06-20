using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class v : MonoBehaviour
{
    public GameObject CanvasOBJ;



    public InputField inputField;
    public InputField inputField2;
    public InputField inputField3;
    public InputField inputField4;
    public InputField inputField5;
    public InputField inputField6;


    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitgame()
    {
        
        Application.Quit();
    }

    

    public void CanvasKapama()
    {

        CanvasOBJ.SetActive(false);

    }
    public void CanvasAcma()
    {

        CanvasOBJ.SetActive(true);

    }

    public void sýfýrla()
    {
        string sifir0 = "0";


        text1.text = "m";
        text2.text = "s";
        text3.text = "m";
        text4.text = "m/s";
        text5.text = "m";
        text6.text = "s";
        text7.text = "m";
        text8.text = "m/s";
        text9.text = "s";
      

        inputField.Select();
        inputField.text = "";
        inputField2.Select();
        inputField2.text = "";
        inputField3.Select();
        inputField3.text = "";
        inputField4.Select();
        inputField4.text = "";
        inputField5.Select();
        inputField5.text = "";
        inputField6.Select();
        inputField6.text = "";


    }


}
