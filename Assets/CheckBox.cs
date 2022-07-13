using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    [SerializeField]
    bool m_Checked;
    [SerializeField]
    GameObject m_Check;
    private void Start()
    {
        m_Check = Instantiate(m_Check, GetComponentInChildren<SpriteRenderer>().transform);
        m_Check.SetActive(false);
    }
    private void OnMouseDown()
    {
        m_Checked = !m_Checked;
        m_Check.SetActive(m_Checked);
    }
}
