using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class TimelineTimeScale : MonoBehaviour
{
    public float timelineSpeed; //The speed of the timeline object

    void Awake()
    {
        var dir = GetComponent<PlayableDirector>();
        if (dir != null)
        {
            dir.played += SetTimelineSpeed;
            SetTimelineSpeed(dir); //Sets the speed of the director component of the timeline
        }
    }

    void SetTimelineSpeed(PlayableDirector dir)
    {
        if (dir != null && dir.playableGraph.IsValid())
        {
            dir.playableGraph.GetRootPlayable(0).SetSpeed(timelineSpeed); //The speed is set
        }
    }

    void OnValidate()
    {
        SetTimelineSpeed(GetComponent<PlayableDirector>()); //Updates the timeline scale
    }
}