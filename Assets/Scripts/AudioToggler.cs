using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AudioToggler : VolumeChanger
{
    private const string MasterParameter = "Master";

    private const float MaxVolume = 0;
    private const float MinVolume = -80;

    private Button _button;

    private bool _isEnabledAudio;

    private void Awake() =>
        _button = GetComponent<Button>();

    private void OnEnable() =>
        _button.onClick.AddListener(ToggleAudio);

    private void OnDisable() =>
        _button.onClick.RemoveListener(ToggleAudio);

    private void ToggleAudio()
    {
        if (_isEnabledAudio)
        {
            ChangeVolume(MasterParameter, MinVolume);
            _isEnabledAudio = false;
        }
        else
        {
            ChangeVolume(MasterParameter, MaxVolume);
            _isEnabledAudio = true;
        }
    }
}