using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
    [SerializeField]
    int number;
    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    [SerializeField]
    GameObject m_Check;
    void Start()
    {
        m_Check = Instantiate(m_Check, GetComponentInChildren<SpriteRenderer>().transform);
        m_Check.SetActive(false);
        Event_system.taskEvent.Subcribe(Apply);
    }

    private void Apply(int value)
    {
        if(value == number)
            m_Check.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
