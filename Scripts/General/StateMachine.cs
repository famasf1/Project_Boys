using Godot;

public partial class StateMachine : Node  {
    [Export] private Node currentState;
    [Export] private Node[] states;
    public override void _Ready() {
        base._Ready();
    }
 
    public void SwitchState<T>() {
        Node newState = null;
        foreach (Node state in states) {
            if (state is T) {
                newState = state;
            }
        }

        if (newState == null) { return; }
        
   }
}