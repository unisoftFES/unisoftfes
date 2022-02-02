using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flechas : MonoBehaviour
{
    public Transform posCamara;
    public GameObject este;
    public RectTransform dere, iz, arri, aba, z1, z2;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {

        Vector2 parseoPos = posCamara.position;
        transform.position = parseoPos;

    }

    public void Activar()
    {
        z1.sizeDelta = new Vector2(0.5175f, 0.5475f);
        z2.sizeDelta = new Vector2(0.5175f, 0.5475f);
        z1.anchoredPosition = new Vector2(-4.542f, 2.555f);
        z2.anchoredPosition = new Vector2(-3.467f, 2.555f);

        dere.sizeDelta = new Vector2(0.6248f, 0.5232f);
        iz.sizeDelta = new Vector2(0.6248f, 0.5232f);
        arri.sizeDelta = new Vector2(0.6248f, 0.5232f);
        aba.sizeDelta = new Vector2(0.6248f, 0.5232f);

        iz.anchoredPosition = new Vector2(-5.742f, -0.1f);
        dere.anchoredPosition = new Vector2(5.768f, -0.1f);
        arri.anchoredPosition = new Vector2(0.13f, 3.03f);
        aba.anchoredPosition = new Vector2(0.131f, -3.03f);

        if (PosicionCambioDos.instancia.var.activador)
        {
            PosicionCambioDos.instancia.var.contador = 1;
            PosicionCambioDos.instancia.var.activador = false;
            este.SetActive(true);
        }
        else
        {
            PosicionCambioDos.instancia.var.contador = 0;
            PosicionCambioDos.instancia.var.activador = true;
            este.SetActive(false);
        }

    }
    public void ZoomDos()
    {
        z1.sizeDelta = new Vector2(0.4413f, 0.4827f);
        z2.sizeDelta = new Vector2(0.4413f, 0.4827f);
        z1.anchoredPosition = new Vector2(-3.592f, 1.894f);
        z2.anchoredPosition = new Vector2(-2.667f, 1.894f);



        dere.sizeDelta = new Vector2(0.4433f, 0.4562f);
        iz.sizeDelta = new Vector2(0.4433f, 0.4562f);
        arri.sizeDelta = new Vector2(0.4433f, 0.4562f);
        aba.sizeDelta = new Vector2(0.4433f, 0.4562f);

        iz.anchoredPosition = new Vector2(-3.961f, 0.2f);
        dere.anchoredPosition = new Vector2(3.991f, 0.2f);
        arri.anchoredPosition = new Vector2(0.034f, 2.165f);
        aba.anchoredPosition = new Vector2(0.035f, -2.087f);

        PosicionCambioDos.instancia.var.contador = 2;
    }
    public void ActivarPc()
    {

        if (PosicionCambioDos.instancia.var.pc)
        {
            PosicionCambioDos.instancia.var.pc = false;
            PosicionCambioDos.instancia.var.activador = false;
        }
        else
        {
            PosicionCambioDos.instancia.var.pc = true;
            PosicionCambioDos.instancia.var.activador = true;
        }

    }

   
}
