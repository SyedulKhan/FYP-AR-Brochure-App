using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineScript : MonoBehaviour
{
    public List<PlayableAsset> timelineEvents;
    public PlayableDirector playableDirector;

    public void Play(GameObject selectedEvent)
    {
        playableDirector.Play();
    }

    public void PlaySelectedEvent(int index)
    {
        PlayableAsset selectedEvent;

        if (timelineEvents.Count <= index)
        {
            selectedEvent = timelineEvents[timelineEvents.Count - 1];
        }
        else
        {
            selectedEvent = timelineEvents[index];
        }

        playableDirector.Play(selectedEvent);
    }

}
