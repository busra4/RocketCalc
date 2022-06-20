using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class ana : MonoBehaviour
{
    public float g = 9.81f; // acceleration of gravity
    private float p = 1.223f; //air density
    private float cd = 0.75f; //drag coefficient

    public float τ1; 
    public string Ms;
    public string angle;
    public string A;
    public string I;
    public string T;


    public float k;
    public float q;
    public float x1;
    public float e = 2.718f;
    public float hB;
    private float vt;
    public float qkare;

    private float hmax;
    // private float angle=45f;
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


    void Start()
    {
        
    }

    void Update()
    {

        Ms = msText.text;
        angle = angleText.text;
        A = AText.text;
        I = iText.text;
        T = tText.text;

        k =((0.5f) * p *cd * float.Parse(A));

        τ1 = ( float.Parse(I) / float.Parse(T));
        vt = q * (1f - (float)Math.Pow(e, (-p) * τ1)) / (1f + (float)Math.Pow(e, (-p) * τ1));

        τ2 = (2f *  (float) Math.Sin(((float.Parse(angle))) * (float)vt ) / 9.81f);


        qkare = ((float.Parse(T) - (((float.Parse(Ms)) * 9.81f))) /  k);
        q = (float) Math.Sqrt(qkare);


        x1 = ((2f * (float) k * (float)q) / (float.Parse(A)));

        hB = ((float.Parse(Ms)) / 2f * (float)k) * Mathf.Log(((float)Math.Pow(q, 2f)) / ((float)Math.Pow(q, 2f) - (float)Math.Pow(vt, 2f)), e);
        hmax = hB + ((float)Math.Sin(((float.Parse(angle))) * (float)Math.Pow(vt, 2) / 2 * g));

        x2 = (float) Math.Cos(float.Parse(angle)) * τ2;

        τ3 = (float)Math.Sqrt(((2 * hB) / g));

        x3 = (float)(Math.Cos(float.Parse(angle)) * vt * τ3);

        vy = (float) ((g * float.Parse(A)) + cd );

        τu = (((float) τ2 / 2 )+ (float) τ1 ) ;


        addt.text = ((float) τ1 + (float )τ2 + (float) τ3).ToString();
        addx.text = ((float ) x1 + (float) x2 +(float) x3).ToString();
        addvy.text = vy.ToString();
        addx1.text = x1.ToString();
        addt1.text = τ1.ToString();
        hmaxhb.text = ((float)hmax + (float)hB).ToString();
        texthb.text = ((float)hB).ToString();
        textvt.text = ((float)vt).ToString();
        texttu.text = ((float)τu).ToString();
   

    }

    void burnoutVelocity()
    {
       // vt = q * (1f - (float)Math.Pow(e, (-p) * τ1)) / (1f + (float)Math.Pow(e, (-p) * τ1));

    }

    void burnoutAltitude()
    {

       // hB = (mB / 2f * k) * Mathf.Log(((float)Math.Pow(q, 2f)) / ((float)Math.Pow(q, 2f) - (float)Math.Pow(vt, 2f)), e);
    }


    void angleCalculate()
    {
       // hmax = hB + ((float) Math.Sin(angle) * (float) Math.Pow(vt, 2) / 2 * g);

       // x2 = (float) Math.Cos(angle) * τ2;
    }

    public void sıfırla()
    {
        string sifir0 = "0";

      
 
       
        addt.text = (τ1 + τ2 + τ3).ToString();
        addx.text = (x1 + x2 + x3).ToString();
        addvy.text = vy.ToString();
        addx1.text = x1.ToString();
        addt1.text = τ1.ToString();
        
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
    


    }

}
