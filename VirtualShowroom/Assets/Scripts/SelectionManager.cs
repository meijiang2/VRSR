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
    public GameObject selectedGO = null;
    public GameObject currentSelectedGO = null;

    void Start()
    {
        
    }

    void Update()
    {
        if (objSelection != null)
        {
            var selectionOutline = objSelection.gameObject.GetComponent<Outline>();
            selectionOutline.enabled = false;
            objSelection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionOutline = selection.gameObject.GetComponent<Outline>();
                if (selectionOutline != null)
                {
                    selection.gameObject.GetComponent<Outline>().enabled = true;
                }
                else
                {
                    selectionOutline = selection.gameObject.AddComponent<Outline>();
                    selection.gameObject.GetComponent<Outline>().enabled = true;
                }
                objSelection = selection;
            }
        }

        OnMouseClick();
    }

    public void OnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            if (selection != null && selection.CompareTag(selectableTag))
            {
                selectedGO = selection.gameObject;
                selectedGO.tag = selectedTag;

                if (selectedGO != currentSelectedGO)
                {
                    if (currentSelectedGO != null)
                    {
                        currentSelectedGO.tag = selectableTag;
                    }
                    currentSelectedGO = selectedGO;
                }
            }
        }
    }
}
