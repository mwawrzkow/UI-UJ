using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInstanceModel : MonoBehaviour
{
    public string PanelId;
    public GameObject PanelInstance;
    protected UIController parent; 
    public void SetActive(bool val, bool setPositionToZero = true)
    {
         PanelInstance.SetActive(val);
        if(setPositionToZero) 
            PanelInstance.transform.position = Vector3.zero;
    }

    public void Register(UIController uI)
    {
        PanelInstance.SetActive(false);
        parent = uI; 
    }
}
