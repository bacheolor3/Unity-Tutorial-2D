using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel; // 페이드 이미지   

    public void OnFade(float fadeTime, Color color, bool isFadeStart)
    {
        Debug.Log("OnFade");
        // StopAllCoroutines();
        StartCoroutine(Fade(fadeTime, color, isFadeStart));
    }

    IEnumerator Fade(float fadeTime,Color color, bool isFadeStart)
    {
        Debug.Log("Fade Routine");

        float timer = 0f;
        float percent = 0f;

        while (percent < 1f)
        {
            float value = isFadeStart ? percent : 1 - percent;

            timer += Time.deltaTime;
            percent = timer / fadeTime;

            Debug.Log("value : " + value);

            fadePanel.color = new Color(color.r, color.g, color.b, value);
            yield return null;
        }
    }
}
