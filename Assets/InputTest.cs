using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{
    [SerializeField] private int m_PlayerIdx;
    [SerializeField] private Text m_Horizontal;
    [SerializeField] private Text m_Vertical;
    [SerializeField] private Text m_Down;
    [SerializeField] private Text m_Right;

    private void Update()
    {
        if (m_PlayerIdx == 1)
        {
            m_Horizontal.text = Input.GetAxis("Joy1Horizontal").ToString();
            m_Vertical.text = Input.GetAxis("Joy1Vertical").ToString();
            m_Down.text = Input.GetKey(KeyCode.Joystick1Button0).ToString();
            m_Right.text = Input.GetKey(KeyCode.Joystick1Button1).ToString();
        }
        else
        {
            m_Horizontal.text = Input.GetAxis("Joy2Horizontal").ToString();
            m_Vertical.text = Input.GetAxis("Joy2Vertical").ToString();
            m_Down.text = Input.GetKey(KeyCode.Joystick2Button0).ToString();
            m_Right.text = Input.GetKey(KeyCode.Joystick2Button1).ToString();
        }
    }
}
