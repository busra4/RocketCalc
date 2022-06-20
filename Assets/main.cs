using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class main : MonoBehaviour
{
    public float g = 9.81f; // acceleration of gravity
    private float p = 1.223f; //air density
    //private float cd = 0.75f; //drag coefficient
    
    private float τ1;

    private string cd;
    private string Ms;
    private string angle;
    private string A;
    private string I;
    private string T;


    private float k;
    private float q;
    private float x1;
    private float e = 2.718f;
    private float hB;
    private float vt;
    public float qkare;

    private float hmax;
    private float x2;
    private float τ2;
    private float τ3;
    private float x3;
    private float vy;
    private float τu;


    public Text msText;
    public Text angleText;
    public Text AText;
    public Text tText;
    public Text iText;
    public Text cdText;

    public Text addt;
    public Text addx;
    public Text addvy;
    public Text addx1;
    public Text addt1;
    public Text hmaxhb;
    public Text texthb;
    public Text textvt;
    public Text texttu;


    public InputField inputField;
    public InputField inputField2;
    public InputField inputField3;
    public InputField inputField4;
    public InputField inputField5;
    public InputField inputField6;

    void Start()
    {
        
    }

    void Update()
    {

    
    

    }

    public void yav()
    {

        Ms = msText.text;
        angle = angleText.text;
        A = AText.text;
        I = iText.text;
        T = tText.text;
        cd = cdText.text;

        k = ((0.5f) * p * float.Parse(cd) * float.Parse(A));


        q = (float)Math.Sqrt((Mathf.Abs(float.Parse(T) - (((float.Parse(Ms)) * 9.81f))) / k));


        τ1 = (float.Parse(I) / float.Parse(T));
        vt = q * (1f - (float)Math.Pow(e, (-p) * τ1)) / (1f + (float)Math.Pow(e, (-p) * τ1));

        τ2 = (2f * (float)Math.Sin(((float.Parse(angle))) * (float)vt) / 9.81f);


        /*  qkare = ((float.Parse(T) - (((float.Parse(Ms)) * 9.81f))) / k);
          q = (float)Math.Sqrt(qkare); */
       

        x1 = ((2f * (float)k * (float)q) / (float.Parse(A)));

        hB = ((float.Parse(Ms)) / 2f * (float)k) * Mathf.Log(((float)Math.Pow(q, 2f)) / ((float)Math.Pow(q, 2f) - (float)Math.Pow(vt, 2f)), e);
        hmax = hB + ((float)Math.Sin(((float.Parse(angle))) * (float)Math.Pow(vt, 2) / 2 * g));

        x2 = (float)Math.Cos(float.Parse(angle)) * τ2;

        τ3 = (float)Math.Sqrt(((2 * hB) / g));

        x3 = (float)(Math.Cos(float.Parse(angle)) * vt * τ3);

        vy = (float)((g * float.Parse(A)) + float.Parse(cd));

        τu = (((float)τ2 / 2) + (float)τ1);





        addt.text = ((float)τ1 + (float)τ2 + (float)τ3).ToString();
        addx.text = ((float)x1 + (float)x2 + (float)x3).ToString();
        addvy.text = vy.ToString();
        addx1.text = x1.ToString();
        addt1.text = τ1.ToString();
        hmaxhb.text = ((float)hmax + (float)hB).ToString();
        texthb.text = ((float)hB).ToString();
        textvt.text = ((float)vt).ToString();
        texttu.text = ((float)τu).ToString();
    }

    
}
