using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class multiple : MonoBehaviour
{
    public Text pregunta;
    public Text[] respuestas;
    public Text cronometrotexto;

    int numero1;
    int numero2;
    string preguntaFinal;
    int producto;
    int aleatorio_respuesta;
    public int  tiempoCronometro;
    private float contador;
    void Start()
    {
        contador = tiempoCronometro;
        cronometrotexto.text = contador.ToString();
        generadorNumero();

    }
    void generadorNumero()
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
    //contador conometro
  
    void Update()
    {
    //el cronometro se ejecuta todo el juego
    //deltatime mide el tiempo que pasa entre cada frame 
    contador =contador - Time.deltaTime;
     cronometrotexto.text = contador.ToString("f0");
        if(contador <= 0)
        {
        Debug.Log("se acabo el tiempo");
        generadorNumero();
        //se hace para que el contado se hace 5 segundos
        contador = tiempoCronometro;
        cronometrotexto.text = contador.ToString();
                

        }
    }
}
