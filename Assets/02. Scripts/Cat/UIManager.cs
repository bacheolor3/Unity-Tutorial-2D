using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public void OnStartButton()
        {
            nameTextUI.text = inputField.text;
        }
    }

}
