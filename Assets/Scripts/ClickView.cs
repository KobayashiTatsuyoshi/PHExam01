public class ClickView : EventBehaviourBase
{
    IExecuter<ClickEvent> executer;

    private void Awake()
    {
        executer = Regist<ClickEvent>();
    }

    public void Click()
    {
        executer.Next(new ClickEvent());
    }
}

public struct ClickEvent { }
