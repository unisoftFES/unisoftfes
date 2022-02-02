using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PantallaInicioDos : MonoBehaviour
{
    private Animator inicioOff;
    public GameObject animacion,objetoFleclas;


    void Start()
    {
        inicioOff = GetComponent<Animator>();
        inicioOff.Play("InicioFin");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FinAnimation()
    {
        gameObject.SetActive(false);
    }

    public void NuevaAnimatión()
    {
        animacion.SetActive(true);
        PosicionCambioDos.instancia.coli.size = new Vector2(17.2616f, 9.656432f);
        PosicionCambioDos.instancia.camara.orthographicSize = 4.836329f;
        PosicionCambioDos.instancia.var.video = true;
        if (!PosicionCambioDos.instancia.var.pc)
        {
            objetoFleclas.SetActive(false);
            PosicionCambioDos.instancia.var.contador = 0;
            PosicionCambioDos.instancia.desi = true;
        }
        PosicionCambioDos.instancia.videoUNAM.SetActive(true);


    }
    public void FinAnimationBot()
    {

        animacion.SetActive(true);
        PosicionCambioDos.instancia.coli.size = new Vector2(17.2616f, 9.656432f);
        PosicionCambioDos.instancia.camara.orthographicSize = 4.836329f;
        PosicionCambioDos.instancia.var.video = false;
        if (!PosicionCambioDos.instancia.var.pc) 
        {
            objetoFleclas.SetActive(false);
            PosicionCambioDos.instancia.var.contador = 0;
            PosicionCambioDos.instancia.desi = true;
        } 
        PosicionCambioDos.instancia.videoUNAM.SetActive(false);

    }

}

