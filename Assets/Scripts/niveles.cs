using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class niveles : MonoBehaviour
{
    public void Nivelprimero(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void Nivelsegundo(string SecondScene)
    {
        SceneManager.LoadScene(SecondScene);
    }


   }