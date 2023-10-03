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
    int aleatorio_respuesta;
    void Start()
    {

        //esto es una prueba de git
        numero1 = Random.Range(2, 11);
        numero2 = Random.Range(2, 11);
        producto = numero1 * numero2;
        aleatorio_respuesta = Random.Range(0, respuestas.Length);
        preguntaFinal = numero1.ToString() + " x " + numero2.ToString();
        pregunta.text = preguntaFinal;
        for (int i = 0; i <= respuestas.Length - 1; i++)
        {
            if (i == aleatorio_respuesta)
            {
                respuestas[i].text = producto.ToString();
                Debug.Log(respuestas[i].text = producto.ToString());
            }
            else if(i!= aleatorio_respuesta){
                respuestas[i].text = Random.Range(2, 101).ToString();
                Debug.Log(respuestas[i].text = Random.Range(2, 101).ToString());
            }

      

            
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
