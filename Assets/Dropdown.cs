using System;
using UnityEngine;

public class Dropdown : MonoBehaviour
{
    [SerializeField] private GameObject[] panels = new GameObject[3];

    private void Start()
    {
        Open(0);
    }

    public void Open(int idx)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == idx);
        }
    }
    
}
