using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    public void returniveles()
    {
        //que regrese a la escena de niveles

        SceneManager.LoadScene(0);


    }
}
