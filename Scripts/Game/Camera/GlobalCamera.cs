using Godot;
using System;

public partial class GlobalCamera : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public CameraOwner CameraOwnerNode { get; private set;}
    [Export] public StateMachine StateMachineNode { get; private set;}
    public Vector2 direction = new();
    public override void _Ready()
    {
        base._Ready();
    }
    
    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector
        (
            CameraConst.CAMERA_UP,
            CameraConst.CAMERA_DOWN,
            CameraConst.CAMERA_LEFT,
            CameraConst.CAMERA_RIGHT
        );
    }
}