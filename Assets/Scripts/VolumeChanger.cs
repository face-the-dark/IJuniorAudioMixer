using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    private const float VolumeModifier = 20;
    
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    protected void ChangeVolume(string parameter, float volume) =>
        _audioMixerGroup.audioMixer.SetFloat(parameter, Mathf.Log10(volume) * VolumeModifier);
}