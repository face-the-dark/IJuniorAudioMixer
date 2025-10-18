using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(AudioSource))]
public class AudioButton : MonoBehaviour
{
    private Button _button;
    private AudioSource _audioSource;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable() =>
        _button.onClick.AddListener(PlayAudio);

    private void OnDisable() =>
        _button.onClick.RemoveListener(PlayAudio);

    private void PlayAudio() =>
        _audioSource.Play();
}