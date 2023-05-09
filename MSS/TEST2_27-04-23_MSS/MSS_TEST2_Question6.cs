// -- TEST2 SLO QUESTION 6 --//
// -- Miguel Santos --//

// Chemin d'accès :
// O:\APPLICATIONS\Echanges_Eleves\ES\SLO2\Santos_Miguel\Epreuves\POBJ\TEST2_27-04-23_MSS

// ANCIENNE VERSION EN C
void CalculMoyennePOBJ(int *nbrNoteMax, float *ptTbNote, float *moyenne)
{
	//-- Déclaration variable --//
	int increment;
	float sommeNote = 0;
	for(increment = 0; increment < *nbrNoteMax; increment++)
		sommeNote += ptTbNote[increment];
	
	*moyenne = sommeNote / *nbrNoteMax;
}

// NOUVELLE VERSION EN C#
public void CalculMoyennePOBJ(ref int nbrNoteMax, ref float [] ptTbNote, out float moyenne)
{
	//-- Déclaration variable --//
	int increment;
	float sommeNote = 0;
	for (increment = 0; increment < nbrNoteMax; increment++)
		sommeNote += ptTbNote[increment];

	moyenne = sommeNote / nbrNoteMax;
}