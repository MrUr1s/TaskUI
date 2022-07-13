using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    int nubmer=0;
    private void OnMouseDown()
    {
    Event_system.taskEvent.Publish(nubmer++);
        
    }
}
