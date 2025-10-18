using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    private const string MasterParameter = "Master";
    private const string ButtonSoundParameter = "ButtonSound";
    private const string BackgroundMusicParameter = "BackgroundMusic";

    private const float MaxVolume = 0;
    private const float MinVolume = -80;

    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isEnabledAudio;

    public void ToggleAudio()
    {
        if (_isEnabledAudio)
        {
            SetMasterVolume(MinVolume);
            _isEnabledAudio = false;
        }
        else
        {
            SetMasterVolume(MaxVolume);
            _isEnabledAudio = true;
        }
    }

    public void SetMasterVolume(float volume) =>
        ChangeVolume(MasterParameter, volume);

    public void SetButtonSoundVolume(float volume) =>
        ChangeVolume(ButtonSoundParameter, volume);

    public void SetBackgroundMusicVolume(float volume) =>
        ChangeVolume(BackgroundMusicParameter, volume);

    private void ChangeVolume(string parameter, float volume) =>
        _audioMixerGroup.audioMixer.SetFloat(parameter, Mathf.Log10(volume) * 20);
}