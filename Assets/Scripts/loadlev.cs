using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class loadlev : MonoBehaviour
{
    // Start is called before the first frame update
    public void load()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("RightAndLeft");
    }      
}
