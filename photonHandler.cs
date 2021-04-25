using Photon.Pun;

public class PhotonHandler{

    [SerializeField] private PhotonView photonView;

    public void PVcambiarColor(byte rojo,byte verde,byte azul;Transform tarea)
    {
        if (tarea != null)
        {
            photonView = tarea.GetComponent<PhotonView>();
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