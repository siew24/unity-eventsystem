using InputSamples.Drawing;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/OnCanvasDragged")]
public class OnCanvasDragged : BaseEvent<OnCanvasDragged, CanvasDraggedListener, PointerInput, double>
{

}