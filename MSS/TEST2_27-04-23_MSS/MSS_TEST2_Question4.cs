//-- CORRECTION GROUPE 5 --//

// -- TEST2 SLO QUESTION 4 --//
// -- Miguel Santos --//

// Chemin d'accès :
// O:\APPLICATIONS\Echanges_Eleves\ES\SLO2\Santos_Miguel\Epreuves\POBJ\TEST2_27-04-23_MSS

public class Test2Exo5
{
	private enum e_states
	{
		INIT = 1, 
		WAIT = 2, 
		EXECUT = 3 
	};

	private void Ex5TestSLO(e_states etat)
	{
		//-- Simulation machine d'état --//
		switch (etat)
		{
			case e_states.INIT:
				System.Console.WriteLine("Activation etat initialisation");
				break;
			case e_states.WAIT:
				System.Console.WriteLine("Activation etat attente");
				break;
			case e_states.EXECUT:
				System.Console.WriteLine("Activation etat execution");
				break;
			default:
				System.Console.WriteLine("Pas d'état activé");
				break;
		}
	}
}
