using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();

    }

    public void IrOpciones()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SalirOpciones()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RegresarOpciones(int Opciones)
    {
        SceneManager.LoadScene(Opciones);
    }

    public void Nivel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Nivel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Nivel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void IrMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void VolverMenuNiveles()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void RegresarMenu(int MenuInicial)
    {
        SceneManager.LoadScene(1);

    }
    public void ReiniciarNivel1()
    {
        SceneManager.LoadScene(2);
    
        
    }

    public void ReiniciarNivel2()
    {
        SceneManager.LoadScene(3);
    
        
    }

public void ReiniciarNivel3()
    {
        SceneManager.LoadScene(4);
    
        
    }




}

