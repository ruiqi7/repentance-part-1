using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

// Source: https://www.youtube.com/watch?v=XiJ-kb-NvV4

public class BrightnessController : MonoBehaviour
{
    [SerializeField] private Slider brightnessSlider;
    [SerializeField] private PostProcessProfile brightness;
    [SerializeField] private PostProcessLayer layer;

    AutoExposure exposure;

    void Start()
    {
        brightness.TryGetSettings(out exposure);
        if (!PlayerPrefs.HasKey("brightness"))
        {
            PlayerPrefs.SetFloat("brightness", 2.0f);
        }
        LoadBrightness();
    }

    public void AdjustBrightness(float value)
    {
        exposure.keyValue.value = value;
        SaveBrightness();
    }

    private void LoadBrightness()
    {
        brightnessSlider.value = PlayerPrefs.GetFloat("brightness");
    }

    private void SaveBrightness()
    {
        PlayerPrefs.SetFloat("brightness", brightnessSlider.value);
    }
}
