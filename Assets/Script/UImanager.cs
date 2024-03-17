using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UImanager : MonoBehaviour
{
    public GameObject persistantObj =null;
    public void VsPlayer(){
        persistantObj.GetComponent<PersistanceScript>().gameMode = "2player";
        SceneManager.LoadScene("Game");
    }

    public void VsAI(){
        persistantObj.GetComponent<PersistanceScript>().gameMode = "vscpu";
        SceneManager.LoadScene("Game");
    }

    public void Quit(){
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif

    }
}
