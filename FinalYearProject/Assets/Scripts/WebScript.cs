using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebScript : MonoBehaviour
{
    public void OpenLocationLink()
    {
        Application.OpenURL("https://www.google.co.uk/maps/place/Alexandra+Palace/@51.5941816,-0.132962,17z/data=!3m1!4b1!4m5!3m4!1s0x48761bd75310a7cd:0x9a38677b79460879!8m2!3d51.5941783!4d-0.1307733");
    }
}
