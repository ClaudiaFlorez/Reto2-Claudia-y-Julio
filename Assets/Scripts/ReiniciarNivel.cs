using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarNivel : MonoBehaviour
{
    int escena;
    public void ReinicioNivel(int escenaObejtivo)
    {
        escena = escenaObejtivo;
        Invoke("Cambio", 0.5f);
    }
    public void Cambio()
    {
        SceneManager.LoadScene(escena);
    }
}
