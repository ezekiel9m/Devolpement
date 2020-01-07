CREATE PROC FI_SP_AltBeneficiario
    @NOME          VARCHAR (50) ,
	@CPF           VARCHAR (15), 
	@Id           BIGINT,
	@IdDescentente BIGINT
AS
BEGIN
	UPDATE Beneficiario 
	SET 
		NOME = @NOME, 
		CPF = @CPF,  
		TELEFONE = @TELEFONE
	WHERE Id = @Id AND IdDescendete = @IdDescentente
END