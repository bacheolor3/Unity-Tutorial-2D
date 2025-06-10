using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip introBgmclip;
        public AudioClip bgmclip;

        public AudioClip jumpClip;
        public AudioClip colliderClip;


        public void SetBgmSound(string bgmName)
        {
            if (bgmName == "Intro")
                audioSource.clip = introBgmclip;
            else if (bgmName == "Play")
                audioSource.clip = bgmclip;

               /* audioSource.clip = bgmclip;*/ // 오디오 소스에 사운드 파일 설정
            audioSource.playOnAwake = true; // 시작할 때 자동 재생
            audioSource.loop = true; // 반복 기능
            audioSource.volume = 0.5f; //소리 음량

            audioSource.Play(); // 시작

            // audioSource.Stop(); // 정지
            // audioSource.Pause(); // 일시정지
        }
        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }

        public void OnColliderSound()
        {
            audioSource.PlayOneShot(colliderClip);
        }
    }

}

