using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NetworkingHandler : MonoBehaviour
{
    void runObjects();

    public abstract void PVcambiarColor(byte rojo,byte verde,byte azul,Transform tarea);

    // void runChat();
    // void runVoice();

    
}