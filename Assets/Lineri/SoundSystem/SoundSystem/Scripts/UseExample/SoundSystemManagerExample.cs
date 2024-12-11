using UnityEngine;
using Lean.Touch;
using Lineri.SoundSystem;

public class SoundPocketControllerExample : MonoBehaviour
{
    [Header("===STREAM_EVENTS===")]
    [Header("Music / Time based events")]
    [SerializeField] private ActionSoundPocketManager music;

    [Header("===SFX_EVENTS===")]
    [Header("Oneshots")]
    [SerializeField] private ActionSoundPocketManager circleRotationSound;

    private void OnEnable() 
    {
        //LeanDragRotateRelative.RotationTresholdAchived += circleRotationSound.ActionPlayHandler;
    }
    private void OnDisable()
    {        
        //LeanDragRotateRelative.RotationTresholdAchived -= circleRotationSound.ActionPlayHandler;
    }
}
