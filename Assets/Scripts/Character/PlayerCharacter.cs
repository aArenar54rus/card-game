using UnityEngine;

public class PlayerCharacter : Character
{
    public override void Initialize()
    {
        Debug.Log("PlayerCharacter");

        healthComponent = new DefalutHealthComponent();
        Debug.Log(healthComponent.Health);

        healthComponent = new ImmortalHealthComponent();
    }
}
