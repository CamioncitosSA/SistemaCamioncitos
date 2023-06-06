USE Camioncitos_DB;

-- Creación de la tabla TB_CHOFERES
CREATE TABLE TB_CHOFERES (
    IdChofer INT IDENTITY(1,1) PRIMARY KEY,
    Nombres VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Genero VARCHAR(1) NOT NULL,
    Direccion VARCHAR(100) NOT NULL,
    NumLicencia VARCHAR(20) NOT NULL,
    VenceLicencia DATE NOT NULL,
    DisponibilidadC VARCHAR(1) NOT NULL
);

-- Procedimiento almacenado para registrar un chofer
CREATE PROCEDURE REGISTRAR_CHOFER
    @Nombres VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Genero VARCHAR(1),
    @Direccion VARCHAR(100),
    @NumLicencia VARCHAR(20),
    @VenceLicencia DATE,
    @DisponibilidadC VARCHAR(1)
AS
BEGIN
    -- Verifica si ya existe un chofer con el mismo número de licencia
    IF EXISTS(SELECT * FROM TB_CHOFERES WHERE NumLicencia = @NumLicencia)
    BEGIN
        -- Devolver un mensaje indicando que el chofer ya está registrado
        SELECT 'ERROR: Ya se encuentra registrado el chofer con número de licencia: [' + @NumLicencia + ']'
        RETURN
    END

    -- Si no existe, entonces crea el chofer
    INSERT INTO TB_CHOFERES (Nombres, Apellidos, Genero, Direccion, NumLicencia, VenceLicencia, DisponibilidadC)
    VALUES (@Nombres, @Apellidos, @Genero, @Direccion, @NumLicencia, @VenceLicencia, @DisponibilidadC)
    
    -- Devolver un mensaje indicando que el registro se realizó con éxito
    SELECT 'Se ha registrado correctamente el chofer con número de licencia: [' + @NumLicencia + '].'
END;

-- Procedimiento almacenado para consultar los choferes
CREATE PROCEDURE CONSULTAR_CHOFER
AS
BEGIN
    SELECT * FROM TB_CHOFERES;
END;

-- Procedimiento almacenado para actualizar un chofer
CREATE PROCEDURE ACTUALIZAR_CHOFER
    @IdChofer INT,
    @Nombres VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Genero VARCHAR(1),
    @Direccion VARCHAR(100),
    @NumLicencia VARCHAR(20),
    @VenceLicencia DATE,
    @DisponibilidadC VARCHAR(1)
AS 
BEGIN
    -- Verifica que no se ingrese un número de licencia ya existente
    IF EXISTS(SELECT * FROM TB_CHOFERES WHERE NumLicencia = @NumLicencia AND IdChofer <> @IdChofer)
    BEGIN 
        SELECT 'ERROR: Ya se encuentra registrado un chofer con número de licencia: [' + @NumLicencia + ']';
        RETURN
    END
    
    -- Si no existe, entonces actualiza el chofer
    UPDATE TB_CHOFERES
    SET Nombres = @Nombres,
        Apellidos = @Apellidos,
        Genero = @Genero,
        Direccion = @Direccion,
        NumLicencia = @NumLicencia,
        VenceLicencia = @VenceLicencia,
        DisponibilidadC = @DisponibilidadC
    WHERE IdChofer = @IdChofer;
    
    -- Enviar mensaje de actualización exitosa
    SELECT 'Se ha actualizado correctamente el chofer con número de licencia: [' + @NumLicencia + '].';
END;

-- Procedimiento almacenado para eliminar un chofer
CREATE PROCEDURE ELIMINAR_CHOFER
    @IdChofer INT
AS
BEGIN
    DELETE FROM TB_CHOFERES
    WHERE IdChofer = @IdChofer;
    
    SELECT 'Eliminación exitosa del chofer.'
END;

-- Procedimiento almacenado para consultar la disponibilidad de un chofer
CREATE PROCEDURE CONSULTAR_DISPONIBILIDAD_CHOFER
    @IdChofer INT
AS
BEGIN
    SELECT DisponibilidadC FROM TB_CHOFERES WHERE IdChofer = @IdChofer;
END;

GO

-- Ejemplos de uso

-- REGISTRAR UN CHOFER
EXECUTE REGISTRAR_CHOFER 'John', 'Doe', 'M', 'Calle Principal 123', '1234567890', '2023-12-31', 'Disponible';

-- CONSULTAR CHOFERES
EXECUTE CONSULTAR_CHOFER;

-- ACTUALIZAR UN CHOFER
EXECUTE ACTUALIZAR_CHOFER 1, 'John', 'Doe', 'M', 'Calle Secundaria 456', '1234567890', '2024-12-31', 'No Disponible';

-- ELIMINAR UN CHOFER
EXECUTE ELIMINAR_CHOFER 1;

-- CONSULTAR DISPONIBILIDAD DE UN CHOFER
EXECUTE CONSULTAR_DISPONIBILIDAD_CHOFER 1;

-- ELIMINAR TABLA Y PROCEDIMIENTOS
DROP TABLE TB_CHOFERES;
DROP PROCEDURE REGISTRAR_CHOFER;
DROP PROCEDURE CONSULTAR_CHOFER;
DROP PROCEDURE ACTUALIZAR_CHOFER;
DROP PROCEDURE ELIMINAR_CHOFER;
DROP PROCEDURE CONSULTAR_DISPONIBILIDAD_CHOFER;
