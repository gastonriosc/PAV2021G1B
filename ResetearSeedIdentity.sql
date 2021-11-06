#Resetea el valor IDENTITY al valor maximo que exite en la tabla Facturas

DECLARE @maxVal INT
SELECT @maxVal = ISNULL(max(nroFactura),0) from Facturas
DBCC CHECKIDENT(Facturas, RESEED, @maxVal)

#Resetea el valor IDENTITY al valor maximo que exite en la tabla DetalleFactura

DECLARE @maxVal INT
SELECT @maxVal = ISNULL(max(idDetalle),0) from DetalleFactura
DBCC CHECKIDENT(DetalleFactura, RESEED, @maxVal)