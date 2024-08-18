using Godot;
using System;

public partial class PlayerCameraIdleState : PlayerCameraState
{
    public override void _PhysicsProcess(double delta)
    {
        if (cameraNode.direction != Vector2.Zero) {
            GD.Print("PlayerCameraIdleState Off");
            cameraNode.StateMachineNode.SwitchState<PlayerCameraMoveState>();
        }
    }
}