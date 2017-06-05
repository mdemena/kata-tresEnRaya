Feature: TresEnRayaFase2
	I have a empty 3x3 board
	I have white and red pieces and red pieces and must be placed in board
	First piece in board must be a white piece

@TresEnRayaFase2
Scenario: Tres En Raya Fase 2
	Given I have a empty 3X3 board
	When In a turn we put a new piece in a empty cell
	Then Not is possible to put two sequence pieces with the same color
