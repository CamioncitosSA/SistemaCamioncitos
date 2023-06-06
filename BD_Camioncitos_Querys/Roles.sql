USE Camioncitos_DB;

-- Creación de la tabla TB_ROLES
CREATE TABLE TB_ROLES (
    ID_ROL INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE_ROL VARCHAR(80) NOT NULL
);

-- Creación del procedimiento almacenado para registrar un rol
CREATE PROCEDURE REGISTRAR_ROL
    @NOMBRE_ROL VARCHAR(80)
AS
BEGIN
    -- Verifica si ya existe un rol con el mismo nombre
    IF EXISTS(SELECT * FROM TB_ROLES WHERE NOMBRE_ROL = @NOMBRE_ROL)
    BEGIN
        -- Devolver un mensaje indicando que el rol ya existe en el registro
        SELECT 'ERROR: Ya se encuentra registrado el Rol: [' + @NOMBRE_ROL + ']'
        RETURN
    END

    -- Si no existe, entonces crea el rol
    INSERT INTO TB_ROLES (NOMBRE_ROL) VALUES (@NOMBRE_ROL)
    
    -- Devolver un mensaje indicando que el registro se realizó con éxito
    SELECT 'Se ha creado correctamente el rol de: [' + @NOMBRE_ROL + '].'
END;

-- Creación del procedimiento almacenado para consultar los roles
CREATE PROCEDURE CONSULTAR_ROL
AS
BEGIN
    SELECT * FROM TB_ROLES;
END;

-- Creación del procedimiento almacenado para actualizar un rol
CREATE PROCEDURE ACTUALIZAR_ROL
    @ID_ROL INT,
    @NOMBRE_ROL VARCHAR(80)
AS 
BEGIN
    -- Verifica que no se ingrese un rol ya existente
    IF EXISTS(SELECT * FROM TB_ROLES WHERE NOMBRE_ROL = @NOMBRE_ROL AND ID_ROL <> @ID_ROL)
    BEGIN 
        SELECT 'ERROR: Ya se encuentra registrado el Rol: [' + @NOMBRE_ROL + ']';
        RETURN
    END
    
    -- Si no existe, entonces actualiza el rol
    UPDATE TB_ROLES
    SET NOMBRE_ROL = @NOMBRE_ROL
    WHERE ID_ROL = @ID_ROL;
    
    -- Enviar mensaje de actualización exitosa
    SELECT 'SE HA ACTUALIZADO CORRECTAMENTE EL ROL: [' + @NOMBRE_ROL + ']';
END;

-- Creación del procedimiento almacenado para eliminar un rol
CREATE PROCEDURE ELIMINAR_ROL
    @ID_ROL INT
AS
BEGIN
    DELETE FROM TB_ROLES
    WHERE ID_ROL = @ID_ROL;
    
    SELECT 'Eliminación exitosa del Rol.'
END;

-- Insertar roles en la tabla TB_ROLES
INSERT INTO TB_ROLES (NOMBRE_ROL) VALUES ('ADMINISTRADOR');
INSERT INTO TB_ROLES (NOMBRE_ROL) VALUES ('SECRETARIA');
INSERT INTO TB_ROLES (NOMBRE_ROL) VALUES ('GERENTE');
INSERT INTO TB_ROLES (NOMBRE_ROL) VALUES ('CHOFER');

-- VER TABLA
SELECT * FROM TB_ROLES;
