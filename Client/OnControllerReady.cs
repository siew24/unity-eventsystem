using InputSamples.Demo.Drawing;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/OnControllerReady")]
public class OnControllerReady : BaseEvent<OnControllerReady, ControllerReadyListener, DrawingController>
{

}