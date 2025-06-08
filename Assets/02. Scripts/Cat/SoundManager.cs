using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip bgmclip;
        public AudioClip jumpClip;

        private void Start()
        {
            SetBgmSound();
        }

        public void SetBgmSound()
        {
            audioSource.clip = bgmclip; // ����� �ҽ��� ���� ���� ����
            audioSource.playOnAwake = true; // ������ �� �ڵ� ���
            audioSource.loop = true; // �ݺ� ���
            audioSource.volume = 0.1f; //�Ҹ� ����

            audioSource.Play(); // ����

            // audioSource.Stop(); // ����
            // audioSource.Pause(); // �Ͻ�����
        }
        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }
    }

}

