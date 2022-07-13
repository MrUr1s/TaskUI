using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RadioBox : MonoBehaviour
{
    [SerializeField]
    GameObject m_Check;
    [SerializeField]
    RadioBoxType m_RadioBoxType;
    void Start()
    {

       
        switch(m_RadioBoxType)
        {
            case RadioBoxType.main:
                Event_system.mainEvent.Subcribe(MainCheck);
                break;
            case RadioBoxType.music:
                m_Check = Instantiate(m_Check, GetComponentInChildren<SpriteRenderer>().transform);
                Event_system.musicEvent.Subcribe(Check);
                break;
        }
        Check(false);
    }

    private void Check(bool value)
    {
        m_Check.SetActive(value);
    }

    private void MainCheck(bool value)
    {
        m_Check.SetActive(value);
    }

    private void OnMouseDown()
    {
        switch (m_RadioBoxType)
        {
            case RadioBoxType.main:
                Event_system.mainEvent.Publish(false);
                break;
            case RadioBoxType.music:
                Event_system.musicEvent.Publish(false);                
                break;
        }
        Check(true);

    }
}
