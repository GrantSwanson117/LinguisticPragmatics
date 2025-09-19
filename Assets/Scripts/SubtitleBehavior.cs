using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class SubtitleBehavior : PlayableBehaviour
{
    public string subtitletext;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        TextMeshProUGUI text = playerData as TextMeshProUGUI;
        text.text = subtitletext;
        text.color = new Color(1, 1, 1, info.weight);
    }
}