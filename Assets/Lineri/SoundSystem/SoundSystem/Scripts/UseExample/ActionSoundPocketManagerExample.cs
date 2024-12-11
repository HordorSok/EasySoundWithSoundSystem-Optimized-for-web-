using Lineri.SoundSystem;
using UnityEngine;

public class ActionSoundPocketManagerExample : SoundPocketManager
{
    public void ActionPlayHandler()
    {
        PlayHandler();
        //Debug.Log("[ActionSoundPocketManager] Play Sound");
    }
    public void ActionPauseHandler()
    {
        PauseHandler();
    }
    public void ActionStopHandler()
    {
        StopHandler();
    }
    public void ActionUnpauseHandler()
    {
        UnPauseHandler();
    }
}
