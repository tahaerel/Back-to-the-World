using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class introscript : MonoBehaviour
{
   
        public TextMeshProUGUI[] texts; 
        public GameObject intro; 
        public GameObject backButton; 
        private int currentTextIndex = 0; 

        private void Start()
        {
            ShowText(currentTextIndex);
            backButton.SetActive(false);
        }

        public void OnNextButtonClick()
        {

        SoundManagerScript.playFlipSound();
            currentTextIndex = (currentTextIndex + 1) % texts.Length;
            ShowText(currentTextIndex);

            if (currentTextIndex == texts.Length - 1)
            {
                CloseIntro();
            }
            backButton.SetActive(true);
        }

        public void OnBackButtonClick()
         {
        SoundManagerScript.playFlipSound();
        currentTextIndex = (currentTextIndex - 1 + texts.Length) % texts.Length;
            ShowText(currentTextIndex);

            if (currentTextIndex == 0)
            {
                OpenIntro();
                backButton.SetActive(false);
            }
        }

        public void ButtonClickClose()
         {
        SoundManagerScript.playFlipSound();
        CloseIntro();
         }

    private void ShowText(int index)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i].gameObject.SetActive(i == index);
            }
        }

        private void CloseIntro()
        {
            if (intro != null)
            {
                intro.SetActive(false);
            }
        }

        private void OpenIntro()
        {
            if (intro != null)
            {
                intro.SetActive(true);
            }
        }
  
}