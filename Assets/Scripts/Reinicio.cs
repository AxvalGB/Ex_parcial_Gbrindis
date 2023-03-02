using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public KeyCode teclaReinicio = KeyCode.R;

    void Update()
    {
        if (Input.GetKeyDown(teclaReinicio))
        {
            ReiniciarJuego();
        }
    }

    void ReiniciarJuego()
    {
        Scene escenaActual = SceneManager.GetActiveScene();
        SceneManager.LoadScene(escenaActual.name);
    }
}
