using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class niveles : MonoBehaviour
{
    public void Jugar(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }


   }