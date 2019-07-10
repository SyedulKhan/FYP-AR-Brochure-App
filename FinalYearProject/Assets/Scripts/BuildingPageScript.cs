using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BuildingPageScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject map;
    VirtualButtonBehaviour vBtn;

    // Start is called before the first frame update
    void Start()
    {
        vBtn = GetComponentInChildren<VirtualButtonBehaviour>();
        vBtn.RegisterEventHandler(this);
        map.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        map.SetActive(true);
        Debug.Log("BTN PRESSED");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //map.SetActive(false);
        //Debug.Log("BTN RELEASED");
    }


}
