
public abstract class StateBase
{
    public abstract void Enter(StateRunner stateRunner);

    public abstract void Run(StateRunner stateRunner);

    public abstract void Exit(StateRunner stateRunner);
}
