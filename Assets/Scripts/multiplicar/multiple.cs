using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class multiple : MonoBehaviour
{
    public Button[] botonesrespuestas;
    public GameObject pantallafinal;
    public GameObject pantallafinal2;
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
    public int maximopuntuaje;
    private float contador;
    bool b;
    private bool juegoterminado = false;
    //con el uso de b se va repetir solo una vez  
    void Start()
    {
        b = true;
        int a = 0;

        pantallafinal.SetActive(false);
        pantallafinal2.SetActive(false);
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
            }
            else if (i != aleatorio_respuesta)
            {
                respuestas[i].text = Random.Range(4, 101).ToString();
            }
        }
    }
    public void respuestabloque1()
    {
        click(0);

    }
    public void respuestabloque2()
    {
        click(1);
    }
    public void respuestabloque3()
    {
        click(2);
    }
    public void respuestabloque4()
    {
        click(3);
    }
    void click(int numerorespuesta)
    {
        if (respuestas[numerorespuesta].text == producto.ToString())
        {
            a++;
            puntuaje.text = a.ToString();
        }else
        { 
            juegoterminado = true;
            pantallafinal2.SetActive(true);
            foreach (Button boton in botonesrespuestas)
            {
                boton.interactable = false;
            }
        }
        contador = tiempoCronometro;
        iniciador();
    }
    void Update()
    {
        if (!juegoterminado)
        {
            //el cronometro se ejecuta todo el juego
            //deltatime mide el tiempo que pasa entre cada frame 
            Button botonmenu = GameObject.Find("BotonPausa").GetComponent<Button>();
            contador = contador - Time.deltaTime;
            if (puntuaje.text == maximopuntuaje.ToString() && b == true)
            {
                //desactivar boton de menu del juego
                botonmenu.interactable = false;
                pantallafinal.SetActive(true);
                //congelar tiempo del cronometro
                contador = 0;
                foreach (Button boton in botonesrespuestas)
                {
                    boton.interactable = false;
                }
                b = false;
                juegoterminado = true;
            }
        }

        if (!juegoterminado)
        {
            cronometrotexto.text = contador.ToString("f0");
            if (contador <= 0)
            {

                Debug.Log("se acabo el tiempo");
                pantallafinal2.SetActive(true);
                iniciador();
                //se hace para que el contado se hace 5 segundos
                contador = tiempoCronometro;
                cronometrotexto.text = contador.ToString();
                juegoterminado = true;
            }
           

        }



    }

}
