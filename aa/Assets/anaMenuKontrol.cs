using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaMenuKontrol : MonoBehaviour {

    public void oyunaGir()
    {
        Debug.Log("veri geldi..");
        SceneManager.LoadScene("level1");
    }

    public void cik()
    {
        Debug.Log("girdi.");
        Application.Quit();
    }
}
