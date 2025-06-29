using Oculus.Voice;
using UnityEngine;

public class WitActivation : MonoBehaviour
{
    private AppVoiceExperience _voiceExperience;

    private void OnValidate()
    {
        if (!_voiceExperience) _voiceExperience = GetComponent<AppVoiceExperience>();
    }

    private void Start()
    {
        _voiceExperience = GetComponent<AppVoiceExperience>();
    }

    public void ActivateWit()
    {
        _voiceExperience.Activate();
    }
}
