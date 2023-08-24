using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUI : MonoBehaviour
{
   
    string input_name;

    private void Start()
    {
        MainManager.Instance.LoadName();
        input_name = MainManager.Instance.name;
    }
    // Получаем текст с помощью поля text в InputField:
    public void ReadStringFromInput(string s)
    {
        input_name = s;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        MainManager.Instance.name = input_name;
       
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
     

    }
}
