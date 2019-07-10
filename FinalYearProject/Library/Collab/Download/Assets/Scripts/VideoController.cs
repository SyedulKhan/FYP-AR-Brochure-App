using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

[RequireComponent(typeof(VideoPlayer))]
public class VideoController : MonoBehaviour
{
    public VideoPlayer vid;
    public Button playBtn;
    public RectTransform progBar;

    /* The method below was adapted

       Vuforia. (2019). Vuforia Core Samples. Vuforia. Available at:
       https://assetstore.unity.com/packages/templates/packs/vuforia-core-samples-99026 [Accessed 10 January 2019] 
    */

    void Update()
    {

        if (vid.isPlaying)
        {
            PlayBtnVisibility(false);

            if (vid.frameCount < float.MaxValue)
            {
                float currentFrame = (float)vid.frame; //Takes the current frame of video
                float totalFrameCount = (float)vid.frameCount; //Takes the total frame count

                float progress = 0; //Percentage of current progress

                if (totalFrameCount > 0)
                    //Calculates the percentage of the video currently playing
                    progress = (currentFrame / totalFrameCount) * 100.0f;

                if (progBar != null)
                    //Shows the progress bar on the UI
                    progBar.sizeDelta = new Vector2((float)progress, progBar.sizeDelta.y);
            }

        }
        else
        {
            PlayBtnVisibility(true);
        }
    }

    /*  The method below was originally created by Vuforia

        Vuforia. (2019). Vuforia Core Samples. Vuforia. Available at:
        https://assetstore.unity.com/packages/templates/packs/vuforia-core-samples-99026 [Accessed 10 January 2019]
    */
    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            PauseVideo();
        }
    }

    public void PlayVideo()
    {
        PauseAudioClip(false);
        vid.Play();
        PlayBtnVisibility(false);
    }

    public void PauseVideo()
    {
        if (vid)
        {
            PauseAudioClip(true);
            vid.Pause();
            PlayBtnVisibility(true);
        }
    }

    /*  The method below was originally created by Vuforia

        Vuforia. (2019). Vuforia Core Samples. Vuforia. Available at:
        https://assetstore.unity.com/packages/templates/packs/vuforia-core-samples-99026 [Accessed 10 January 2019]
    */
    private void PauseAudioClip(bool pause)
    {
        for (ushort trackNumber = 0; trackNumber < vid.audioTrackCount; ++trackNumber)
        {
            if (pause)
            {
                vid.GetTargetAudioSource(trackNumber).Pause();
            }
            else
            {
                vid.GetTargetAudioSource(trackNumber).UnPause();

            }
        }
    }

    /*  The method below was adapted

        Vuforia. (2019). Vuforia Core Samples. Vuforia. Available at:
        https://assetstore.unity.com/packages/templates/packs/vuforia-core-samples-99026 [Accessed 10 January 2019] 
    */
    private void PlayBtnVisibility(bool visible)
    {
        playBtn.enabled = visible;
        playBtn.GetComponent<Image>().enabled = visible;
    }
}
