using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class multiple : MonoBehaviour
{
    public Text pregunta;
    public Text[] respuestas;

    int numero1;
    int numero2;
    string preguntaFinal;
    int producto;
    void Start()
    {
       numero1 = Random.Range(2, 11);
       numero2 = Random.Range(2, 11);
       producto = numero1 * numero2;
       preguntaFinal = numero1.ToString() + " x " + numero2.ToString();
       pregunta.text = preguntaFinal;
        for (int i = 0; i <= respuestas.Length -1; i++)
        {
            respuestas[i].text = producto.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
