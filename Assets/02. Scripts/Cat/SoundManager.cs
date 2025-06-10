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

               /* audioSource.clip = bgmclip;*/ // ����� �ҽ��� ���� ���� ����
            audioSource.playOnAwake = true; // ������ �� �ڵ� ���
            audioSource.loop = true; // �ݺ� ���
            audioSource.volume = 0.5f; //�Ҹ� ����

            audioSource.Play(); // ����

            // audioSource.Stop(); // ����
            // audioSource.Pause(); // �Ͻ�����
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

