using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class multiple : MonoBehaviour
{
    public Text pregunta;
    public Text[] respuestas;
    public Text cronometrotexto;
    public Text puntuaje;

    int numero1;
    int numero2;
    string preguntaFinal;
    int producto;
    int a;
    int aleatorio_respuesta;
    public int tiempoCronometro;
    private float contador;
    void Start()
    {
        int a = 0;
        puntuaje.text = a.ToString();
        contador = tiempoCronometro;
        cronometrotexto.text = contador.ToString();
        iniciador();

    }
    void iniciador()
    {

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
            else if (i != aleatorio_respuesta)
            {
                respuestas[i].text = Random.Range(2, 101).ToString();
                Debug.Log(respuestas[i].text = Random.Range(2, 101).ToString());
            }
        }
    }
    public void respuestabloque1()
    {
        if (respuestas[0].text == producto.ToString())
        {
            a++;
            puntuaje.text = a.ToString();
        }
        contador = tiempoCronometro;
        iniciador();

    }
    public void respuestabloque2()
    {
        if (respuestas[1].text == producto.ToString())
        {
            a++;
            puntuaje.text = a.ToString();
        }
        contador = tiempoCronometro;
        iniciador();
    }
    public void respuestabloque3()
    {
        if (respuestas[2].text == producto.ToString())
        {
            a++;
            puntuaje.text = a.ToString();
        }
        contador = tiempoCronometro;
        iniciador();
    }
    public void respuestabloque4()
    {
        if (respuestas[3].text == producto.ToString())
        {
            a++;
            puntuaje.text = a.ToString();
        }
        contador = tiempoCronometro;
        iniciador();
    }

    void Update()
    {
        //el cronometro se ejecuta todo el juego
        //deltatime mide el tiempo que pasa entre cada frame 
        contador = contador - Time.deltaTime;
        cronometrotexto.text = contador.ToString("f0");
        if (contador <= 0)
        {
            Debug.Log("se acabo el tiempo");
            iniciador();
            //se hace para que el contado se hace 5 segundos
            contador = tiempoCronometro;
            cronometrotexto.text = contador.ToString();


        }
    }

}
