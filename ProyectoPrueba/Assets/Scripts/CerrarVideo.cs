using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class CerrarVideo : MonoBehaviour
{
    public VideoPlayer videoUnam;
    public PantallaInicioDos varAnimTem;
    // Start is called before the first frame update
    void Start()
    {
        videoUnam = GetComponent<VideoPlayer>();
        videoUnam.Play();
        videoUnam.loopPointReached += CheckOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckOver(VideoPlayer videoUnas)
    {
        varAnimTem.FinAnimationBot();
    }
}
