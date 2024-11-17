using UnityEngine;
using TMPro;

public class InputFieldGrabber : MonoBehaviour
{

    public string UsernameInputText;
    public string TeamNameInputText;


    public void UsernameInputField(string input)
    {
        UsernameInputText = input;
    }
    
    public void TeamNameInputField(string input)
    {
        TeamNameInputText = input;
    }
}
