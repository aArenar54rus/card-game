using UnityEngine;

public class EnemyCharacter : Character
{
	public AiState aiState = AiState.MoveToTarget;
	
	
	public override void Initialize()
	{
		Debug.Log("EnemyCharacter");

		if (aiState == AiState.MoveToTarget)
		{
			// Движемся к цели
		}
		else if (aiState == AiState.AttackTarget)
		{
			// атакуем цель
		}

		switch (aiState)
		{
			case AiState.MoveToTarget:

				break;
			
			case AiState.AttackTarget:

				break;
		}
	}
}
