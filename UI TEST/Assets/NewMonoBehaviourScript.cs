using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Button startbutton;
    private Button loginbutton;

    private VisualElement emaillogin;
    private VisualElement testing;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        startbutton = root.Q<Button>("startbutton");
        loginbutton = root.Q<Button>("login");
        emaillogin = root.Q<VisualElement>("emaillogin");
        testing = root.Q<VisualElement>("testing");

        //startbutton.RegisterCallback<ClickEvent>(startlogin);
        //loginbutton.RegisterCallback<ClickEvent>(loginfn);

        
    }

    public void startlogin()
    {
        Debug.Log("working");
        emaillogin.style.display = DisplayStyle.Flex;
        testing.style.display = DisplayStyle.None;
    }

    private void loginfn(ClickEvent evt)
    {
        Debug.Log("working");
    }

}    
