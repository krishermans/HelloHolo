using System;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class GestureALot : MonoBehaviour, IInputClickHandler, IFocusable
{
    public Material greyMaterial;
    public Material redMaterial;

    public void OnFocusEnter()
    {
        this.GetComponent<Renderer>().material = redMaterial;
    }

    public void OnFocusExit()
    {
        this.GetComponent<Renderer>().material = greyMaterial;
    }

    public void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("OnInputClicked");
        this.GetComponent<Renderer>().material.color = Color.blue;
    }
}
