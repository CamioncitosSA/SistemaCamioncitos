USE Camioncitos_DB;
-- Creación de la tabla TB_RUTA
CREATE TABLE TB_RUTA (
    IDRuta INT IDENTITY(1,1) PRIMARY KEY,
    Origen VARCHAR(50) NOT NULL,
    Destino VARCHAR(50) NOT NULL,
    DistanciaR FLOAT NOT NULL,
    TiempoEstimado FLOAT NOT NULL,
    DetallesPedido VARCHAR(100),
    EstadoEntrega VARCHAR(20) NOT NULL
);
select *from TB_RUTA

-- Procedimiento almacenado para registrar una ruta
CREATE PROCEDURE REGISTRAR_RUTA
    @Origen VARCHAR(50),
    @Destino VARCHAR(50),
    @DistanciaR FLOAT,
    @TiempoEstimado FLOAT,
    @DetallesPedido VARCHAR(100),
    @EstadoEntrega VARCHAR(20)
AS
BEGIN
    -- Inserta la ruta en la tabla TB_RUTA
    INSERT INTO TB_RUTA (Origen, Destino, DistanciaR, TiempoEstimado, DetallesPedido, EstadoEntrega)
    VALUES (@Origen, @Destino, @DistanciaR, @TiempoEstimado, @DetallesPedido, @EstadoEntrega);

    -- Devolver un mensaje indicando que el registro se realizó con éxito
    SELECT 'Se ha registrado correctamente la ruta con IDRuta: [' + CAST(SCOPE_IDENTITY() AS VARCHAR) + '].'
END;

-- Procedimiento almacenado para consultar las rutas
CREATE PROCEDURE CONSULTAR_RUTA
AS
BEGIN
    SELECT * FROM TB_RUTA;
END;

-- Procedimiento almacenado para actualizar una ruta
CREATE PROCEDURE ACTUALIZAR_RUTA
    @IDRuta INT,
    @Origen VARCHAR(50),
    @Destino VARCHAR(50),
    @DistanciaR FLOAT,
    @TiempoEstimado FLOAT,
    @DetallesPedido VARCHAR(100),
    @EstadoEntrega VARCHAR(20)
AS 
BEGIN
    -- Actualiza la ruta en la tabla TB_RUTA
    UPDATE TB_RUTA
    SET Origen = @Origen,
        Destino = @Destino,
        DistanciaR = @DistanciaR,
        TiempoEstimado = @TiempoEstimado,
        DetallesPedido = @DetallesPedido,
        EstadoEntrega = @EstadoEntrega
    WHERE IDRuta = @IDRuta;
    
    -- Enviar mensaje de actualización exitosa
    SELECT 'Se ha actualizado correctamente la ruta con IDRuta: [' + CAST(@IDRuta AS VARCHAR) + '].';
END;

-- Procedimiento almacenado para eliminar una ruta
CREATE PROCEDURE ELIMINAR_RUTA
    @IDRuta INT
AS
BEGIN
    -- Elimina la ruta de la tabla TB_RUTA
    DELETE FROM TB_RUTA
    WHERE IDRuta = @IDRuta;
    
    SELECT 'Eliminación exitosa de la ruta.'
END;
go
-- Procedimiento almacenado para generar el comprobante de entrega de una ruta
CREATE PROCEDURE GENERAR_COMPROBANTE_ENTREGA
    @Origen VARCHAR(50),
    @Destino VARCHAR(50),
    @DistanciaR FLOAT,
    @TiempoEstimado FLOAT,
    @DetallesPedido VARCHAR(100),
    @EstadoEntrega VARCHAR(20),
    @Comprobante VARCHAR(100) OUTPUT
AS
BEGIN
    -- Verifica si la ruta existe
    IF NOT EXISTS(SELECT * FROM TB_RUTA WHERE Origen = @Origen AND Destino = @Destino)
    BEGIN
        SELECT 'ERROR: No se encontró la ruta con origen [' + @Origen + '] y destino [' + @Destino + '].';
        RETURN;
    END;

    -- Realizar las operaciones para generar el comprobante de entrega
    -- Aquí puedes agregar la lógica necesaria para generar el comprobante según tus requisitos

    -- Asignar un valor al parámetro de salida Comprobante
    SET @Comprobante = 'Este es el comprobante de entrega para la ruta con origen [' + @Origen + '] y destino [' + @Destino + '].';

    -- Devolver un mensaje indicando que se generó el comprobante de entrega
    SELECT 'Se ha generado el comprobante de entrega para la ruta con origen [' + @Origen + '] y destino [' + @Destino + '].';
END;


go

-- DATOS QUEMADOS
EXECUTE REGISTRAR_RUTA 'Origen A', 'Destino B', 100.0, 2.5, 'Detalles del pedido', 'Entregado';
EXECUTE REGISTRAR_RUTA 'Origen C', 'Destino D', 200.0, 4.0, 'Detalles del pedido', 'En progreso';
EXECUTE REGISTRAR_RUTA 'Origen E', 'Destino F', 150.0, 3.0, 'Detalles del pedido', 'Entregado';
EXECUTE REGISTRAR_RUTA 'Origen G', 'Destino H', 300.0, 6.0, 'Detalles del pedido', 'En progreso';
EXECUTE REGISTRAR_RUTA 'Origen I', 'Destino J', 250.0, 5.0, 'Detalles del pedido', 'Entregado';

-- ELIMINAR TABLA Y PROCEDIMIENTOS
DROP TABLE TB_RUTA;
DROP PROCEDURE REGISTRAR_RUTA;
DROP PROCEDURE CONSULTAR_RUTA;
DROP PROCEDURE ACTUALIZAR_RUTA;
DROP PROCEDURE ELIMINAR_RUTA;
DROP PROCEDURE GENERAR_COMPROBANTE_ENTREGA;
