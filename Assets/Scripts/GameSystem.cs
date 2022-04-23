public class GameSystem : EventBehaviourBase
{
    IExecuter<PointChangedEvent> executer;

    int point;

    private void Awake()
    {
        executer = Regist<PointChangedEvent>();
        Subscribe<ClickEvent>(Clicked);
    }

    void Clicked(ClickEvent ev)
    {
        point += 1;
        executer.Next(new PointChangedEvent() { point = point });
    }
}

public struct PointChangedEvent
{
    public int point;
}