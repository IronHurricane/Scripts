using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public Camera maincamera;
    public GameObject cameraTarget;
    //Main Menu Buttons
    public Button Play;
    public Button Options;
    public Button Quit;
    public Button Info;

    //Information Assets
    public Image Text_Background;
    public Image Text_Bakcground;
    public Text CurrentVersion;
    public Text GeneralInfo;

    //Quit Assets
    public Button Yes;
    public Button No;
    public Image TextBack;
    public Text AreYouSure;

    //Play Assets
    public Button NewGame;
    public Button ContinueGame;
    public Button Return;

    //Options Assets
    public Button Back;
    public Toggle Mute;
    public Slider MasterVolume;
    public Slider MusicVolume;
    public Slider SoundEffectVolume;
    public Slider ViewDistance;
    public Dropdown GraphicLevel;
    public Text GraphicLevelText;
    public Text Graphics;
    public Text Sounds;

//    private bool play=false;
//    private bool options=false;
//    private bool quit=false;
    private bool info=false;

    public string GameVersion;
    public string Information;

    public void PlayMenu()
    {
        NewGame.enabled = true;
        ContinueGame.enabled = true;
        Return.enabled = true;
//        play = true;
        while (cameraTarget.transform.position.x < 2.25f)
        {
            cameraTarget.transform.Translate(.05f, 0, 0);
        }
    }    
    public void OptionsMenu()
    {
        Play.enabled = false;
        Options.enabled = false;
        Quit.enabled = false;
        Info.enabled = false;
        while (cameraTarget.transform.position.x > -2.25f)
        {
            cameraTarget.transform.Translate(-.05f, 0, 0);
        }
//        options = true;
        Back.enabled=true;
        Mute.enabled = true;
        MasterVolume.enabled = true;
        MusicVolume.enabled = true;
        SoundEffectVolume.enabled = true;
        ViewDistance.enabled = true;
        GraphicLevel.enabled = true;
        GraphicLevelText.enabled = true;
    }
    public void ReturntoMainMenu()
    {
        Back.enabled = false;
        Mute.enabled = false;
        MasterVolume.enabled = false;
        MusicVolume.enabled = false;
        SoundEffectVolume.enabled = false;
        ViewDistance.enabled = false;
        GraphicLevel.enabled = false;
        GraphicLevelText.enabled = false;
        Yes.enabled = false;
        No.enabled = false;
        TextBack.enabled = false;
        AreYouSure.enabled = false;
        NewGame.enabled = false;
        ContinueGame.enabled = false;
        Return.enabled = false;

        Play.enabled = true;
        Options.enabled = true;
        Quit.enabled = true;
        Info.enabled = true;
    }
    public void QuitMenu()
    {
//        quit = true;
        Yes.enabled = true;
        No.enabled = true;
        TextBack.enabled = true;
        AreYouSure.enabled = true;

        Play.enabled = false;
        Options.enabled = false;
        Quit.enabled = false;
        Info.enabled = false;
    }
    public void YesQuit()
    {
        Application.Quit();
    }
    public void ShowCurrentInfo()
    {
        if (info){info = false;}
        else{info = true;}
        Text_Background.enabled = info;
        Text_Bakcground.enabled = info;
        CurrentVersion.enabled = info;
        GeneralInfo.enabled = info;
        string version = "Version: " + GameVersion;
        CurrentVersion.text = version;
        GeneralInfo.text = Information;
    }
    public void MoveCamera()
    {
        if (maincamera.transform.position.x < cameraTarget.transform.position.x)
        {
            while (maincamera.transform.position.x < cameraTarget.transform.position.x)
            {
                maincamera.transform.Translate(.05f, 0, 0);
            }
        }
        else if (maincamera.transform.position.x > cameraTarget.transform.position.x)
        {
            while (maincamera.transform.position.x > cameraTarget.transform.position.x)
            {
                maincamera.transform.Translate(-.05f, 0, 0);
            }
        }
    }
    void Start()
    {
        //Disable info's extras
        Text_Background.enabled = false;
        Text_Bakcground.enabled = false;
        CurrentVersion.enabled = false;
        GeneralInfo.enabled = false;

        //Disable Quit's extras
        Yes.enabled = false;
        No.enabled = false;
        TextBack.enabled = false;
        AreYouSure.enabled = false;

        //Disable Play's extras
        NewGame.enabled = false;
        ContinueGame.enabled = false;
        Return.enabled = false;

        //Disable Options extras
        Back.enabled = false;
        Mute.enabled = false;
        MasterVolume.enabled = false;
        MusicVolume.enabled = false;
        SoundEffectVolume.enabled = false;
        ViewDistance.enabled = false;
        GraphicLevel.enabled = false;
        GraphicLevelText.enabled = false;
    }
    void Update()
    {
       
        //Basic Buttons
        Play.onClick.AddListener(PlayMenu);
        Options.onClick.AddListener(OptionsMenu);
        Quit.onClick.AddListener(QuitMenu);
        Info.onClick.AddListener(ShowCurrentInfo);
        //Quit's Extra Buttons
        Yes.onClick.AddListener(YesQuit);
        No.onClick.AddListener(ReturntoMainMenu);
        //Option's Extra Buttons
        Back.onClick.AddListener(ReturntoMainMenu);
        //Play's Extra Buttons
        Return.onClick.AddListener(ReturntoMainMenu);
    }
}
