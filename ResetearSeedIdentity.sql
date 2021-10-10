DECLARE @maxVal INT
SELECT @maxVal = ISNULL(max(nroFactura),0) from Facturas
DBCC CHECKIDENT(Facturas, RESEED, @maxVal)

DECLARE @maxVal INT
SELECT @maxVal = ISNULL(max(idDetalle),0) from DetalleFactura
DBCC CHECKIDENT(DetalleFactura, RESEED, @maxVal)