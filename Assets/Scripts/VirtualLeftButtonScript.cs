using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualLeftButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    [SerializeField] private AutoMoveObject m_CubeController = null;

    [SerializeField] private VirtualButtonBehaviour m_virtualButton = null;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        m_virtualButton.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour go)
    {
        m_CubeController.SetDirection(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour go)
    {
        m_CubeController.StopRotate();
    }

}