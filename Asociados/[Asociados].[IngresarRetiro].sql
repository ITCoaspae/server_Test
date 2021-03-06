USE [SIF]
GO
/****** Object:  StoredProcedure [Asociados].[IngresarRetiro]    Script Date: 15/05/2020 14:51:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Martinez,Javier>

-- =============================================
ALTER PROCEDURE [Asociados].[IngresarRetiro]
@NoSolicitudRetiro int,
@Dui char(20),
@Observacion varchar(100),
@ActaNo varchar(20),
@FechaActa date,
@usuario Varchar(20),
@fechaUsuario date
as 
BEGIN
BEGIN TRAN RETIRO
BEGIN TRY
	INSERT INTO RETIROS 
	(
		NoSolicitudRetiro,Dui, 
		Observacion,ActaNo,
		FechaActa,Usuario,
		FechaUsuario,Anulado
	)VALUES(
		@NoSolicitudRetiro,@Dui,
		@Observacion,@ActaNo,
		@FechaActa,@usuario,
		@fechaUsuario,'0'
	)

	-- liquidamos cuentas de asociado
	 exec [Asociados].[LiquidacionCuentas_RenunciaAsociados] @dui,@usuario,@fechaUsuario,@NoSolicitudRetiro

	--Actualizamos estado de asociado
	DECLARE @tipoRetiro int 
	select @tipoRetiro = s.idTipoRetiro from SOLICITUDRETIRO s where s.NoSolicitudRetiro = @NoSolicitudRetiro 
	update CAT_ASOCIADOS set EstadoAsociado = @tipoRetiro where DUI = @dui;
	COMMIT TRAN RETIRO
END TRY
BEGIN CATCH

SELECT ERROR_MESSAGE  () + ' LINEA '+ ERROR_LINE  ()+ ' SP: '+ERROR_PROCEDURE()
			declare @spEjecutado varchar(500)
			declare @msjError varchar(500)
			declare @spError varchar(500)
			declare @fechaError datetime
			
			select @spEjecutado = 'Asociados.IngresarRetiro'
			select @msjError = error_message()
			select @spError = error_procedure ()
			select @fechaError =getdate()
			exec [dbo].[Adm_Insert_AdmBitacoraError] 
			@spEjecutado,
			@msjError,
			@spError,			
			@fechaError,
			@Usuario
ROLLBACK TRAN RETIRO
END CATCH 
END

select * from retiros
select * from cat_asociados ca where ca.dui = '00016247-0'