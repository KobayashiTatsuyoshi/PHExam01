using UnityEngine;
using UnityEngine.UI;

public class PointView : EventBehaviourBase
{
    [SerializeField] Text text;

    private void Awake()
    {
        Subscribe<PointChangedEvent>(Changed);
    }

    private void Changed(PointChangedEvent ev)
    {
        text.text = ev.point.ToString();
    }
}
