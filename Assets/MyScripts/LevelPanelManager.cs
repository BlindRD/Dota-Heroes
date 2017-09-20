using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPanelManager : MonoBehaviour {

    public GameObject mainPanel, levelsPanel, endlessPanel, SGridPanel, MGridPanel, BGridPanel, XXLGridPanel;

	// Use this for initialization
	void Start () {
        ActivePanel(mainPanel);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ActivePanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        levelsPanel.SetActive(false);
        endlessPanel.SetActive(false);
        SGridPanel.SetActive(false);
        MGridPanel.SetActive(false);
        BGridPanel.SetActive(false);
        XXLGridPanel.SetActive(false);
        //-----------------------
        panel.SetActive(true);
    }
}
