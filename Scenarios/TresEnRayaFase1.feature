Feature: TresEnRayaFase1
	I have a empty 3x3 board
	I have white and red pieces and red pieces and must be placed in board
	First piece in board must be a white piece

@TresEnRayaFase1
Scenario: Tres En Raya Fase 1
	Given I have a empty 3x3 table
	And I have white and red pieces and must be placed in board
	When I put first piece
	Then The first pice must be white piece
