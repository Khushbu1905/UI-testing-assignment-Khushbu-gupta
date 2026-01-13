using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Video;
using Button = UnityEngine.UI.Button;
using Unity.VisualScripting;

public class videoplayerui : MonoBehaviour
{
    public Button playButton;
    public Button pauseButton;
    //public Slider Videoslider;

    private VisualElement videoUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //playButton = root.Q<Button>("play");
        //pauseButton = root.Q<Button>("pause");
        //Videoslider = root.Q<Slider>("videoslider");

        //playButton.RegisterCallback<ClickEvent>(Playvideo);
        //pauseButton.RegisterCallback<ClickEvent>(PauseVideo);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
