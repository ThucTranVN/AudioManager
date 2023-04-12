using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerDemo : MonoBehaviour
{
    [SerializeField]
    private Slider bgmSlider;
    [SerializeField]
    private Slider seSlider;
    [SerializeField]
    private Toggle bgmMute;
    [SerializeField]
    private Toggle seMute;

    private float bgmValue;
    private float seValue;
    private bool isBGMMute;
    private bool isSEMute;

    private void Awake()
    {
        if (AudioManager.HasInstance)
        {
            bgmValue = AudioManager.Instance.AttachBGMSource.volume;
            seValue = AudioManager.Instance.AttachSESource.volume;
            bgmSlider.value = bgmValue;
            seSlider.value = seValue;
            isBGMMute = AudioManager.Instance.AttachBGMSource.mute;
            isSEMute = AudioManager.Instance.AttachSESource.mute;
            bgmMute.isOn = isBGMMute;
            seMute.isOn = isSEMute;
        }
    }

    private void OnEnable()
    {
        if (AudioManager.HasInstance)
        {
            bgmValue = AudioManager.Instance.AttachBGMSource.volume;
            seValue = AudioManager.Instance.AttachSESource.volume;
            bgmSlider.value = bgmValue;
            seSlider.value = seValue;
            isBGMMute = AudioManager.Instance.AttachBGMSource.mute;
            isSEMute = AudioManager.Instance.AttachSESource.mute;
            bgmMute.isOn = isBGMMute;
            seMute.isOn = isSEMute;
        }
    }

    public void OnSliderChangeBGMValue(float v)
    {
        bgmValue = v;
    }

    public void OnSliderChangeSEValue(float v)
    {
        seValue = v;
    }

    public void OnChangeValueBGMMute(bool v)
    {
        isBGMMute = v;
    }

    public void OnChangeValueSEMute(bool v)
    {
        isSEMute = v;
    }

    public void OnPlaySEButtonClick()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySE(AUDIO.SE_COLLECT);
        }
    }

    public void OnPlayBGMButtonClick()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlayBGM(AUDIO.BGM_BGM_04);
        }
    }

    public void OnSubmitButtonClick()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.ChangeBGMVolume(bgmValue);
            AudioManager.Instance.ChangeSEVolume(seValue);
            AudioManager.Instance.MuteBGM(isBGMMute);
            AudioManager.Instance.MuteSE(isSEMute);
        }
    }
}
