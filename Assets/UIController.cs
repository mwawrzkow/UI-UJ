using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public List<PanelInstanceModel> panels = new List<PanelInstanceModel> ();
    private PanelInstanceModel currentPanel;

    private void Start()
    {
        foreach (var item in panels)
        {
            item.Register(this); 
        }
        if (panels.Count > 0)
        {
            SetPanel(panels[0].PanelId);  // Optionally set the first panel active
        }
    }

    public void SetPanel(string panelName)
    {
        PanelInstanceModel model = panels.FirstOrDefault(p => p.PanelId == panelName);
        if (model != null)
        {
            if (currentPanel != null) currentPanel.SetActive(false);
            model.SetActive(true);
            currentPanel = model;
        }
        else
        {
            Debug.LogWarning($"This panel does not exist: {panelName}");
        }
    }
}
