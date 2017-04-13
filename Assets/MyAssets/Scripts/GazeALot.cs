using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class GazeALot : MonoBehaviour
{

    public Material greyMaterial;
    public Material redMaterial;
    
    private GazeManager gazeManager;

    // Use this for initialization
    void Start()
    {
        gazeManager = GazeManager.Instance;
        gazeManager.FocusedObjectChanged += OnFocusedObjectChanged;
    }

    private void OnFocusedObjectChanged(GameObject previousObject, GameObject newObject)
    {
        Debug.Log("OnFocusedObjectChanged");
        if ((newObject != null) && newObject.name.StartsWith("Lot")) // Is this a lot cube?
        {
            newObject.GetComponent<MeshRenderer>().material = redMaterial;
        }
        if ((previousObject != null) && previousObject.name.StartsWith("Lot"))
        {
            previousObject.GetComponent<MeshRenderer>().material = greyMaterial;
        }
    }
}
