using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;
    private VideoPlayer videoPlayer;
    public VideoClip[] clips; // 영상 파일 배열

    public int currClipIndex = 0; // 현재 영상 Index(순번)

    // public bool isOn = false;
    public bool isMute = false;

    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[currClipIndex]; // 처음 영상 설정해 둔 것. 디폴트(Default) 영상. 현재 채널이라 보면 편함
    }

    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {
        // GameObject 속성 활용해서 적은 방법
        videoScreen.SetActive(!videoScreen.activeSelf);

        //isOn = !isOn;
        //videoScreen.SetActive(isOn);

        //bool isScreenOn = videoScreen.activeSelf;

        //if (!isOn)
        //{
        //    videoScreen.SetActive(true);
        //    isOn = true; // 현재 TV ON
        //}
        //else // isOn == true
        //{
        //    videoScreen.SetActive(false);
        //    isOn = false;
        //}
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute); // 영상의 소리 음소거

        // 현재 영상의 Mute 속성을 활용한 방법
         videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0)); 
    }

    public void OnChangeChannel(bool isNext)
    {
        int value = isNext ? 1 : -1;
        currClipIndex += value;

        if (currClipIndex > clips.Length - 1)
            currClipIndex = 0;
        if (currClipIndex < 0)
            currClipIndex = clips.Length - 1;

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }

    public void OnNextChannel() // 오른쪽 버튼
    {
        currClipIndex++;
        if(currClipIndex >= clips.Length -1)
        {
            currClipIndex = 0;
        }

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel() // 왼쪽 버튼
    {
        currClipIndex--;
        if(currClipIndex < 0)
        {
            currClipIndex = clips.Length-1 ;
        }

        videoPlayer.clip = clips[currClipIndex];
        videoPlayer.Play();
    }
}
