using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlyingEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] puntosMovimiento;
    public float velocidadMovimiento;
    private int siguientePlataforma;
    private bool ordenPlataformas = true;

    void Update()
    {
        if (ordenPlataformas && siguientePlataforma + 1 >= puntosMovimiento.Length)
        {
            ordenPlataformas = false;
        }
        if (!ordenPlataformas && siguientePlataforma<= 0)
        {
            ordenPlataformas = true;
        }
        if(Vector2.Distance(transform.position, puntosMovimiento[siguientePlataforma].position) < 0.1f)
        {
            if (ordenPlataformas)
            {
                siguientePlataforma += 1;
            }
            else
            {
                siguientePlataforma -= 1;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePlataforma].position, velocidadMovimiento * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }

         //Solo detecta colisiones del Player
        if (collision.gameObject.CompareTag("Player") && !FindObjectOfType<Vidas>().inmortal)
        {
            //Encuentro el objeto Vidas en el juego
            GameObject vidas = GameObject.FindObjectOfType<Vidas>().gameObject;
            //Le resto un punto a la variable VidaTotal
            vidas.GetComponent<Vidas>().VidaTotal--;
            FindObjectOfType<CharacterController2D>().life--;
            //Muestro la VidaTotal en el texto del canvas
            vidas.GetComponent<TextMeshProUGUI>().text = vidas.GetComponent<Vidas>().VidaTotal.ToString();
            //Llamar a CondicionesVida para evaluar el GameOver
            vidas.GetComponent<Vidas>().CondicionesVida();
            //Devolver al jugador al inicio
            collision.transform.position = FindObjectOfType<Inicio>().transform.position;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}
