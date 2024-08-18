using Godot;

public abstract partial class GlobalCameraState : Node
{
    protected GlobalCamera cameraNode;

    public override void _Ready()
    {
        cameraNode = GetOwner<GlobalCamera>();
        SetPhysicsProcess(false);
        SetProcessInput(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == PlayerCameraConst.PLAYER_CAMERA_STATE_ENABLED)
        {
            EnterState();
            SetPhysicsProcess(true);
            SetProcessInput(true);
        }
        else if (what == PlayerCameraConst.PLAYER_CAMERA_STATE_DISABLED)
        {

            SetPhysicsProcess(false);
            SetProcessInput(false);
            ExitState();
        }
    }

    protected virtual void EnterState() { }
    protected virtual void ExitState() { }
}