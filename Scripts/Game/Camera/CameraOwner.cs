using Godot;
using System;

public partial class CameraOwner : Node
{
    [Export] private Node currentOwner;
    [Export] private Node[] owners;
    public override void _Ready() {
        base._Ready();
    }

    public void SwitchOwner<T>() {
        Node newOwner = null;
        foreach (Node owner in owners) {
            if (owner is T) {
                newOwner = owner;
            }
        }

        if (newOwner == null) { return; }
    }
}
