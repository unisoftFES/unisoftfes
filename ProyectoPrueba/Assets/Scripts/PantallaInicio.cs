using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameObject))]
public class PantallaInicio : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(contadorPantalla()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InicioPantalla()
    {
        SceneManager.LoadScene("Uno");
    }

    public IEnumerator contadorPantalla()
    {
        yield return new WaitForSeconds(15);
        InicioPantalla();
    }
}
