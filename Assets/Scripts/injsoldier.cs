using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class injsoldier : MonoBehaviour
{
    public int skor=0;
    public Text basmak;

    public void sold()
    {
        skor++;
        basmak.text = "" + skor + "";
    }

    
    
}
