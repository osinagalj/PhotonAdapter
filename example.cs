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

    [SerializeField] private PhotonView photonView;

    void Start()
    {

    }

    public void PVcambiarColor()
    {
        tarea = tareaHolder.transform.Find("Boton(Pleoticus)(Clone)");
        if (tarea != null)
        {
            photonView = tarea.GetComponent<PhotonView>();
            Debug.Log("photonView: " + photonView.ViewID);
            photonView.RPC("cambiarColor", RpcTarget.Others, rojo, verde, azul);
            cambiarColor(rojo, verde, azul);
        } 
    }

    [PunRPC]
    public void cambiarColor(byte rojo2, byte verde2, byte azul2)
    {
        tarea.GetComponent<Image>().color = new Color32(rojo2, verde2, azul2, 255);
    }
}