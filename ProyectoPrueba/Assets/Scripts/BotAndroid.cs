using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="BotAndroid", menuName ="Estaticos/DatosMenu", order =1)]

public class BotAndroid : ScriptableObject
{
    public bool activador = false;
    public string aDondeIr;
    public int contador = 0;
    public bool pc = false,video=false;
}
