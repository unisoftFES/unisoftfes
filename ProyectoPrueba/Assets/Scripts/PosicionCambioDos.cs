using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[RequireComponent(typeof(BoxCollider2D))]

public class PosicionCambioDos : MonoBehaviour
{
    public static PosicionCambioDos instancia;
    private Vector3 mousePosition, mouseposition2;
    public Camera camara;
    public BoxCollider2D coli;
    private float velocidad = 2f;
    public Rigidbody2D rigi;
    private float minX = -1.5f;
    private float maxX = 1.5f;
    private float minY = -1.5f;
    private float maxY = 1.5f;
    public bool desi = true;
    public BotAndroid var;
    public GameObject videoUNAM;
    public PantallaInicioDos complementoPantalla;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        
    }
    void Start()
    {
        instancia = this;
        coli = GetComponent<BoxCollider2D>();
        camara = GetComponent<Camera>();
        camara.orthographicSize = 4.836329f;
        rigi = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (var.video)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && var.video) complementoPantalla.FinAnimationBot();
        }

        if (var.video) return;
        Vector2 temp = Input.mouseScrollDelta;
        if (temp.y == 0 && camara.orthographicSize != 4.836329f)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || var.aDondeIr == "a") transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || var.aDondeIr == "b") transform.Translate(-Vector2.right * velocidad * Time.deltaTime);
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || var.aDondeIr == "c") transform.Translate(Vector2.down * velocidad * Time.deltaTime);
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || var.aDondeIr == "d") transform.Translate(Vector2.up * velocidad * Time.deltaTime);
            if (Input.GetMouseButtonDown(0))
            {
                mouseposition2 = transform.position;
                StartCoroutine(TiempoEspera());

            }
            if (Input.GetMouseButtonUp(0)) desi = true;
            if (!desi)
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = -3;
                AlcanzarObjetivo(mousePosition);
            }
        }

        if (temp.y == 1 && Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            camara.orthographicSize += 0.1f;
            Vector2 tamaños;
            tamaños.x = 0.4f;
            tamaños.y = 0.2f;
            coli.size += tamaños;
            camara.orthographicSize = (camara.orthographicSize > 4.836329f) ? 4.836329f : camara.orthographicSize;
            float tamañoMaxX = (coli.size.x > 17.2616f) ? 17.2616f : coli.size.x;
            float tamañoMaxY = (coli.size.y > 9.656432f) ? 9.656432f : coli.size.y;
            coli.size = new Vector2(tamañoMaxX, tamañoMaxY);
        }
        if (temp.y == -1 && Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            camara.orthographicSize -= 0.1f;
            Vector2 tamaños;
            tamaños.x = 0.4f;
            tamaños.y = 0.2f;
            coli.size -= tamaños;
            camara.orthographicSize = (camara.orthographicSize < 1.252699f) ? 1.252699f : camara.orthographicSize;
            float tamañoMaxX = (coli.size.x < 4.389064) ? 4.389064f : coli.size.x;
            float tamañoMaxY = (coli.size.y < 2.518923f) ? 2.518923f : coli.size.y;
            coli.size = new Vector2(tamañoMaxX, tamañoMaxY);
        }

        switch (var.contador)
        {
            case (0):
                camara.orthographicSize = 4.836329f;
                coli.size = new Vector2(17.2616f, 9.656432f);
                coli.offset = new Vector2(-0.004140854f, -0.007456303f);
                var.contador = -1;

                break;

            case (1):
                velocidad = 2;
                camara.orthographicSize = 3.582768f;
                coli.size = new Vector2(12.73041f, 7.17918f);
                coli.offset = new Vector2(-0.004140377f, -0.01030564f);

                break;

            case (2):
                velocidad = 2.5f;
                camara.orthographicSize = 2.488615f;
                coli.size = new Vector2(8.860469f, 4.981754f);
                coli.offset = new Vector2(-4.768372e-07f, 0.002515912f);


                break;
        }

    }
    IEnumerator TiempoEspera()
    {
        yield return new WaitForSeconds(0.01f);
        desi = false;

    }

    public void AlcanzarObjetivo(Vector3 objetivo)
    {

        var distancia = objetivo - transform.position;
        Vector3 nuevaPosicion = transform.position;

        if (distancia.x < minX)
        {
            nuevaPosicion.x -= distancia.x - minX;
        }
        if (distancia.x > maxX)
        {
            nuevaPosicion.x -= distancia.x - maxX;
        }
        if (distancia.y < minY)
        {
            nuevaPosicion.y -= distancia.y - minY;
        }
        if (distancia.y > maxY)
        {
            nuevaPosicion.y -= distancia.y - maxY;
        }
        if (mouseposition2 != Camera.main.ScreenToWorldPoint(Input.mousePosition))
        {

            transform.position = Vector3.MoveTowards(transform.position, nuevaPosicion, velocidad * Time.deltaTime);
        }

    }
    public void ArribaA()
    {
        var.aDondeIr = "d";
    }
    public void ArribaD()
    {
        var.aDondeIr = "";
    }

    public void AbajoA()
    {
        var.aDondeIr = "c";
    }
    public void AbajoD()
    {
        var.aDondeIr = "";
    }

    public void IzquierdaA()
    {
        var.aDondeIr = "b";
    }
    public void IzquierdaD()
    {
        var.aDondeIr = "";
    }

    public void DerechaA()
    {
        var.aDondeIr = "a";
    }
    public void DerechaD()
    {
        var.aDondeIr = "";
    }

  

}
