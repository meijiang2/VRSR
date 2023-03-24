using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChangePreset : MonoBehaviour
{
    //standard car values & wheels
    #region
    public MeshRenderer bodyMeshRend;
    public MeshRenderer doorMeshRend;
    public MeshRenderer doorHandleMeshRend;
    public MeshRenderer seatMeshRend;
    public MeshRenderer steeringWheelMeshRend;

    private Material[] bodyMats;
    private Material[] doorMats;
    private Material doorHandleMat;
    private Material seatMat;
    private Material steeringWheelMat;

    public GameObject stdFrontWheels;
    public GameObject stdBackWheels;
    public GameObject wheels1;

    public Material lakP1;
    public Material lakP2;
    public Material lakP3;
    public Material intP1;
    public Material intP2;
    public Material intP3;
    #endregion

    void Awake()
    {
        bodyMats = bodyMeshRend.sharedMaterials;
        doorMats = doorMeshRend.sharedMaterials;
        doorHandleMat = doorHandleMeshRend.material;
        seatMat = seatMeshRend.material;
        steeringWheelMat = steeringWheelMeshRend.material;

        stdFrontWheels.SetActive(true);
        stdBackWheels.SetActive(true);
        wheels1.SetActive(false);
    }

    public void ChangeCarToP1()
    {
        bodyMats[0] = lakP1;
        bodyMats[2] = intP1;
        doorMats[1] = lakP1;
        doorMats[2] = lakP1;
        doorMats[0] = intP1;
        doorHandleMat = lakP1;
        seatMat = intP1;
        steeringWheelMat = intP1;

        bodyMeshRend.sharedMaterials = bodyMats;
        doorMeshRend.sharedMaterials = doorMats;
        doorHandleMeshRend.material = doorHandleMat;
        seatMeshRend.material = seatMat;
        steeringWheelMeshRend.material = steeringWheelMat;

        stdFrontWheels.SetActive(true);
        stdBackWheels.SetActive(true);
        wheels1.SetActive(false);
    }

    public void ChangeCarToP2()
    {
        bodyMats[0] = lakP2;
        bodyMats[2] = intP2;
        doorMats[1] = lakP2;
        doorMats[2] = lakP2;
        doorMats[0] = intP2;
        doorHandleMat = lakP2;
        seatMat = intP2;
        steeringWheelMat = intP2;

        bodyMeshRend.sharedMaterials = bodyMats;
        doorMeshRend.sharedMaterials = doorMats;
        doorHandleMeshRend.material = doorHandleMat;
        seatMeshRend.material = seatMat;
        steeringWheelMeshRend.material = steeringWheelMat;

        stdFrontWheels.SetActive(false);
        stdBackWheels.SetActive(false);
        wheels1.SetActive(true);
    }

    public void ChangeCarToP3()
    {
        bodyMats[0] = lakP3;
        bodyMats[2] = intP3;
        doorMats[1] = lakP3;
        doorMats[2] = lakP3;
        doorMats[0] = intP3;
        doorHandleMat = lakP3;
        seatMat = intP3;
        steeringWheelMat = intP3;

        bodyMeshRend.sharedMaterials = bodyMats;
        doorMeshRend.sharedMaterials = doorMats;
        doorHandleMeshRend.material = doorHandleMat;
        seatMeshRend.material = seatMat;
        steeringWheelMeshRend.material = steeringWheelMat;

        stdFrontWheels.SetActive(true);
        stdBackWheels.SetActive(true);
        wheels1.SetActive(false);
    }
}
