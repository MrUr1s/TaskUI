using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TaskMoringScript : MonoBehaviour
{
    [SerializeField]
    List<TaskScript> tasks = new List<TaskScript>();
    void Start()
    {
        tasks = GetComponentsInChildren<TaskScript>().ToList() ;
        for (int i = 0; i < tasks.Count; i++)
            tasks[i].Number = i;
    }

    
}
