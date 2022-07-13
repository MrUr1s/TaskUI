using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [SerializeField]
    List<RadioBox> radioBoxes = new List<RadioBox>();
    void Start()
    {
        foreach (RadioBox temp in GetComponentsInChildren<RadioBox>())
            radioBoxes.Add(temp);
       // radioBoxes[0].gameObject.SetActive(true);
    }

    
    void Update()
    {
        
    }
}
