using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CambiarColor : MonoBehaviour
{
    public byte rojo;
    public byte verde;
    public byte azul;
    public GameObject tareaHolder;
    public Transform tarea;

    public PhotonHandler photonHandler;

    void Start()
    {

    }

    public void changeColor()
    {
        tarea = tareaHolder.transform.Find("Boton(Pleoticus)(Clone)");
        photonHandler.PVcambiarColor(rojo,verde,azul,tarea);
    }

}