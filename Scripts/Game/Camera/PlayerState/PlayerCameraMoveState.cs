using Godot;

public partial class PlayerCameraMoveState : PlayerCameraState {
    [Export(PropertyHint.Range, "0, 10, 0.1")] public float cameraMoveSpeed = 5.0f;

    public override void _PhysicsProcess(double delta) {
        if (cameraNode.direction == Vector2.Zero) {
            GD.Print("PlayerCameraIdleState Off");
            cameraNode.StateMachineNode.SwitchState<PlayerCameraIdleState>();
            return;
        }

        cameraNode.Velocity = new(
            cameraNode.direction.X,
            0,
            cameraNode.direction.Y
        );

        cameraNode.Velocity *= cameraMoveSpeed;
        cameraNode.MoveAndSlide();

        GD.Print("PlayerCameraMoveState On");
    }
}