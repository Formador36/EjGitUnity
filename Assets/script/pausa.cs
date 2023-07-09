using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{
    public GameObject Panel;
    bool PanelActivo = true;


    public void PanelPausa()
    {
        PanelActivo = !PanelActivo;
        Panel.SetActive(PanelActivo);
    
    }

    //Recuerden tener desactivado el panel desde el inicio
}
