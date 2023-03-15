using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private RaycastHit hit;
    private string selectableTag = "Selectable";
    private string selectedTag = "Selected";
    private Transform selection;
    private Transform objSelection;
    private GameObject selectedGO = null;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("test: "+ selectedGO);
        if (objSelection != null)
        {
            //var selectionOutline = objSelection.gameObject.GetComponent<Outline>();
            //selectionOutline.enabled = false;
            //Debug.Log("disabled");
            objSelection = null;
            selectedGO = null;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                selectedGO = selection.gameObject;
                //note: outline werkt, niet op imported asset
                //var selectionOutline = selection.gameObject.GetComponent<Outline>();
                //if (selectionOutline != null)
                //{
                //    selection.gameObject.GetComponent<Outline>().enabled = true;
                //    Debug.Log("enabled");
                //}
                //else
                //{
                //    selectionOutline = selection.gameObject.AddComponent<Outline>();
                //    selection.gameObject.GetComponent<Outline>().enabled = true;
                //    Debug.Log("outline component added");
                //}
                objSelection = selection;

                if (Input.GetMouseButton(0))
                {
                    selection.gameObject.tag = selectedTag;
                    Debug.Log("Object selected, tag changes to selected");
                    //code events
                }
            }
        }
    }
}
