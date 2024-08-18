using Godot;

public abstract partial class CharacterState : Node
{
    protected Characters characterNode;

    public override void _Ready()
    {
        characterNode = GetOwner<Characters>();
        SetPhysicsProcess(false);
        SetProcessInput(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == PlayerUnitConst.PLAYER_UNIT_STATE_ENABLED)
        {
            EnterState();
            SetPhysicsProcess(true);
            SetProcessInput(true);
        }
        else if (what == PlayerUnitConst.PLAYER_UNIT_STATE_DISABLED)
        {

            SetPhysicsProcess(false);
            SetProcessInput(false);
            ExitState();
        }
    }

    protected virtual void EnterState() { }
    protected virtual void ExitState() { }
}