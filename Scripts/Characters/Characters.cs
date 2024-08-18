using Godot;

public abstract partial class Characters : CharacterBody3D {
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer AnimationPlayerNode {get; private set;}
    [Export] public Sprite3D SpritePlayerNode {get; private set;}
    [Export] public StateMachine StateMachineNode {get; private set; }
    public Vector2 direction = new();
}