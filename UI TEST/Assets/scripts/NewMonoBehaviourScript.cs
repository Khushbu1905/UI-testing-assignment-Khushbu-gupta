using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public datasave data;
    public database saveddata;
    private Button loginbutton;
    private TextField emailtext;
    private TextField passwordtext;

    private VisualElement emaillogin;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        loginbutton = root.Q<Button>("login");
        emaillogin = root.Q<VisualElement>("emaillogin");
        emailtext = root.Q<TextField>("emailinput");
        passwordtext = root.Q<TextField>("passinput");

        loginbutton.RegisterCallback<ClickEvent>(loginfn);

        
    }

 

    private void loginfn(ClickEvent evt)
    {
        Debug.Log("working");
        saveddata.datasavefn();
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        data.email = emailtext.text;
        data.password = passwordtext.text;
    }

}    
