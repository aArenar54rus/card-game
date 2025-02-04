using UnityEngine;

public abstract class Character : MonoBehaviour
{
	public IHealthComponent healthComponent;
	
	
	
	
	public void Awake()
	{
		Initialize();
	}
	
	public abstract void Initialize();
}
