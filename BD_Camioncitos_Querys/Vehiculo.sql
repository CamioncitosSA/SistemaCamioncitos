USE Camioncitos_DB;

-- Creación de la tabla TB_VEHICULO
CREATE TABLE TB_VEHICULO (
    IdVehiculo INT IDENTITY(1,1) PRIMARY KEY,
    TipoVehiculo VARCHAR(50) NOT NULL,
    MarcaV VARCHAR(15) NOT NULL,
    ModeloV VARCHAR(50) NOT NULL,
    PlacaV VARCHAR(8) NOT NULL,
    CapacidadCarga FLOAT NOT NULL,
    Estado VARCHAR(1) NOT NULL
);

-- Procedimiento almacenado para registrar un vehículo
CREATE PROCEDURE REGISTRAR_VEHICULO
    @TipoVehiculo VARCHAR(50),
    @MarcaV VARCHAR(15),
    @ModeloV VARCHAR(50),
    @PlacaV VARCHAR(8),
    @CapacidadCarga FLOAT,
    @Estado VARCHAR(1)
AS
BEGIN
    -- Verifica si ya existe un vehículo con la misma placa
    IF EXISTS(SELECT * FROM TB_VEHICULO WHERE PlacaV = @PlacaV)
    BEGIN
        -- Devolver un mensaje indicando que el vehículo ya existe en el registro
        SELECT 'ERROR: Ya se encuentra registrado el vehículo con Placa: [' + @PlacaV + ']'
        RETURN
    END

    -- Si no existe, entonces crea el vehículo
    INSERT INTO TB_VEHICULO (TipoVehiculo, MarcaV, ModeloV, PlacaV, CapacidadCarga, Estado)
    VALUES (@TipoVehiculo, @MarcaV, @ModeloV, @PlacaV, @CapacidadCarga, @Estado)
    
    -- Devolver un mensaje indicando que el registro se realizó con éxito
    SELECT 'Se ha registrado correctamente el vehículo con Placa: [' + @PlacaV + '].'
END;

-- Procedimiento almacenado para consultar los vehículos
CREATE PROCEDURE CONSULTAR_VEHICULO
AS
BEGIN
    SELECT * FROM TB_VEHICULO;
END;

-- Procedimiento almacenado para actualizar un vehículo
CREATE PROCEDURE ACTUALIZAR_VEHICULO
    @IdVehiculo INT,
    @TipoVehiculo VARCHAR(50),
    @MarcaV VARCHAR(15),
    @ModeloV VARCHAR(50),
    @PlacaV VARCHAR(8),
    @CapacidadCarga FLOAT,
    @Estado VARCHAR(1)
AS 
BEGIN
    -- Verifica que no se ingrese una placa ya existente
    IF EXISTS(SELECT * FROM TB_VEHICULO WHERE PlacaV = @PlacaV AND IdVehiculo <> @IdVehiculo)
    BEGIN 
        SELECT 'ERROR: Ya se encuentra registrado un vehículo con Placa: [' + @PlacaV + ']';
        RETURN
    END
    
    -- Si no existe, entonces actualiza el vehículo
    UPDATE TB_VEHICULO
    SET TipoVehiculo = @TipoVehiculo,
        MarcaV = @MarcaV,
        ModeloV = @ModeloV,
        PlacaV = @PlacaV,
        CapacidadCarga = @CapacidadCarga,
        Estado = @Estado
    WHERE IdVehiculo = @IdVehiculo;
    
    -- Enviar mensaje de actualización exitosa
    SELECT 'Se ha actualizado correctamente el vehículo con Placa: [' + @PlacaV + '].';
END;

-- Procedimiento almacenado para eliminar un vehículo
CREATE PROCEDURE ELIMINAR_VEHICULO
    @IdVehiculo INT
AS
BEGIN
    DELETE FROM TB_VEHICULO
    WHERE IdVehiculo = @IdVehiculo;
    
    SELECT 'Eliminación exitosa del vehículo.'
END;

GO
-- PROCEDIMIENTO VALIDAR_DATOS_VEHICULO
CREATE PROCEDURE VALIDAR_DATOS_VEHICULO
    @TipoVehiculo VARCHAR(50),
    @MarcaV VARCHAR(15),
    @ModeloV VARCHAR(50),
    @PlacaV VARCHAR(8),
    @CapacidadCarga FLOAT,
    @Estado VARCHAR(1),
    @Resultado INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @Resultado = COUNT(*) 
    FROM TB_VEHICULO 
    WHERE TipoVehiculo = @TipoVehiculo AND MarcaV = @MarcaV AND ModeloV = @ModeloV AND PlacaV = @PlacaV AND CapacidadCarga = @CapacidadCarga AND Estado = @Estado;
END;

--DATOS QUEMADOS
EXECUTE REGISTRAR_VEHICULO 'Camioneta', 'Ford', 'Ranger', 'ABC123', 2000.0, 'N';
EXECUTE REGISTRAR_VEHICULO 'Camión', 'Volvo', 'FH16', 'DEF456', 10000.0, 'A';
EXECUTE REGISTRAR_VEHICULO 'Grua', 'Liebherr', 'LTM 11200-9.1', 'GHI789', 50000.0, 'A';
EXECUTE REGISTRAR_VEHICULO 'Camioneta', 'Chevrolet', 'Silverado', 'JKL012', 3000.0, 'A';
EXECUTE REGISTRAR_VEHICULO 'Camión', 'Scania', 'R730', 'MNO345', 15000.0, 'A';



--ELIMINAR TABLA Y PROCEDURES

DROP TABLE TB_VEHICULO;
DROP PROCEDURE REGISTRAR_VEHICULO;
DROP PROCEDURE CONSULTAR_VEHICULO;
DROP PROCEDURE ACTUALIZAR_VEHICULO;
DROP PROCEDURE ELIMINAR_VEHICULO;
DROP PROCEDURE EXISTE_VEHICULO;


