using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPanelController : MonoBehaviour
{
    public GameObject resultPanel;

    public void ShowResultPanel()
    {
        resultPanel.SetActive(true);
    }

    public void HideResultPanel()
    {
        resultPanel.SetActive(false);
    }
}
