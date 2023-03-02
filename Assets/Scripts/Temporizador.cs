using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public float tiempoInicial = 60f;
    public Text textoTemporizador;

    private float tiempoRestante;

    void Start()
    {
        tiempoRestante = tiempoInicial;
    }

    void Update()
    {
        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0f)
        {
            tiempoRestante = 0f;
            Debug.Log("¡Se acabó el tiempo!");
        }

        ActualizarTextoTemporizador();
    }

    void ActualizarTextoTemporizador()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60f);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60f);
        string formatoMinutos = minutos.ToString("00");
        string formatoSegundos = segundos.ToString("00");
        textoTemporizador.text = formatoMinutos + ":" + formatoSegundos;
    }
}

