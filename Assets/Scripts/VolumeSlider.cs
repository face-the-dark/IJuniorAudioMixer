using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : VolumeChanger
{
    [SerializeField] private string _audioMixerParameter;

    private Slider _slider;

    private void Awake() => 
        _slider = GetComponent<Slider>();

    private void OnEnable() =>
        _slider.onValueChanged.AddListener(SetVolume);

    private void OnDisable() =>
        _slider.onValueChanged.RemoveListener(SetVolume);

    private void SetVolume(float volume) =>
        ChangeVolume(_audioMixerParameter, volume);
}