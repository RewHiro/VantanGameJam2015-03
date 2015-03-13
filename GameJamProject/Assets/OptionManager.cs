using UnityEngine;
using System.Collections;

public class OptionManager : MonoBehaviour {

    /// <summary>
    /// BGMをミュートにする
    /// </summary>
    /// <param name="player"></param>
    public void BgmMuteEnable(BGMPlayer player)
    {
        player.Mute();
    }

    /// <summary>
    /// SEをミュートにする
    /// </summary>
    /// <param name="player"></param>
    public void SeMuteEnable(SoundEffectPlayer player )
    {
        player.AllMute();
    }

    /// <summary>
    /// BGMのミュートを解除
    /// </summary>
    /// <param name="player"></param>
    public void BgmMuteUnavailable(BGMPlayer player)
    {
        player.MuteUnavailable();
    }

    /// <summary>
    /// SEミュート解除
    /// </summary>
    /// <param name="player"></param>
    public void SeMuteUnavailable(SoundEffectPlayer player)
    {
        player.AllMuteUnavailable();
    }

}
