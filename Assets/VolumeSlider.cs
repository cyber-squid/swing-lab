using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    Slider slider;
    void Awake() 
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        AudioListener.volume = slider.value;
    }
}