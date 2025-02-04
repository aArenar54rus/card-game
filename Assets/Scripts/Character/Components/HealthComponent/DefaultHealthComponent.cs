using UnityEngine;

public class DefalutHealthComponent : IHealthComponent
{
    private int health = 100;
    

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health < 0)
            {
                health = 0;
            }

            if (health > 100)
            {
                health = 100;
            }
        }
    }
}
