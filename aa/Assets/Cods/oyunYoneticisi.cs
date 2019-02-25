using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyunYoneticisi : MonoBehaviour {
    public Animator animator;
    GameObject donenCember;
    GameObject anaCember;
    // Use this for initialization
    void Start() {
        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("anaCemberTag");

    }

    public void oyunBitti()
    {
        StartCoroutine(cagrilanMetot());
    }
    IEnumerator cagrilanMetot()
    {
        //donenCember compenentimin görünürlüğünü kapatıyorum...
        donenCember.GetComponent<dondurme>().enabled = false;
        anaCember.GetComponent<anaCember>().enabled = false;
        animator.SetTrigger("oyunBitti");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("anaMenu");
    }
}