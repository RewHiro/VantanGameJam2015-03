using UnityEngine;
using System.Collections;

public class OptionManager : MonoBehaviour {

    enum State
    {
        Enable,
        Unavailable,
    };

    State bgm = State.Enable;
    State se = State.Enable;

    /// <summary>
    /// BGMのミュート機能をオンオフ切り替える
    /// </summary>
    /// <param name="player"></param>
    public void ChangeBgmMute(BGMPlayer player)
    {
        if (bgm == State.Enable)
        {
            BgmMuteUnavailable(player);
        }
        else if (bgm == State.Unavailable)
        {
            BgmMuteEnable(player);
        }
    }

    /// <summary>
    /// SEのミュート機能をオンオフ切り替える
    /// </summary>
    /// <param name="player"></param>
    public void ChangeSeMute(SoundEffectPlayer player)
    {
        if (se == State.Enable)
        {
            SeMuteUnavailable(player);
        }
        else if (se == State.Unavailable)
        {
            SeMuteEnable(player);
        }
    }

    /// <summary>
    /// BGMをミュートにする
    /// </summary>
    /// <param name="player"></param>
    void BgmMuteEnable(BGMPlayer player)
    {
        player.Mute();
        bgm = State.Enable;
    }

    /// <summary>
    /// SEをミュートにする
    /// </summary>
    /// <param name="player"></param>
    void SeMuteEnable(SoundEffectPlayer player )
    {
        se = State.Enable;
        player.AllMute();
    }

    /// <summary>
    /// BGMのミュートを解除
    /// </summary>
    /// <param name="player"></param>
    void BgmMuteUnavailable(BGMPlayer player)
    {
        player.MuteUnavailable();
        bgm = State.Unavailable;
    }

    /// <summary>
    /// SEミュート解除
    /// </summary>
    /// <param name="player"></param>
    void SeMuteUnavailable(SoundEffectPlayer player)
    {
        se = State.Unavailable;
        player.AllMuteUnavailable();
    }

}
